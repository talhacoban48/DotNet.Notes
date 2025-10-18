using checkbox;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checkbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkedboxlistdoldur_v1();
        }

        void checkedboxlistdoldur_v1()
        {
            foreach (Urun item in Database.UrunTablo)
            {
                chklistbox.Items.Add(item);
            }
        }

        private void chklistbox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int i = 0; i < chklistbox.Items.Count; i++)
            {
                if (i == e.Index)
                {
                    CheckedListBox checkedlistbox = (CheckedListBox)sender;
                    if (e.NewValue == CheckState.Checked)
                    {
                        Urun u1 = checkedlistbox.Items[e.Index] as Urun;
                        pctUrunResim.Image = Image.FromFile(u1.KitapResim);
                        pctUrunResim.SizeMode = PictureBoxSizeMode.StretchImage;
                        txtUrunAdi.Text = u1.urunAdi;
                        txtStokAdet.Text = u1.stokAdeti;
                        txtKategori.Text = u1.urunKategori;
                        txtYazar.Text = u1.yazar;
                        kitapDetay.Text = u1.aciklama;
                    }
                }
                else
                {
                    chklistbox.SetItemChecked(i, false);
                }
            }
        }
    }
}

