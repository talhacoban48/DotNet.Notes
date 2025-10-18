using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_dongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;
            for (int i = 0; i <= 20; i=i+2)
            {
                Console.WriteLine(i);
                if (i == 6)
                {
                    Console.WriteLine("6. adımdayım");
                }
                toplam += i;
            }
            Console.WriteLine(toplam);

            Console.Write("sayı : ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int faktoriyel = 1;
            for (int i = sayi; i > 0; i--)
            {
                faktoriyel *= i;
            }
            Console.WriteLine("{0} sayısının faktoriyeli {1}'dir", sayi, faktoriyel);

            // Sonsuz döngü
            int sayac = 1;
            for (; ; )
            {
                sayac++;

                if (sayac == 99)
                {
                    Console.WriteLine("bu 99.Adım");
                    continue;
                }
         
                if (sayac == 100)
                {
                    Console.WriteLine("100.Adım");
                    break;
                }
                Console.WriteLine("ben bir sonsuz döngüyüm");
            }
            for (int i = 0; i <= 20; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
