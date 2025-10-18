using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Assembly lib = Assembly.LoadFile(@"C:\Users\Talha\Desktop\C#\21.Reflection\ClassLibrary\ClassLibrary\bin\Debug\ClassLibrary.dll");
            Type[] TP = lib.GetTypes(); 

            foreach (Type item in TP)
            {
                ConstructorInfo[] CTORS = item.GetConstructors();
                for (int i = 0; i < CTORS.Length; i++)
                {
                    Console.WriteLine(CTORS[i].ToString());
                }
                Console.WriteLine();

                PropertyInfo[] PI = item.GetProperties();
                for (int i = 0;i < PI.Length; i++)
                {
                    Console.WriteLine($"{PI[i].Name} : {PI[i].CanRead} - {item.Namespace} - {item.FullName}");
                }
                Console.WriteLine();

                MethodInfo[] MI = item.GetMethods();
                for (int i = 0; i<MI.Length; i++)
                {
                    Console.WriteLine($"{MI[i].Name} - {MI[i].ReturnParameter} - {MI[i].IsPublic}");
                }
            }

            Console.ReadLine();
        }
    }
}
