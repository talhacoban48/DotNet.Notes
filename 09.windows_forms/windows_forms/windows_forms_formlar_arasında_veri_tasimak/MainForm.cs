using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows_forms_formlar_arasında_veri_tasimak
{
    public partial class MainForm : Form
    {
        public MainForm(string username)
        {
            InitializeComponent();
            lblsayhi.Text = "Hoşgeldiniz " + username;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
