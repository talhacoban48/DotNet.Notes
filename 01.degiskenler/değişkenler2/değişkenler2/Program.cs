using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace değişkenler2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal minDecimalValue = decimal.MaxValue;
            decimal maxDecimalValue = decimal.MinValue;
            Console.WriteLine(minDecimalValue);
            Console.WriteLine(maxDecimalValue);

            float minfloatvalue = float.MinValue;
            float maxfloatvalue = float.MaxValue;
            Console.WriteLine(minfloatvalue);
            Console.WriteLine(maxfloatvalue);  

            //mantıksal değişkenler
            bool kullaniciAdi = false;
            Console.WriteLine(kullaniciAdi);

            //Zamansal değişkenler
            DateTime tarihsaat = DateTime.Now; 
            Console.WriteLine(tarihsaat);
        }
    }
}
