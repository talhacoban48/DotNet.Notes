using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_interface
{
    public abstract class baseClass
    {
        public DateTime kayitTarih { get; set; }
        public DateTime guncellemeTarih { get; set; }

        public baseClass()
        {
            kayitTarih = DateTime.Now;
            guncellemeTarih = DateTime.Now;
        }

        public void baseClassTest()
        {
            Console.WriteLine("temel sınıf içideki test methodu");
        }

        public abstract void baseClassMethodTest();
        //{
        //    Console.WriteLine("temel sınıf içindeki abstract method");
        //}
}
}
