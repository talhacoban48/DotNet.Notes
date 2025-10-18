using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MD5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string SifrelenecekMetin = "Talha1COBAN";
            MD5CryptoServiceProvider MD5 = new MD5CryptoServiceProvider();

            byte[] SifrelencekMetinBytes = System.Text.Encoding.UTF8.GetBytes(SifrelenecekMetin);
            byte[] MD5ComputeBytes = MD5.ComputeHash(SifrelencekMetinBytes);
            string sifrelenendeger = Convert.ToBase64String(MD5ComputeBytes);

            Console.WriteLine(sifrelenendeger);
            Console.ReadLine();
        }
    }
}
