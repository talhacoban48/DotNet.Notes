using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            localhost_myWebService.MyASMX_service service = new localhost_myWebService.MyASMX_service();
            string gelendeger = service.HelloWorld();
            Console.WriteLine(gelendeger);

            localhost_myWebService.Ogrenci ogrenci = service.MerhabaDunya(new localhost_myWebService.Ogrenci()
            {
                id = 1,
                isim = "Talha",
                soyisim = "ÇOBAN",
                sinif = "11B"
            });

            Console.WriteLine(ogrenci.isim.ToString());
            Console.ReadLine();
        }
    }
}
