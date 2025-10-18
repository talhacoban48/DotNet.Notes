using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.Entities;
using Newtonsoft;
using System.Linq.Expressions;

namespace Udemy.Core
{
    public class DatabaseLogicLayer
    {
        string DatabasePath;
        string RehberDatabaseFile;
        string KullaniciDatabaseFile;


        List<RehberKayit> kayitlarim;
        public DatabaseLogicLayer()
        {
            DatabasePath = @"C:\Users\Talha\Desktop\C#\23.TelefonRehberiUygulamasi\Udemy\Database";
            RehberDatabaseFile = DatabasePath + @"\Rehber.json";
            KullaniciDatabaseFile = DatabasePath + @"\Kullanici.json";

            kayitlarim = new List<RehberKayit>();
            VeritabaniKontrol();
        }

        private void VeritabaniKontrol()
        {
            bool KlasorKontrol = Directory.Exists(DatabasePath);
            if (!KlasorKontrol)
            {
                Directory.CreateDirectory(DatabasePath);
            }

            Kullanici Demo = new Kullanici();
            Demo.id = Guid.NewGuid();
            Demo.KullaniciAdi = "Demo";
            Demo.Sifre = "12345";
            List<Kullanici> Demos = new List<Kullanici>();
            Demos.Add(Demo);

            string JsonKullaniciTest = Newtonsoft.Json.JsonConvert.SerializeObject(Demos);
            File.WriteAllText(KullaniciDatabaseFile, JsonKullaniciTest);
        }

        public int YeniKayit(RehberKayit K)
        {
            int Sonuc = 0;
            try
            {
                RehberKayitlariGetir(); // class seviyesinde oluşturmuş olduğum koleksiyonun içine verileri dolduruyorum
                kayitlarim.Add(K);
                JsonDBGuncelle(); // var ise üzerine yazdı, yok isi yeni json oluşturdu
                Sonuc = 1;
            }
            catch
            {
                Sonuc = 0;
            }
            return Sonuc;
        }

        public int KayitGuncelle(RehberKayit K)
        {
            int Sonuc = 0;
            try
            {
                RehberKayitlariGetir();
                int index = kayitlarim.FindIndex(I=>I.id == K.id);
                if (index > -1)
                {
                    kayitlarim[index].isim = K.isim;
                    kayitlarim[index].soyisim = K.soyisim;
                    kayitlarim[index].Telefon1 = K.Telefon1;
                    kayitlarim[index].Telefon2 = K.Telefon2;
                    kayitlarim[index].Telefon3 = K.Telefon3;
                    kayitlarim[index].Email = K.Email;
                    kayitlarim[index].Website = K.Website;
                    kayitlarim[index].Adres = K.Adres;
                    kayitlarim[index].Aciklama = K.Aciklama;
                }
                JsonDBGuncelle();
                Sonuc = 1;
            }
            catch
            {
                Sonuc = 0;
            }
            return Sonuc;
        }

        public int KayitSil(Guid id)
        {
            int sonuc = 0;
            try
            {
                RehberKayitlariGetir();
                RehberKayit silinecekdeger = kayitlarim.Find(I=>I.id == id);
                if (silinecekdeger != null)
                {
                    kayitlarim.Remove(silinecekdeger);
                    JsonDBGuncelle();
                    sonuc = 1;
                }
            }
            catch
            {
                sonuc = 0;
            }
            return sonuc;
        }

        public List<RehberKayit> RehberKayitlariGetir()
        {
            if (File.Exists(RehberDatabaseFile))
            {
                string JsonDBText = File.ReadAllText(RehberDatabaseFile);
                kayitlarim = Newtonsoft.Json.JsonConvert.DeserializeObject<List<RehberKayit>>(JsonDBText);
            }
            return kayitlarim;
        }

        public int KullaniciKontrol(Kullanici kullanici)
        {
            int kullaniciSonuc = 0;
            if (File.Exists(KullaniciDatabaseFile))
            {
                string JsonKullaniciText = File.ReadAllText(KullaniciDatabaseFile);
                List<Kullanici> kullanicilar = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Kullanici>>(JsonKullaniciText);
                kullaniciSonuc = kullanicilar.FindAll(I => I.KullaniciAdi == kullanici.KullaniciAdi && I.Sifre == kullanici.Sifre).ToList().Count();
            }
            return kullaniciSonuc;
        }

        #region Yardımcı Methodlar

        private void JsonDBGuncelle()
        {
            if(kayitlarim != null && kayitlarim.Count > 0)
            {
                string JsonDB = Newtonsoft.Json.JsonConvert.SerializeObject(kayitlarim);
                File.WriteAllText(RehberDatabaseFile, JsonDB);
            }
        }

        #endregion
    }
}
