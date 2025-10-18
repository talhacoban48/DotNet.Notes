//using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodlar_genel_kullanim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("burdayım");
            selamla();
            ogrenci o1 = new ogrenci();
            o1.ogrenciMethod2();

            int sayi = 0;
            method1(ref sayi);
            System.Console.WriteLine(sayi);

            topla("baba meraba", 5, 6, 7);
        }

        static void topla(string metin1, params int[] sayilar)
        {
            int toplam = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                toplam += sayilar[i];
            }
            System.Console.WriteLine(metin1);
            System.Console.WriteLine("Toplam : " + toplam);
        }

        static void method1(ref int deger)
        {
            deger = 10;
        }
        static void selamla()
        {
            System.Console.WriteLine("Merhaba, Ben bir methodum");
        }
    }
}
