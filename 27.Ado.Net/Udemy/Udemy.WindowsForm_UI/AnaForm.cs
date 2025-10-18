using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Udemy.Entities;

namespace Udemy.WindowsForm_UI
{
    public partial class AnaForm : Form
    {
        Udemy.BLL.BusinessLogicLayer BLL;
        public AnaForm()
        {
            InitializeComponent();
            BLL = new BLL.BusinessLogicLayer();
        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            int sonuc = BLL.KayitEkle(Guid.NewGuid(), txtisim.Text, txtsoyisim.Text, txtTelefon1.Text,
                txtTelefon2.Text, txtTelefon3.Text, txtAdres.Text, txtEmail.Text,
                txtWebsite.Text, txtAciklama.Text);
            if (sonuc > 0)
            {
                MessageBox.Show("Kaydınız başarı bir şekilde eklendi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Doldur();
            }
            else if (sonuc == -100)
            {
                MessageBox.Show("Eksik parametre hatası", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Kayıt ekleme işleminde hata oluştu", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Doldur()
        {
            List<RehberKayit> RehberKayitlarım = BLL.RehberKayitlariGetir();
            if (RehberKayitlarım != null && RehberKayitlarım.Count > 0)
            {
                lstListe.DataSource = RehberKayitlarım;
            }
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            Doldur();
        }

        private void lstListe_DoubleClick(object sender, EventArgs e)
        {
            ListBox L = (ListBox)sender;
            RehberKayit secilendeger = (RehberKayit)L.SelectedItem;
            txtisim.Text = secilendeger.isim;
            txtsoyisim.Text = secilendeger.soyisim;
            txtTelefon1.Text = secilendeger.Telefon1;
            txtTelefon2.Text = secilendeger.Telefon2;
            txtTelefon3.Text = secilendeger.Telefon3;
            txtEmail.Text = secilendeger.Email;
            txtWebsite.Text = secilendeger.Website;
            txtAdres.Text = secilendeger.Adres;
            txtAciklama.Text = secilendeger.Aciklama;

            grpboxKayit.Text = "Rehber kayit Güncelle";
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lstListe.SelectedItem != null)
            {
                Guid id = ((RehberKayit)lstListe.SelectedItem).id;
                int sonuc = BLL.KayitGuncelle(id, txtisim.Text, txtsoyisim.Text, txtTelefon1.Text, txtTelefon2.Text,
                    txtTelefon3.Text, txtAdres.Text, txtEmail.Text, txtWebsite.Text, txtAciklama.Text);
                if (sonuc > 0)
                {
                    MessageBox.Show("Kaydınız başarı bir şekilde güncellendi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Doldur();
                }
                else if (sonuc == -100)
                {
                    MessageBox.Show("Eksik parametre hatası", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Kayıt güncelleme işleminde hata oluştu", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnKayitSil_Click(object sender, EventArgs e)
        {
            Guid silinecekid = ((RehberKayit)lstListe.SelectedItem).id;
            int sonuc = BLL.KayitSil(silinecekid);
            if (sonuc > 0)
            {
                MessageBox.Show("Kaydınız başarı bir şekilde silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Doldur();
            }
            else
            {
                MessageBox.Show("Kayıt silme işleminde hata oluştu", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXmlVer_Click(object sender, EventArgs e)
        {
            int sonuc = BLL.XMLDataVer();
            if (sonuc > 0)
            {
                lbldatadurum.Text = "Durum açıklaması : XML Data export işlemi tamamlandı";
            }
            else
            {
                lbldatadurum.Text = "Durum açıklaması : XML Data export işlemi başarısız";
            }
        }

        private void btnCsvVer_Click(object sender, EventArgs e)
        {
            int sonuc = BLL.CSVDataVer();
            if (sonuc > 0)
            {
                lbldatadurum.Text = "Durum açıklaması : CSV Data export işlemi tamamlandı";
            }
            else
            {
                lbldatadurum.Text = "Durum açıklaması : CSV Data export işlemi başarısız";
            }
        }

        private void btnJsonVer_Click(object sender, EventArgs e)
        {
            int sonuc = BLL.JsonDataVer();
            if (sonuc > 0)
            {
                lbldatadurum.Text = "Durum açıklaması : Json Data export işlemi tamamlandı";
            }
            else
            {
                lbldatadurum.Text = "Durum açıklaması : Json Data export işlemi başarısız";
            }
        }
    }
}
