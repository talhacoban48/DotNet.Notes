using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = "Admin";
            string password = "12345";
            string user = "";
            string pass = "";

            do
            {
                Console.Clear();
                Console.Write("lütfen kullanıcı adınızı giriniz : ");
                user = Console.ReadLine();
                Console.Write("Lütfen parolanızı giriniz : ");
                pass = Console.ReadLine();  

            } while (username != user && password != pass);
            Console.WriteLine("Admin girişiniz yapıldı");
        }
    }
}
