using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sanal_method_olusturmak
{
    public class Program
    {
        static void Main(string[] args)
        {
            televizyon t1 = new televizyon();
            t1.ekranaYazdir("hangisi ekrana yazdır methodu çalışcak??");

            urun u1 = new urun();
            u1.ekranaYazdir("program.cs içerisinden urun nesnesi içerisindeki method çağırıldı");

            baseClass b1 = new baseClass();
            b1.ekranaYazdir("program.cs içerisinden baseclass örneklenerek baseclass içerisindeki method çağırıldı");
        }
    }
}
