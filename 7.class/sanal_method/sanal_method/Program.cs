using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sanal_method
{
    public class Program
    {
        static void Main(string[] args)
        {
            musteri m1 = new musteri();
            m1.musteriID = 1;
            m1.isim = "Talha";
            m1.soyisim = "ÇOBAN";
            string tostringmesaj = m1.ToString();
            Console.WriteLine(tostringmesaj);
        }
    }
}
