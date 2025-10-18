using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sifrelenecekdata = "Talha ÇOBAN";
            string sifrelidata256 = SHA.SHA256Sifrele(sifrelenecekdata);
            string sifrelidata512 = SHA.SHA512Sifrele(sifrelenecekdata);

            Console.WriteLine(sifrelenecekdata);
            Console.WriteLine(sifrelidata256);
            Console.WriteLine(sifrelidata512);
            Console.ReadLine();
        }
    }
}
