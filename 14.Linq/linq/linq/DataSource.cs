using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    internal class DataSource
    {
        List<Musteri> musteriler;

        public DataSource()
        {
            musteriler = new List<Musteri>();
        }

        public List<Musteri> musteriListesi()
        {
            for (int i = 0; i < 1000; i++)
            {
                Musteri musteri = new Musteri();
                musteri.MusteriNumara = i;
                musteri.isim = FakeData.NameData.GetFirstName();
                musteri.soyisim = FakeData.NameData.GetSurname();
                musteri.dogumtarih = FakeData.DateTimeData.GetDatetime(new DateTime(1994, 01, 01), new DateTime(2005, 01, 01));
                musteri.ulke = FakeData.PlaceData.GetCounty();
                musteri.il = FakeData.PlaceData.GetCity();
                musteri.ilce = FakeData.PlaceData.GetCounty();
                musteri.Email = $"{musteri.isim.ToLower()}.{musteri.soyisim.ToLower()}@{FakeData.NetworkData.GetDomain()}";
                musteri.MusteriNumara = FakeData.NumberData.GetNumber();
                musteriler.Add(musteri);
            }

            return musteriler;
        }
    }
}
