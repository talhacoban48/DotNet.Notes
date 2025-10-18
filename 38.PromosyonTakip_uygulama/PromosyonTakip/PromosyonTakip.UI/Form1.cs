using PromosyonTakip.Core.BusinessLogicService;
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
    public partial class KullaniciGiris : Form
    {
        public KullaniciGiris()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtKullaniciAdi.Text) && !string.IsNullOrEmpty(txtSifre.Text))
            {
                SistemMagazaServis servisMagaza = new SistemMagazaServis();
                int magazaID = servisMagaza.MagazaKullaniciKontrol(txtKullaniciAdi.Text, txtSifre.Text);
                if (magazaID > 0)
                {
                    StaticFieldList.magazaID = magazaID;
                    AnaEkran anaEkran = new AnaEkran();
                    anaEkran.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı kullanıcı adi veya şifre", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Form alanlarını eksiksiz doldurunuz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
