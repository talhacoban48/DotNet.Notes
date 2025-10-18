using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace innerType_modelleme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            musteri m1 = new musteri();
            m1.kullanıcı_id = 1;
            m1.musteri_id = 1;
            m1.musteri_name = "Talha";
            m1.musteri_surname = "ÇOBAN";
            m1.TCKimlikNo = "54094433114";
            m1.olusturma_tarihi = DateTime.Now;

            //m1.musteriAdresleri = new musteri_adress[5]; bunu yapma!!
            m1.musteriAdresleri[0] = new musteri_adress()
            {
                il = "muğla",
                ilce = "milas",
                adresstip = "ikametgah",
                adress = "adress"
                
            };

            m1.musteriSiparisleri[0] = new musteriSiparis()
            {
                siparisnumarasi = "1",
            };

            m1.musteriSiparisleri[0].urunler[0] = new urun()
            {
                tanim = "ilk ürün",
                fiyat = 30.3M,
                urun_id = 1
            };

            m1.musteriAdresleri[0].musteriadressdenememethodu();
            m1.musteriSiparisleri[0].urunler[0].uruntest();

        }
    }
}
