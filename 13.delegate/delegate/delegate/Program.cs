using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Topla(10, 5);
            //Carp(10, 5);
            //Bol(10, 5);
            //Cikart(10, 5);

            matematikselislemler m1 = new matematikselislemler(Topla);
            
            m1 += Carp;
            m1 += Cikart;
            m1 += Bol;

            m1.Invoke(203, 5);

            Delegate[] isaretedilenmetodlar = m1.GetInvocationList();
            foreach(var item in isaretedilenmetodlar)
            {
                Console.WriteLine(item.Method.Name);
            }
            Console.WriteLine("");
            m1 -= Carp;
            foreach (var item in m1.GetInvocationList())
            {
                Console.WriteLine(item.Method.Name);
            }
            Console.WriteLine("");
            m1 -= Cikart;
            foreach (var item in m1.GetInvocationList())
            {
                Console.WriteLine(item.Method.Name);
            }
            Console.WriteLine("");
            m1 -= Bol;
            foreach (var item in m1.GetInvocationList())
            {
                Console.WriteLine(item.Method.Name);
            }
        }

        delegate void matematikselislemler(int sayi1, int sayi2);
        static void Topla(int sayi1, int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("toplam: " + sonuc);
        }
        static void Carp(int sayi1, int sayi2)
        {
            int sonuc = sayi1 * sayi2;
            Console.WriteLine("çarpım: " + sonuc);
        }
        static void Cikart(int sayi1, int sayi2)
        {
            int sonuc = sayi1 - sayi2;
            Console.WriteLine("çıkart :" + sonuc);
        }
        static void Bol(int sayi1, int sayi2)
        {
            int sonuc = sayi1 / sayi2;
            Console.WriteLine("Bölüm: " + sonuc);
        }
    }
}
