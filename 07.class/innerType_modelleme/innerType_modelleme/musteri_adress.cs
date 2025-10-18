using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace innerType_modelleme
{
    public class musteri_adress
    {
        public string adresstip { get; set; }
        public string il { get; set; }
        public string ilce { get; set; }
        public string adress { get; set; }

        public musteri_adress()
        {
            Console.WriteLine("musteri adress inner type classı çalıştı");
        }

        public void musteriadressdenememethodu()
        {
            Console.WriteLine("musteri adress içindeki method çalıştı");
        }
    }
}
