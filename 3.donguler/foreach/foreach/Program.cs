using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new[] { "Talha", "müslüm", "fatma", "sude", "mustafa" };
            foreach (string isim in isimler)
            {
                Console.WriteLine(isim);
            }
        }
    }
}
