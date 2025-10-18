using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using matematikselislemler;

namespace dll_islemleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            matematikselislemler.islemler islem = new matematikselislemler.islemler();
            int cevap = islem.topla(21, 23);
            Console.WriteLine(cevap.ToString());

            Console.ReadLine();
        }
    }
}
