using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //baseClass bc1 = new baseClass();
            musteri m1 = new musteri();
            m1.baseClassTest();
            m1.baseClassMethodTest();

            supermusteri sp1 = new supermusteri();
            sp1.baseClassTest();
            sp1.baseClassMethodTest();  
        }
    }
}
