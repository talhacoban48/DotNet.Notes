using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeData_GridWiew
{
    public class Database
    {
        public List<Musteri> musteriler = new List<Musteri>();
        public Database()
        {
            
        }
        public List<Musteri> MusteriListele()
        {
            for (int i = 1; i < 1001; i++)
            {
                Musteri Temp = new Musteri();
                Temp.id = Guid.NewGuid();
                Temp.isim = FakeData.NameData.GetFirstName();
                Temp.soyisim = FakeData.NameData.GetSurname();
                Temp.tamAdi = $"{Temp.isim} {Temp.soyisim}";
                Temp.Email = FakeData.NetworkData.GetEmail(Temp.isim, Temp.soyisim);
                Temp.Telefon = FakeData.PhoneNumberData.GetInternationalPhoneNumber();
                Temp.il = FakeData.PlaceData.GetCity();
                Temp.ilce = FakeData.PlaceData.GetCountry();
                Temp.adres = FakeData.PlaceData.GetAddress();
                musteriler.Add(Temp);
            }
            return musteriler;
        }
    }
}
