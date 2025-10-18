using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Udemy.Entities;

namespace Udemy.BLL
{
    public class BusinessLogicLayer
    {
        Udemy.Core.DatabaseLogicLayer DLL;
        public BusinessLogicLayer()
        {
            DLL = new Udemy.Core.DatabaseLogicLayer();
        }

        public int KullaniciKontrol(string KullaniciAdi, string Sifre)
        {
            int sonuc = 0;
            if (!string.IsNullOrEmpty(KullaniciAdi) && !string.IsNullOrEmpty(Sifre))
            {
                Kullanici kullanici = new Kullanici();
                kullanici.KullaniciAdi = KullaniciAdi;
                kullanici.Sifre = Sifre;
                sonuc = DLL.KullaniciKontrol(kullanici);
            }
            else
            {
                sonuc = -100; // eksik parametre hatasi
            }
            return sonuc;
        }

        public int YeniKayit(Guid id, string isim, string soyisim, string Telefon1, string Telefon2, 
            string Telefon3, string Adres, string Email, string Website, string Aciklama)
        {
            int sonuc = 0;
            if (id != Guid.Empty && !string.IsNullOrEmpty(isim) && !string.IsNullOrEmpty(soyisim) && !string.IsNullOrEmpty(Telefon1))
            {
                RehberKayit kayit = new RehberKayit();
                kayit.id = id;
                kayit.isim = isim;
                kayit.soyisim = soyisim;
                kayit.Telefon1 = Telefon1;
                kayit.Telefon2 = Telefon2;
                kayit.Telefon3 = Telefon3;
                kayit.Adres = Adres;
                kayit.Email = Email;
                kayit.Website = Website;
                kayit.Aciklama = Aciklama;

                sonuc = DLL.YeniKayit(kayit);
            }
            else
            {
                sonuc = -100; // Eksik parametre hatasi
            }
            return sonuc;
        }

        public int KayitGuncelle(Guid id, string isim, string soyisim, string Telefon1, string Telefon2,
            string Telefon3, string Adres, string Email, string Website, string Aciklama)
        {
            int sonuc = 0;
            if (id != Guid.Empty && !string.IsNullOrEmpty(isim) && !string.IsNullOrEmpty(soyisim) && !string.IsNullOrEmpty(Telefon1))
            {
                RehberKayit kayit = new RehberKayit();
                kayit.id = id;
                kayit.isim = isim;
                kayit.soyisim = soyisim;
                kayit.Telefon1 = Telefon1;
                kayit.Telefon2 = Telefon2;
                kayit.Telefon3 = Telefon3;
                kayit.Adres = Adres;
                kayit.Email = Email;
                kayit.Website = Website;
                kayit.Aciklama = Aciklama;

                sonuc = DLL.KayitGuncelle(kayit);
            }
            else
            {
                sonuc = -100;
            }

            return sonuc;
        }

        public int KayitSil(Guid id)
        {
            return DLL.KayitSil(id);
        }

        public List<RehberKayit> RehberKayitlariGetir()
        {
            return DLL.RehberKayitlariGetir();
        }

        public int XMLDataVer()
        {
            int sonuc = 0;
            try
            {
                List<RehberKayit> Kayitlarim = DLL.RehberKayitlariGetir();
                XDocument Doc = new XDocument(new XDeclaration("1.0.0.1", "UTF-8", "yes"),
                    new XElement("RehberKayitlar", Kayitlarim.Select(I=> 
                        new XElement("Kayit",
                            new XElement("ID", I.id), 
                            new XElement("isim", I.isim),
                            new XElement("soyisim", I.soyisim),
                            new XElement("Telefon1", I.Telefon1),
                            new XElement("Telefon2", I.Telefon2),
                            new XElement("Telefon3", I.Telefon3),
                            new XElement("Email", I.Email),
                            new XElement("Website", I.Website),
                            new XElement("Adres", I.Adres),
                            new XElement("Aciklama", I.Aciklama)
                            )
                        )
                    )
                );
                Doc.Save(@"C:\Users\Talha\Desktop\C#\23.TelefonRehberiUygulamasi\Udemy\Database\TelefonRehberVer.xml");
                sonuc = 1;
            }
            catch
            {
                sonuc = 0;
            }
            return sonuc;
        }
        public int CSVDataVer()
        {
            int sonuc = 0;
            try
            {
                List<RehberKayit> Kayitlarim = DLL.RehberKayitlariGetir();
                StreamWriter SW = new StreamWriter(@"C:\Users\Talha\Desktop\C#\23.TelefonRehberiUygulamasi\Udemy\Database\TelefonRehberVer.csv");
                CsvHelper.CsvWriter write = new CsvHelper.CsvWriter(SW);
                write.WriteHeader(typeof(RehberKayit));
                foreach (RehberKayit Kayit in Kayitlarim)
                {
                    write.WriteRecord(Kayit);
                }
                SW.Close();
                sonuc = 1;
            }
            catch
            {
                sonuc = 0;
            }
            return sonuc;
        }

        public int JsonDataVer()
        {
            int sonuc = 0;
            try
            {
                List<RehberKayit> Kayitlarim = DLL.RehberKayitlariGetir();
                string jsontext = Newtonsoft.Json.JsonConvert.SerializeObject(Kayitlarim);
                File.WriteAllText(@"C:\Users\Talha\Desktop\C#\23.TelefonRehberiUygulamasi\Udemy\Database\TelefonRehberVer.json", jsontext);

                sonuc = 1;
            }
            catch
            {
                sonuc = 0;
            }
            return sonuc;
        }
    }
}
