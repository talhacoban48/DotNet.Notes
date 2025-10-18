using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace reflection_uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtObject.Text)) 
            {
                txtObject.BackColor = Color.LightGreen;
                Type T = Type.GetType(txtObject.Text);
                if (T != null)
                {
                    CTORS(T);
                    Properties(T);
                    Methods(T);
                }
                else
                {
                    MessageBox.Show($"{txtObject.Text} sınıfın tipi bulunamadı", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Lütfen bilgi alamk istediğiniz classı yazınız", "bilgilendirme", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtObject.BackColor = Color.LightPink;
            }
        }
        private void CTORS(Type T)
        {
            lstCTORs.Items.Clear();
            ConstructorInfo[] CI = T.GetConstructors();
            foreach (ConstructorInfo ci in CI)
            {
                lstCTORs.Items.Add(ci.ToString());
            }
        }

        private void Properties(Type T)
        {
            lstProperties.Items.Clear();
            PropertyInfo[] PI = T.GetProperties();
            foreach (PropertyInfo pi in PI)
            {
                lstProperties.Items.Add(pi.ToString());
            }
        }

        private void Methods(Type T)
        {
            lstMethods.Items.Clear();   
            MethodInfo[] MI = T.GetMethods();
            foreach (MethodInfo mi in MI)
            {
                lstMethods.Items.Add(mi.Name);
            }
        }
    }
}
