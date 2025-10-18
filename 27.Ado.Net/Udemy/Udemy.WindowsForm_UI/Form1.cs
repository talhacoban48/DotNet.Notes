using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Udemy.WindowsForm_UI
{
    public partial class Form1 : Form
    {
        Udemy.BLL.BusinessLogicLayer BLL;
        public Form1()
        {
            InitializeComponent();
            BLL = new BLL.BusinessLogicLayer();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            int sonuc = BLL.KullaniciKontrol(txtKullaniciAdi.Text, txtSifre.Text);
            if (sonuc > 0 )
            {   
                AnaForm form = new AnaForm();
                form.Show();
            }
            else if (sonuc == -100)
            {
                MessageBox.Show("Form alanlarını eksiksiz doldurunuz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
