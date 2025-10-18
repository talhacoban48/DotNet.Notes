using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace var_anahtar_kelimesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region var anahtar kelimesi

            string isimsoyisim = "Talha ÇOBAN";
            Console.WriteLine(isimsoyisim);

            var meslek = "Bilgisayar Programcısı";
            var kategori = 12;
            kategori = 13;

            Console.WriteLine(meslek);

            #endregion

            #region isimsiz tip kullanımı

            musteri m = new musteri();
            m.isim = "Talha";
            m.soyisim = "ÇOBAN";

            var Ogrenci = new
            {
                numara = 1,
                isim = "Talha",
                soyisim = "ÇOBAN"
            };

            Console.WriteLine(Ogrenci.isim);

            #endregion
        }
    }
}
