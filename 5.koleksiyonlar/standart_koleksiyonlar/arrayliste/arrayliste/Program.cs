using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayliste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int islem = 0;
            ArrayList degerListesi = new ArrayList();
            do
            {
                Console.WriteLine("MENU");
                Console.WriteLine("1-Değer Ekle");
                Console.WriteLine("2-Değer Listele");
                Console.WriteLine("3-Değer Ara");
                Console.WriteLine("4-Değer Düzenle");
                Console.WriteLine("5-Değer Sil");
                Console.WriteLine("6-Çık");
                Console.Write("Deger işlemi: ");
                islem = Convert.ToInt32(Console.ReadLine());

                switch (islem)
                {
                    case 1:
                        Console.Write("Deger giriniz: ");
                        object deger = Console.ReadLine();
                        degerListesi.Add(deger);   
                        break;
                    case 2:
                        Console.WriteLine("\nDeğerler: ");
                        foreach (object item in degerListesi)
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("\n");
                        break;
                    case 3:
                        Console.Write("Hangi değerin indexini arıyorsunuz: ");
                        object deger2 = Console.ReadLine();
                        bool kontrol = degerListesi.Contains(deger2);
                        if (kontrol)
                        {
                            int index = degerListesi.IndexOf(deger2);
                            Console.WriteLine(index);
                        }
                        else
                        {
                            Console.WriteLine("Böyle bir değer yok");
                        }
                        break;
                    case 4:
                        Console.Write("Hangi değeri güncellemek istiyorsunuz: ");
                        object deger3 = Console.ReadLine();
                        bool kontrol2 = degerListesi.Contains(deger3);
                        if (kontrol2)
                        {
                            int index = degerListesi.IndexOf(deger3);
                            Console.Write("Yeni değeri giriniz: ");
                            object yenideger = Console.ReadLine();
                            degerListesi[index] = yenideger;
                            Console.WriteLine("değer güncellendi");
                        }
                        else
                        {
                            Console.WriteLine("Böyle bir değer yok");
                        }
                        break;
                    case 5:
                        Console.Write("Hangi değeri silmek istiyorsunuz: ");
                        object deger4 = Console.ReadLine();
                        bool kontrol3 = degerListesi.Contains(deger4);
                        if (kontrol3)
                        {
                            degerListesi.Remove(deger4);    
                            Console.WriteLine("deger silindi");
                        }
                        else
                        {
                            Console.WriteLine("Böyle bir değer yok");
                        }
                        break;
                    case 6:
                        break;
                    default:
                        Console.WriteLine("Yanlış islem adımı!!");
                        break;
                }
            } while (islem != 6);
        }
    }
}
