using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_kavrami
{
    public class ogrenci
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string email { get; set; }

        public void Test1()
        {
            Console.WriteLine("Nesne örneği alındıktan sonra çalışabilen method");
            Test2(); // static olmayan bir method static olan bir methodu çağırabilir
        }

        public static void Test2()
        {
            Console.WriteLine("Nesne örneği alınmadan çalışabilir");
            // static olan bir method sadece static olan methodları çağırabilir
        }
    }
}
