using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FakeData_GridWiew
{
    public partial class PopupMessage : Form
    {
        Musteri musteridata;
        public PopupMessage(Musteri data)
        {
            InitializeComponent();
            musteridata = data;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PopupMessage_Load(object sender, EventArgs e)
        {
            txtid.Text = musteridata.id.ToString();
            txtisim.Text = musteridata.isim;
            txtsoyisim.Text = musteridata.soyisim;
            txttamad.Text = musteridata.tamAdi;
            txtemail.Text = musteridata.Email;
        }
    }
}
