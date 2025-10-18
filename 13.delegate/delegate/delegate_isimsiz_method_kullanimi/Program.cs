using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate_isimsiz_method_kullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EkranaYaz Test1 = new EkranaYaz(delegate(string isim, string soyisim)
            {
                Console.WriteLine(isim + " " + soyisim);
            });
            Test1("Talha", "ÇOBAN");

            // lambda expression
            EkranaYaz Test2 = (isim, soyisim) =>
            {
                Console.WriteLine(isim + " " + soyisim);
            };
            
            Test2("Sude", "KARACA");
        }

        delegate void EkranaYaz(string isim, string soyisim);
    }
}
