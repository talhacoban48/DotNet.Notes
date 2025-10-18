using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yenilikler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string isim = "Talha";
            string soyisim = "ÇOBAN";
            
            Console.WriteLine("Merhaba " + isim + " " + soyisim);

            string karsilamaMetin = string.Format("Merhaba {0} {1}", isim, soyisim);
            Console.WriteLine(karsilamaMetin);

            Console.WriteLine($"Merhaba {isim} {soyisim}");
        }
    }
}
