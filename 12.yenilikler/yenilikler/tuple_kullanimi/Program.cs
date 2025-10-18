using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tuple_kullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tuple<string, int, bool, string, string, int, double> tupleKullanimi =
                new Tuple<string, int, bool, string, string, int, double>
                ("Talha", 1998, true, "ÇOBAN", "Milas", 25, 82.25);

            Console.WriteLine(tupleKullanimi.Item2);

            Tuple<string, string> tuple = Selamla();
            Console.WriteLine($"Merhaba {tuple.Item1} {tuple.Item2}");

            var selamlaDeger = Selamla2();
            Console.WriteLine($"Merhaba {selamlaDeger.isim} {selamlaDeger.soyisim}");
        }

        static Tuple<string, string> Selamla()
        {
            return new Tuple<string, string>("Talha", "ÇOBAN");
        }

        static (string isim, string soyisim) Selamla2()
        {
            return ("Talha", "ÇOBAN");
        }
    }
}
