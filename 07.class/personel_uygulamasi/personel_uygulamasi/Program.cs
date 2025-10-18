using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personel_uygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            personel p1 = new personel();
            p1.isim = "Talha";
            p1.soyisim = "ÇOBAN";
            p1.EmailAdress = "coban";
            p1.cinsiyet = 717770001;

            personel p2 = new personel();
            p2.isim = "Talha";
            p2.soyisim = "ÇOBAN";
            p2.EmailAdress = "coban";
            p2.cinsiyet = 717770001;


            helper.emailGonder("ik@firmam.com", "yeni personel bilgilendirme", p1.isim + p1.soyisim);
            helper.emailGonder("ik@firmam.com", "yeni personel bilgilendirme", p1.isim + p1.soyisim);

        }
    }
}
