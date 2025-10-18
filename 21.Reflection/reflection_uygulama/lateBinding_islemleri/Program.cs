using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace lateBinding_islemleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Assembly Exec = Assembly.GetExecutingAssembly();
            Type T = Exec.GetType("lateBinding_islemleri.musteri");

            object MusteriInstance = Activator.CreateInstance(T);
            MethodInfo MI = T.GetMethod("MusteriIsimGetir");

            string[] parametrelerim = new string[2];
            parametrelerim[0] = "Talha";
            parametrelerim[1] = "ÇOBAN";

            string donendeger = (string)MI.Invoke(MusteriInstance, parametrelerim);

            Console.WriteLine(donendeger);
            Console.ReadLine();

        }
    }
}
