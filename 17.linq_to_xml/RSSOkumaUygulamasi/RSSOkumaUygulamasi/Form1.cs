using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RSSOkumaUygulamasi
{
    public partial class Haberler : Form
    {
        public Haberler()
        {
            InitializeComponent();
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            List<haber> Kayitlar = XmlCevir();
            lst_baslik.DataSource = Kayitlar;
        }

        private List<haber> XmlCevir()
        {
            List<haber> HaberKayitlari = new List<haber>(); 
            XDocument XmlKaynak = XDocument.Load(txt_rssurl.Text);
            List<XElement> Rows = XmlKaynak.Descendants("item").ToList();
            foreach (XElement item in Rows)
            {
                haber Temp = new haber();
                Temp.baslik = item.Element("title").Value;
                Temp.link = item.Element("link").Value;
                Temp.aciklama = item.Element("description").Value;

                HaberKayitlari.Add(Temp);
            }
            return HaberKayitlari;
        }

        private void lst_baslik_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox secilenDeger = (ListBox)sender;
            haber secilenhaber = (haber)secilenDeger.SelectedItem;
            webBrowser.DocumentText = secilenhaber.aciklama;
        }
    }
}
