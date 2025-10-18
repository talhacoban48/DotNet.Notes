using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lcoal_function
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int toplam = Toplam(1, 5);
            Console.WriteLine(toplam);

            int Carp(int sayi1, int sayi2)
            {
                return sayi1 * sayi2;
            }
            int carpim = Carp(1, 5);
            Console.WriteLine(carpim);

            int Carpma(int sayi1, int sayi2=1) { 
                return sayi1 * sayi2;
            }
            carpim = Carpma(10);
            Console.WriteLine(carpim);
            carpim = Carpma(10, 2);
            Console.WriteLine(carpim);
        }

        static int Toplam(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
    }
}
