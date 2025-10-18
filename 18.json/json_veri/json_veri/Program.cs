using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace json_veri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Personel> Personeller = new List<Personel>();

            for (int i = 0; i < 1000; i++)
            {
                Personel P = new Personel();
                P.id = Guid.NewGuid();
                P.isim = FakeData.NameData.GetFirstName();
                P.soyisim = FakeData.NameData.GetSurname();
                P.Email = $"{P.isim}.{P.soyisim}@{FakeData.NetworkData.GetDomain()}";
                P.TelefonNumarasi = FakeData.PhoneNumberData.GetPhoneNumber();
                P.Sehir = FakeData.PlaceData.GetCity();

                Personeller.Add(P);

            }

            if (Directory.Exists("C:\\Users\\Talha\\Desktop\\C#\\18.json\\json_veri\\veri"))
            {

            }
            else
            {
                Directory.CreateDirectory("C:\\Users\\Talha\\Desktop\\C#\\18.json\\json_veri\\veri");
            }

            string JsonPersonellerim = Newtonsoft.Json.JsonConvert.SerializeObject(Personeller);

            File.WriteAllText("C:\\Users\\Talha\\Desktop\\C#\\18.json\\json_veri\\veri\\Personellerim.json", JsonPersonellerim);

            Console.WriteLine("Json işlemi tamamlandı");
            Console.ReadLine();

        }
    }
}
