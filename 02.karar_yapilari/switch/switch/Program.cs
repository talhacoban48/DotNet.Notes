using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kullanıcı kodu : ");
            string kod = Console.ReadLine().ToUpper();

            switch (kod)
            {
                case "AA":
                case "BB":
                case "CC":
                    Console.WriteLine("Admin yetkisine sahipsiniz");
                    break;
                case "DD":
                    Console.WriteLine("güçlü kullanıcı yetkisine sahipsiniz");
                    break;
                case "EE":
                case "FF":
                case "GG":
                    Console.WriteLine("standart kullanıcı yetkisine sahipsiniz");
                    break;
                default:
                    Console.WriteLine("Hatalı kullanıcı kodu");
                    break;
            }
        }
    }
}
