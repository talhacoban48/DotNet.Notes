using Doviz.Core;
using Doviz.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doviz.WindowsApp
{
    public partial class Form1 : Form
    {
        BusinessLogicLayer BLL;
        public Form1()
        {
            InitializeComponent();
            BLL = new BusinessLogicLayer();
        }

        private void btnjsonDataAlKaydet_Click(object sender, EventArgs e)
        {
            BLL.KurBilgileriniGuncelle();
            MessageBox.Show("yeni veriler geldi");
            inputlariDoldur();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            inputlariDoldur();
        }

        private void inputlariDoldur()
        {
            List<ParaBirimi> parabirimleri = BLL.ParaBirimiListesi();
            List<Kur> kurbilgileri = BLL.KurListe();

            if (kurbilgileri.Count > 0)
            {
                Kur dolar = kurbilgileri.FirstOrDefault(I => I.ParaBirimiID == parabirimleri.FirstOrDefault(m => m.CurrencyName == "US DOLLAR").ParabirimiID);
                txtUSDalis.Text = dolar.ForexBuying.ToString();
                txtUSDsatis.Text = dolar.ForexSelling.ToString();
                Kur euro = kurbilgileri.FirstOrDefault(I => I.ParaBirimiID == parabirimleri.FirstOrDefault(m => m.CurrencyName == "EURO").ParabirimiID);
                txtEUROalis.Text = euro.ForexBuying.ToString();
                txtEUROsatis.Text = euro.ForexSelling.ToString();
                Kur manat = kurbilgileri.FirstOrDefault(I => I.ParaBirimiID == parabirimleri.FirstOrDefault(m => m.CurrencyName == "AZERBAIJANI NEW MANAT").ParabirimiID);
                txtMANATalis.Text = manat.ForexBuying.ToString();
                txtMANATsatis.Text = manat.ForexSelling.ToString();
                Kur iranianrial = kurbilgileri.FirstOrDefault(I => I.ParaBirimiID == parabirimleri.FirstOrDefault(m => m.CurrencyName == "IRANIAN RIAL").ParabirimiID);
                txtIRANRİYALalis.Text = iranianrial.ForexBuying.ToString();
                txtIRANRİYALsatis.Text = iranianrial.ForexSelling.ToString();
                Kur qatarrial = kurbilgileri.FirstOrDefault(I => I.ParaBirimiID == parabirimleri.FirstOrDefault(m => m.CurrencyName == "QATARI RIAL").ParabirimiID);
                txtKATARRİYALalis.Text = qatarrial.ForexBuying.ToString();
                txtKATARRİYALsatis.Text = qatarrial.ForexSelling.ToString();
                Kur japaneseyen = kurbilgileri.FirstOrDefault(I => I.ParaBirimiID == parabirimleri.FirstOrDefault(m => m.CurrencyName == "JAPENESE YEN").ParabirimiID);
                txtJAPONYENalis.Text = japaneseyen.ForexBuying.ToString();
                txtJAPONYENsatis.Text = japaneseyen.ForexSelling.ToString();
                Kur baedirham = kurbilgileri.FirstOrDefault(I => I.ParaBirimiID == parabirimleri.FirstOrDefault(m => m.CurrencyName == "UNITED ARAB EMIRATES DIRHAM").ParabirimiID);
                txtBEADIRHEMalis.Text = baedirham.ForexBuying.ToString();
                txtBEADIRHEMsatis.Text = baedirham.ForexSelling.ToString();
                Kur koreanwon = kurbilgileri.FirstOrDefault(I => I.ParaBirimiID == parabirimleri.FirstOrDefault(m => m.CurrencyName == "SOUTH KOREAN WON").ParabirimiID);
                txtKOREANWONalis.Text = koreanwon.ForexBuying.ToString();
                txtKOREANWONsatis.Text = koreanwon.ForexSelling.ToString();
                Kur sterling = kurbilgileri.FirstOrDefault(I => I.ParaBirimiID == parabirimleri.FirstOrDefault(m => m.CurrencyName == "POUND STERLING").ParabirimiID);
                txtSTERLINalis.Text = sterling.ForexBuying.ToString();
                txtSTERLINsatis.Text = sterling.ForexSelling.ToString();

                grd_kurgecmis.DataSource = BLL.KurGecmisGorontule();
            }
            else
            {

            }
        }
    }
}
