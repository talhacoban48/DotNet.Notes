using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace auto_property
{
    internal class Program
    {
        static void Main(string[] args)
        {
            araba a = new araba();
            a.Plaka = "48TP318";
            a.marka = "BMW";
            a.motorhacmi = 1900;
            a.motorgucu = 140;
        }
    }
}
