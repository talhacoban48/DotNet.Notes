using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csv_yazma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<musteri> musteriler = new List<musteri>();

            for (int i = 0; i < 100; i++)
            {
                musteri temp  = new musteri();
                temp.id = Guid.NewGuid();
                temp.isim = FakeData.NameData.GetFirstName();
                temp.soyisim = FakeData.NameData.GetSurname();
                temp.Email = FakeData.NetworkData.GetEmail();
                temp.TelefonNumarasi = FakeData.PhoneNumberData.GetPhoneNumber();

                musteriler.Add(temp);
            }

            StreamWriter SW = new StreamWriter(@"C:\Users\Talha\Desktop\C#\19.csv\\musteriler.csv");
            CsvHelper.CsvWriter write = new CsvHelper.CsvWriter(SW);
            write.WriteHeader(typeof(musteri));
            foreach (musteri temp in musteriler)
            {
                write.WriteRecord(temp);
            }
            SW.Close();


            StreamReader SR = new StreamReader(@"C:\Users\Talha\Desktop\C#\19.csv\\musteriler.csv");
            CsvHelper.CsvReader Reader = new CsvHelper.CsvReader(SR);
            List<musteri> okunandata = Reader.GetRecords<musteri>().ToList();
            foreach (musteri item in okunandata)
            {
                Console.WriteLine(item.isim + " " + item.soyisim);
            }

            Console.ReadLine();
        }
    }
}
