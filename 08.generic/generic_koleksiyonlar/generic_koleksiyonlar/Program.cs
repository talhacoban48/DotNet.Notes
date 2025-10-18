using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic_koleksiyonlar
{
    public class Program
    {
        static void Main(string[] args)
        {
            ArrayList Liste = new ArrayList();
            Liste.Add(1);
            Liste.Add("bir");

            // <T> .net framework içinde olan veya bizim oluşturduğumuz herhangi bir tip demektir
            List<int> liste2 = new List<int>();
            liste2.Add(1);
            liste2.Add(2);
            for (int i = 0; i < liste2.Count; i++)
            {
                Console.WriteLine(liste2[i]);
            }

            List<string> liste3 = new List<string>();
            liste3.Add("Talha");
            liste3.Add("ÇOBAN");
            for (int i = 0; i < liste3.Count; i++)
            {
                Console.WriteLine(liste3[i]);
            }

            List<musteri> musteriListe = new List<musteri>();
            musteriListe.Add(new musteri()
            {
                id = 1,
                isim = "Talha",
                soyisim = "ÇOBAN",
            });
            Console.WriteLine("");
            for (int i = 0; i < musteriListe.Count; i++)
            {
                Console.WriteLine(musteriListe[i].isim);
            }
            Console.WriteLine("");
            foreach (musteri item in musteriListe)
            {
                Console.WriteLine(item.isim);
            }

            int[] degerler = new int[6];
            degerler[0] = 1;
            degerler[1] = 2;
            degerler[2] = 3;
            degerler[3] = 4;
            degerler[4] = 5;
            degerler[5] = 6;

            List<int> sayilar = new List<int>();
            sayilar.AddRange(degerler);

            int capacity = sayilar.Capacity;
            int count = sayilar.Count;
            sayilar.Insert(3, 100);

            Console.WriteLine();
            sayilar.ForEach(i => Console.WriteLine(i));

            bool kontrol1 = sayilar.Any(i => i > 5);
            sayilar.Sort();
            sayilar.Reverse();

            int maximum = sayilar.Max();
            int minimum = sayilar.Min();
            int toplam = sayilar.Sum();

            Console.WriteLine();
            sayilar.Remove(100);
            sayilar.RemoveAt(2);

            sayilar.ForEach(i => Console.WriteLine(i));
            sayilar.RemoveAll(i => i > 3);

            Console.WriteLine();
            sayilar.ForEach(i => Console.WriteLine(i));

            sayilar.Clear();


            // Hashtable
            Hashtable hstable = new Hashtable();
            hstable.Add(1, "bir");
            hstable.Add(2, "iki");
            hstable.Add("doğru", true);

            // Dictionary<Tkey,Tvalue>
            Dictionary<int, string> dictionaryList = new Dictionary<int, string>();
            dictionaryList.Add(1, "bir");
            dictionaryList.Add(2, "iki");
            dictionaryList.Add(3, "üç");
            dictionaryList.Add(4, "dört");
            //dictionaryList.Add(1, "one");

            bool silmesonuc = dictionaryList.Remove(5);
            if (!silmesonuc)
            {
                Console.WriteLine("Aranan değer bulunamadı, silme başarısız");
            }
            bool varmi = dictionaryList.ContainsKey(5);
            if (varmi)
            {
                string gelendeger = dictionaryList[1];
                gelendeger = "yeni_deger";
                dictionaryList[1] = gelendeger;
            }

            bool valuekontrol = dictionaryList.ContainsValue("dört");
            if (valuekontrol)
            {
                Console.WriteLine("Aranan değer bulundu");
            }
            foreach (KeyValuePair<int,string> item in dictionaryList)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
            Console.WriteLine();

            dictionaryList.Clear();

            // generic sortedList
            SortedList<int, string> sList = new SortedList<int, string>();
            sList.Add(5, "beş");
            sList.Add(4, "dört");
            sList.Add(89, "seksendokuz");
            sList.Add(65, "altmışbeş");
        }
    }
}
