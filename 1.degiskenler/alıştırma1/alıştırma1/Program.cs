using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alıştırma1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merhabalar");
            Console.Write("isminiz nedir : ");
            string isim = Console.ReadLine();
            Console.Write("soyisminiz : ");
            string soyisim = Console.ReadLine();
            Console.Clear();
            Console.WriteLine(isim + soyisim);
            Console.ReadLine();
        }
    }
}
