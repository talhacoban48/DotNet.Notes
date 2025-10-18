using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace messagebox_uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            int Response = AddNewCustemer(new Custemer()
            {
                id = Guid.NewGuid(),
                Name = txtName.Text,
                LastName = txtLastName.Text,
                Email = txtEmail.Text,
                PhoneNo = txtPhoneNo.Text,
            });

            if (Response > 0)
            {
                DialogResult result = MessageBox.Show("Müşteri Ekleme işleme başarılı", "yeni müşteri kaydı eklemek ister misiniz?",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    bildirimCubugu = new NotifyIcon();
                    bildirimCubugu.BalloonTipText = "Toplam Kayıt Sayısı : " + Sanal_Database.Custemers.Count.ToString();
                    bildirimCubugu.BalloonTipTitle = "Toplam Adet Bilgisi";
                    bildirimCubugu.Visible = true;
                    bildirimCubugu.Icon = SystemIcons.Information;
                    bildirimCubugu.ShowBalloonTip(2000);
                }
                else if(result == DialogResult.No)
                {

                }

                ClearWindow();
                ListWindow();

            }
            else
            {
                MessageBox.Show("Hata : Kayıt ekleme işlemi yapılamadı");
            }

        }

        private void ListWindow()
        {
            lstCustermers.DataSource = Sanal_Database.Custemers;
        }

        private void ClearWindow()
        {
            txtName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPhoneNo.Text = string.Empty;
        }
        private int AddNewCustemer(Custemer data)
            {
                Sanal_Database.Custemers.Add(data);
                return 1;
            }
    }
}
