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
    public partial class frmOnizlemeKayıt : Form
    {
        public frmOnizlemeKayıt()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            sanalDatabase.customers.Add(new Customer
            {
                id = Guid.NewGuid(),
                isim = txtIsim.Text,
                soyisim = txtSoyisim.Text,
                email = txtEmail.Text,
                Telefon = txtTelefon.Text
            });

            Form yakalananForm = Application.OpenForms["Form1"];

            foreach (Form item in Application.OpenForms)
            {
                if (item.Name == "Form1")
                {
                    foreach (Control Formitem in item.Controls)
                    {
                        if (Formitem is TextBox)
                        {
                            ((TextBox)Formitem).Text = string.Empty;
                        }
                    }
                }
            }
            this.Close();
        }
    }
}
