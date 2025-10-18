using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partial_class
{
    public class Program
    {
        static void Main(string[] args)
        {
            musteri m1 = new musteri();
            m1.id = 1;
            m1.isim = "Talha";
            m1.soyisim = "ÇOBAN";

            int sonuc1 = m1.yenikayit(m1);
            if (sonuc1 > 0)
            {
                Console.WriteLine("kayit yapıldı");
            }
            int sonuc2 = m1.kayitguncelle(m1);
            int sonuc3 = m1.kayitsil(m1);

            ogrenci o1 = new ogrenci();
            o1.id = 2;
            o1.isim = "Talha";
            o1.soyisim = "ÇOBAN";
            int sonuc4 = o1.yenikayit(o1);
            if(sonuc4 > 0)
            {
                Console.WriteLine("öğrenci kaydedildi");
            }
        }
    }
}
