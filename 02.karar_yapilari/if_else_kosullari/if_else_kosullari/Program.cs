using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else_kosullari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("kullanıcı kodu: ");
            string kod = Console.ReadLine().ToUpper();

            if (kod == "ABC" || kod == "123" || kod == "236" || kod == "CMK")
            {
                Console.WriteLine("Kullanıcı girişiniz başarılı");
            }
            else if (kod == "HHH" || kod == "MMM" || kod == "BBB")
            {
                Console.WriteLine("Kullanıcı girişiniz kilitlenmiştir");
            }
            else
            {
                Console.WriteLine("Hatalı kod");
            }
        }
    }
}
