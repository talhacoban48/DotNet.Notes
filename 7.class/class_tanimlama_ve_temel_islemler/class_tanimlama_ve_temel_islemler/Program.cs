using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_tanimlama_ve_temel_islemler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            arac A1 = new arac("BMW", "318is", 1997, 269898.9M);
            A1.alıs_fiyat = 144000.0M;
            A1.satıs_fiyat = 180000.0M;
            A1.max_indirim_fiyat = 5000.0M;
            A1.BilgileriGoruntule();


            musteri m1 = new musteri();
            m1.isim = "Talha";
            m1.soyisim = "ÇOBAN";
            m1.TCNumarasi = "54103432800";
            m1.Cinsiyet = 717770001;

            musteri m2 = m1;
            m2.isim = "Mehmet";
            m2.TCNumarasi = "54094433114";

            // referance tipli davranış
            m1 = null;
            m2 = null;
            //string isim = m2.isim;

            musteri m3 = new musteri("Sude", "Karaca");

        }
    }
}
