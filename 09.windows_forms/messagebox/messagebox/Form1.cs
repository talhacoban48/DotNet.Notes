using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace messagebox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnmesajgoster_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kullanıcıya göstermek istediğimiz bilgi", "Başlık Bilgisi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnAskQuestion_Click(object sender, EventArgs e)
        {
            DialogResult result =  MessageBox.Show("yeniden denemek ister misniz?","soru",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

            }
            else if(result == DialogResult.No)
            {

            }
            else if(result == DialogResult.Cancel)
            {

            }
        }
    }
}
