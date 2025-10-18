using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetFramework.S19.D2.KullaniciGirisUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;

            kullanici bulunanKullanici = sanalDatabase.KullaniciTablo.Find(i => i.kullaniciAdi == kullaniciAdi && i.sifre == sifre);

            // kullaniciAdi == "admin" && sifre == "123"
            if (bulunanKullanici != null)
            {
                anaForm _anaform = new anaForm(bulunanKullanici);
                _anaform.Show();
            }
            else
            {
                // windows form içerisinde nasıl kullanıcıya bir popup gösteririz bunu cok ufak bir şekilde inceleyelim. 
                // ayrı bir konu olarak eğitim içerisinde detaylı bulacaksınız. 

                MessageBox.Show("Hatalı kullanıcı bilgileri","Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtKullaniciAdi_Enter(object sender, EventArgs e)
        {
            TextBox T1 = (TextBox)sender;
            T1.BackColor = Color.Yellow;
        }

        private void txtKullaniciAdi_Leave(object sender, EventArgs e)
        {
            TextBox T1 = (TextBox)sender;
            T1.BackColor = Color.White;
        }
    }
}
