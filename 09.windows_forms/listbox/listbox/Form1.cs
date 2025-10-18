using combobox;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //listboxdoldur_v1();
            listboxdoldur_v2();

        }

        void listboxdoldur_v1()
        {
            foreach (var item in Database.UrunTablo)
            {
                lstUrunler.Items.Add(item);
            }
        }
        void listboxdoldur_v2()
        {
            lstUrunler.DisplayMember = "urunAdi";
            lstUrunler.DataSource = Database.UrunTablo;
        }

        private void lstUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            int urunSecimAdet = lstUrunler.SelectedItems.Count;
            if(urunSecimAdet == 1)
            {
                ListBox lbox = (ListBox)sender;
                Urun u1 = (Urun)lbox.SelectedItem;
                pctUrunResim.Image = Image.FromFile(u1.KitapResim);
                pctUrunResim.SizeMode = PictureBoxSizeMode.StretchImage;
                txtUrunAdi.Text = u1.urunAdi;
                txtStokAdet.Text = u1.stokAdeti;
                txtKategori.Text = u1.urunKategori;
                txtYazar.Text = u1.yazar;
                kitapDetay.Text = u1.aciklama;
            }
            else if(urunSecimAdet > 1)
            {
                List<Urun> secilenUrunler = new List<Urun>();
                foreach (Urun item in lstUrunler.Items)
                {
                    secilenUrunler.Add(item);
                }
                Urun u1 = secilenUrunler[0];
                pctUrunResim.Image = Image.FromFile(u1.KitapResim);
                pctUrunResim.SizeMode = PictureBoxSizeMode.StretchImage;
                txtUrunAdi.Text = u1.urunAdi;
                txtStokAdet.Text = u1.stokAdeti;
                txtKategori.Text = u1.urunKategori;
                txtYazar.Text = u1.yazar;
                kitapDetay.Text = u1.aciklama;
            }
            else
            {
                MessageBox.Show("Lütfen Detayını görnek istediğiniz ürünü seçiniz",
                    "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
