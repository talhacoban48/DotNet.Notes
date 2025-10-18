using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayac = 0;
            while (true)
            {
                if (sayac % 5 == 0)
                {
                    Console.WriteLine(sayac);
                }
                sayac++;
                if (sayac == 101)
                {
                    break;
                }
            }
           
        }
    }
}
