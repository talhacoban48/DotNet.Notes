using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sanal_method_olusturmak
{
    public class urun:baseClass
    {
        public override void ekranaYazdir(string data)
        {
            Console.WriteLine("urun => " + data);
        }
    }
}
