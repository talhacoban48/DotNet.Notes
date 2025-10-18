using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormKontrolleriInceleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Button => this.controls.Add(); // control ...
            //foreach (Control item in this.Controls)
            //{
            //    MessageBox.Show(item.ToString());
            //}
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            DialogResult response = MessageBox.Show("Temizlemek istediğinize emin misiniz?", "Girdiler temizlenecek", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (response == DialogResult.Yes)
            {
                FormElemanIndexTemizle();
            }
            else if (response == DialogResult.No)
            {

            }
        }

        private void FormElemanIndexTemizle()
        {
            ((TextBox)this.Controls["txtIsim"]).Text = string.Empty;
            ((TextBox)this.Controls["txtSoyisim"]).Text = string.Empty;
            ((TextBox)this.Controls["txtEmail"]).Text = string.Empty;
            ((TextBox)this.Controls["txtTelefon"]).Text = string.Empty;
        }

        private void FormTemizle()
        {
            //txtIsim.Text = string.Empty;
            //txtSoyisim.Text = string.Empty;
            //txtEmail.Text = string.Empty;
            //txtTelefon.Text = string.Empty;
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox textBox = (TextBox)item;
                    textBox.Text = string.Empty;
                }
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            sanalDatabase.customers.Add(new Customer
            {
                id = Guid.NewGuid(),
                isim = txtIsim.Text,
                soyisim = txtSoyisim.Text,
                email = txtEmail.Text,
                Telefon = txtTelefon.Text
            });

            FormTemizle();
        }

        private void btnOnizlme_Click(object sender, EventArgs e)
        {
            frmOnizlemeKayıt onizle = new frmOnizlemeKayıt();
            ((TextBox)onizle.Controls["txtIsim"]).Text = txtIsim.Text;
            ((TextBox)onizle.Controls["txtSoyisim"]).Text = txtSoyisim.Text;
            ((TextBox)onizle.Controls["txtEmail"]).Text = txtEmail.Text;
            ((TextBox)onizle.Controls["txtTelefon"]).Text = txtTelefon.Text;
            onizle.ShowDialog();
            
        }
    }
}
