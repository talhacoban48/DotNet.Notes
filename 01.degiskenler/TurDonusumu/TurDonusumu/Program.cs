using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurDonusumu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //biliçli tür dönüşümü
            byte sayi1 = 100;
            int sayi2 = sayi1;
            Console.WriteLine(sayi1);
            Console.WriteLine(sayi2);

            //bilinçsiz tür dönüşümü
            int sayi3 = 255;
            byte sayi4 = (byte)sayi3;
            Console.WriteLine(sayi3);
            Console.WriteLine(sayi4);

            //object
            //boxing
            object o1 = 100;
            object o2 = 10.90;
            object o3 = true;
            Console.WriteLine(o2);

            //convert ve parse işlemleri
            string metin1 = "1000";
            int s1 = int.Parse(metin1);
            int s2 = Convert.ToInt32(metin1);
            Console.WriteLine(s1);
            Console.WriteLine(s2);

            string ifade = "true";
            bool b2 = bool.Parse(ifade);
            bool b1 = Convert.ToBoolean(ifade);
            Console.WriteLine(b1);
            Console.WriteLine(b2);

            string metin2 = null;
            //decimal d1 = decimal.Parse(metin2);
            decimal d2 = Convert.ToDecimal(metin2);
            //Console.WriteLine(d1); 
            Console.WriteLine(d2);
            bool b3 = Convert.ToBoolean(metin2);
            Console.WriteLine(b3);

            string metin3 = "1";
            int metin4 = int.Parse(metin3);
            bool b4 = Convert.ToBoolean(metin4);
            Console.WriteLine(b4);

            //var anahtar kelimesi
            int s4 = 17;
            var s5 = 10000;
            var metin5 = "metin";

        }
    }
}
