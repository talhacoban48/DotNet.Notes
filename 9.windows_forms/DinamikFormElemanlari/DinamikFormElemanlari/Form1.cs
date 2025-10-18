using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinamikFormElemanlari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnbtnuret_Click(object sender, EventArgs e)
        {
            int mayin1 = 0;
            int mayin2 = 0;
            int mayin3 = 0;

            Random rnd = new Random();
            mayin1 = rnd.Next(1, 20);
            mayin2 = rnd.Next(21, 40);
            mayin3 = rnd.Next(41, 50);

            for (int i = 0; i < 50; i++)
            {
                Button btnTemp = new Button();
                btnTemp.Name = "btn" + (1 + i).ToString();
                btnTemp.Size = new System.Drawing.Size(35, 35);
                btnTemp.Text = (1 + i).ToString();
                btnTemp.Tag = null;
                btnTemp.Click += btnTemp_Click;
                btnTemp.UseVisualStyleBackColor = true;
                if (mayin1 == i || mayin2 == i || mayin3 == i)
                {
                    btnTemp.Tag = true;
                }
                else
                {
                    btnTemp.Tag = false;
                }
                flowLayoutPanel1.Controls.Add(btnTemp);
            }
        }

        private void btnTemp_Click(object sender, EventArgs e)
        {
            Button basilan_buton = ((Button)sender);
            bool mayinBulundumu = (bool)basilan_buton.Tag;
            if (mayinBulundumu)
            {
                MessageBox.Show("Mayına tıkladınız!!");
                basilan_buton.BackColor = Color.Red;
            }
            else
            {
                basilan_buton.BackColor = Color.Green;
                int skorInt = (int)
            }
        }
    }
}

