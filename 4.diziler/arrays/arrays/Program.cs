using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] ogrenciIsimListesi = new string[5];
            ogrenciIsimListesi[0] = "Talha ÇOBAN";
            ogrenciIsimListesi[1] = "Sude Karaca";
            ogrenciIsimListesi[2] = "Sude ÇOBAN";
            ogrenciIsimListesi[3] = "Mustafa cengiz";
            ogrenciIsimListesi[4] = "peter starr";


            Console.WriteLine(ogrenciIsimListesi[2]);
            Console.WriteLine("");

            foreach (string ogrenciIsim in ogrenciIsimListesi)
            {
                Console.WriteLine(ogrenciIsim);
            }
            Console.WriteLine("");
            for (int i = 0; i < ogrenciIsimListesi.Length; i++)
            {
                Console.WriteLine(ogrenciIsimListesi[i]);
            }

            Console.WriteLine("");
            Console.Write("dizi kaç elemanlı olsun : ");
            int elemansayisi = Convert.ToInt32(Console.ReadLine());

            decimal[] dizi = new decimal[elemansayisi];
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.Write("{0}. sayıyı giriniz: ", i+1);
                dizi[i] = Convert.ToDecimal(Console.ReadLine());
            }
            decimal ort = 0M;
            foreach (decimal i in dizi)
            {
                ort += (i/dizi.Length);
            }
            Console.WriteLine("Girdiğiniz sayıların ortalaması {0}\n\n", ort);

            Random rnd = new Random();
            int[] ints = new int[50];
            for (int i = 0; i < ints.Length; i++)
            {
                ints[i] = rnd.Next(1, 10);
            }
            int count = 0;
            foreach(int i in ints)
            {
                if (i == 4)
                {
                    count++;
                }
            }
            Console.WriteLine("{0} tane 4 sayısı yakalandı", count);
        }
    }
}
