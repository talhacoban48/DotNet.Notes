using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            matematikselislemler.islemler islem = new matematikselislemler.islemler();
            int sonuc = islem.carp(2131, 234324);
            
            Console.WriteLine(sonuc.ToString());
            Console.ReadLine();
        }
    }
}
