using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_interface
{
    public class musteri:baseClass
    {
        public int musteri_id { get; set; }
        public musteri()
        {
            musteri_id = 1;
        }

        public override void baseClassMethodTest()
        {
            Console.WriteLine("temel sınıf içindeki abstract method");
        }
    }
}
