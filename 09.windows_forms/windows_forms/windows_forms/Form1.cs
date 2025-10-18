using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textmessage.Text = "Metin giriniz:";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnac_Click(object sender, EventArgs e)
        {
            
            string textMessageValue = textmessage.Text;

            
            merhaba_form merhaba_form = new merhaba_form(textMessageValue);
            merhaba_form.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textmessage_Click(object sender, EventArgs e)
        {
            TextBox T1 = (TextBox)sender;
            T1.Text = string.Empty;
        }
    }
}
