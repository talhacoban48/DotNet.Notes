using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dynamic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var deger = "Talha ÇOBAN";
            //deger = 1;

            dynamic deger2 = "Sude Karaca";
            deger2 = 1;
            deger2 = false;
            deger2 = new
            {
                isim = "Talha",
            };
        }
    }
}
