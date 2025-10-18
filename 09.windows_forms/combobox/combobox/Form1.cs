using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace combobox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //comboboxdoldur_v1();
            comboboxdoldur_v2();
        }

        void comboboxdoldur_v1()
        {
            foreach (var item in Database.UrunTablo)
            {
                cmbUrunListe.Items.Add(item);
            }
        }

        void comboboxdoldur_v2()
        {
            cmbUrunListe.DataSource = Database.UrunTablo;
        }

        private void cmbUrunListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 1. Yontem => Eğer form içerisinde bulunan form elemanına özel bir metot yazıldıysa o zaman ilgili form elemanını direk olarak çağırnak daha mantıklıdır
            object o1 = cmbUrunListe.SelectedItem;
            Urun u1 = (Urun)o1;

            u1 = cmbUrunListe.SelectedItem == null ? null : cmbUrunListe.SelectedItem as Urun;

            //2. Yontem => çalışma zamanında oluşturmuş oldupumuz form elemanlarında hangisine tıklandıpunı veya işlem yapıldığını bilmediğimiz işin ve metodumuz birden fazla form elemanında olay metodu olarak tanımlandığı iöin biz sender ğüzerinden gelen neseneyş kullanır. kullanıcının hangi windows form elenaında işlem yapmıi olduğunu anlarız
            ComboBox secilenComboBox = sender as ComboBox;

            pctUrunResim.Image = Image.FromFile(u1.KitapResim);
            pctUrunResim.SizeMode = PictureBoxSizeMode.StretchImage;
            txtUrunAdi.Text = u1.urunAdi;
            txtStokAdet.Text = u1.stokAdeti;
            txtKategori.Text = u1.urunKategori;
            txtYazar.Text = u1.yazar;
            kitapDetay.Text = u1.aciklama;
        }
    }
}
