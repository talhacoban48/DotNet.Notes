using PromosyonTakip.Core.BusinessLogicService;
using PromosyonTakip.Core.Entites;
using PromosyonTakip.Core.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PromosyonTakip.UI
{
    public partial class AnaEkran : Form
    {
        PotansiyelMusteri data;
        public AnaEkran()
        {
            InitializeComponent();
        }
        private void AnaEkran_Load(object sender, EventArgs e)
        {
            cmbCinsiyet.DataSource = StaticFieldList.CinsiyetGetir();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            GroupBox musteriBilgileri = (GroupBox)this.Controls["grpMusteriBilgileri"];
            foreach (Control item in musteriBilgileri.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = string.Empty;
                }
                else if (item is CheckBox)
                {
                    ((CheckBox)item).Checked = false;
                }
                else if (item is ComboBox)
                {
                    ((ComboBox)item).SelectedIndex = 0;
                }
                else if (item is DateTimePicker)
                {
                    ((DateTimePicker)item).ResetText();
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            PotansiyelMusteriServis servisPotansiyelMusteri = new PotansiyelMusteriServis();
            int tckontrol = servisPotansiyelMusteri.TCKayitSorgula(txtTCKimlikNo.Text);
            if (tckontrol > 0)
            {
                MessageBox.Show("Daha önce kaydoldunuz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                data = new PotansiyelMusteri();
                data.tckimlik = txtTCKimlikNo.Text;
                data.isim = txtIsim.Text;
                data.soyisim = txtSoyisim.Text;
                data.dogumtarih = txtDogumTarih.Value;
                data.cinsiyet = ((Cinsiyet)cmbCinsiyet.SelectedItem).id;
                data.meslek = txtMeslek.Text;
                data.Email = txtEmail.Text;
                data.EmailBildirimOnay = chkEpostaOnay.Checked;
                data.Telefon = txtTelefonNo.Text;
                data.TelefonBildirimOnay = chkSMSOnay.Checked;
                data.OlusturmaTarihi = DateTime.Now;
                data.OlusturanMagaza = StaticFieldList.magazaID;

                int MusteriKayit = servisPotansiyelMusteri.KayitYeni(data);
                if (MusteriKayit > 0)
                {
                    MessageBox.Show("kayit Başarılı. lütfen hediye seçiminizi yapınız", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HediyeSecimHazirla();
                }
                else
                {
                    MessageBox.Show("Sistemsel hata", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void HediyeSecimHazirla()
        {
            List<PromosyonUrun> hediyeurunlistesi = new List<PromosyonUrun>();
            PromosyonUrunServis urunservis = new PromosyonUrunServis();
            hediyeurunlistesi = urunservis.UrunListesiGetir();
            if (hediyeurunlistesi != null && hediyeurunlistesi.Count > 0)
            {
                for (int i = 0; i < hediyeurunlistesi.Count; i++)
                {
                    System.Threading.Thread.Sleep(50);
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Width = 48;
                    pictureBox.Height = 55;
                    pictureBox.Image = Image.FromFile(@"C:\Users\Talha\Desktop\C#\38.PromosyonTakip_uygulama\PromosyonTakip\PromosyonTakip.UI\images\gift.png");
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.Tag = hediyeurunlistesi[i];
                    pictureBox.Click += pictureBox_click;
                    hediyepanel.Controls.Add(pictureBox);
                }
            }
            else
            {
                MessageBox.Show("Kampanya sona erdi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pictureBox_click(object sender, EventArgs e)
        {
            PictureBox secilenhediye = (PictureBox)sender;
            PromosyonUrun kazanilanUrun = (PromosyonUrun)secilenhediye.Tag;
            if (kazanilanUrun != null && kazanilanUrun.ID > 0)
            {
                PromosyonUrunServis servisPromosyon = new PromosyonUrunServis();
                KatilimciPromosyonServis servisKatilimci = new KatilimciPromosyonServis();
                PotansiyelMusteriServis servisPotansiyelMusteri = new PotansiyelMusteriServis();
                servisPromosyon.UrunKullanildi(kazanilanUrun.ID);
                servisKatilimci.KayitYeni(new KatilimciPromosyon()
                {
                    MagazaID = StaticFieldList.magazaID,
                    OlusturmaTarihi = DateTime.Now,
                    PromosyonUrunID = kazanilanUrun.ID,
                    PotansiyelMusteriID = servisPotansiyelMusteri.TCKayitSorgula(txtTCKimlikNo.Text)
                });
                MessageBox.Show($"{kazanilanUrun.aciklama} {kazanilanUrun.tanim} indirim kazandınız", "Tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Kampanya sona erdi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
