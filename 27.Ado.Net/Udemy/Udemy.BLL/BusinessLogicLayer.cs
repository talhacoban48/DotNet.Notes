using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
                sonuc = -1; // eksik parametre hatasi
            }
            return sonuc;
        }

        public int KayitEkle(Guid id, string isim, string soyisim, string Telefon1, string Telefon2, 
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

                sonuc = DLL.KayitEkle(kayit);
            }
            else
            {
                sonuc = -1; // Eksik parametre hatasi
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
                sonuc = -1;
            }

            return sonuc;
        }

        public int KayitSil(Guid id)
        {
            return DLL.KayitSil(id);
        }

        public List<RehberKayit> RehberKayitlariGetir()
        {
            List<RehberKayit> RehberListesi = new List<RehberKayit> ();
            try
            {
                SqlDataReader reader = DLL.RehberKayitlariGetir();
                while (reader.Read())
                {
                    RehberListesi.Add(new RehberKayit()
                    {
                        id = reader.IsDBNull(0) ? Guid.Empty : reader.GetGuid(0),
                        isim = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                        soyisim = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                        Telefon1 = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                        Telefon2 = reader.IsDBNull(4) ? string.Empty : reader.GetString(4),
                        Telefon3 = reader.IsDBNull(5) ? string.Empty : reader.GetString(5),
                        Email = reader.IsDBNull(6) ? string.Empty : reader.GetString(6),
                        Website = reader.IsDBNull(7) ? string.Empty : reader.GetString(7),
                        Adres = reader.IsDBNull(8) ? string.Empty : reader.GetString(8),
                        Aciklama = reader.IsDBNull(9) ? string.Empty : reader.GetString(9)
                    });
                }
                reader.Close();

            }
            catch
            {

            }
            finally
            {
                DLL.BaglantiAyarla();
            }
            return RehberListesi;
        }


        public RehberKayit RehberKayitGetir(Guid id)
        {
            RehberKayit Rehber = new RehberKayit();
            try
            {
                SqlDataReader reader = DLL.RehberKayitGetir(id);
                while (reader.Read())
                {
                    Rehber = new RehberKayit()
                    {
                        id = reader.IsDBNull(0) ? Guid.Empty : reader.GetGuid(0),
                        isim = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                        soyisim = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                        Telefon1 = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                        Telefon2 = reader.IsDBNull(4) ? string.Empty : reader.GetString(4),
                        Telefon3 = reader.IsDBNull(5) ? string.Empty : reader.GetString(5),
                        Email = reader.IsDBNull(6) ? string.Empty : reader.GetString(6),
                        Website = reader.IsDBNull(7) ? string.Empty : reader.GetString(7),
                        Adres = reader.IsDBNull(8) ? string.Empty : reader.GetString(8),
                        Aciklama = reader.IsDBNull(9) ? string.Empty : reader.GetString(9)
                    };
                }
                reader.Close();
            }
            catch
            {

            }
            finally
            {
                DLL.BaglantiAyarla();
            }
            return Rehber;
        }

        public int XMLDataVer()
        {
            int sonuc = 0;
            try
            {
            List<RehberKayit> Kayitlarim = new List<RehberKayit>();

                SqlDataReader reader = DLL.RehberKayitlariGetir();
                while (reader.Read())
                {
                    Kayitlarim.Add(new RehberKayit()
                    {
                        id = reader.IsDBNull(0) ? Guid.Empty : reader.GetGuid(0),
                        isim = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                        soyisim = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                        Telefon1 = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                        Telefon2 = reader.IsDBNull(4) ? string.Empty : reader.GetString(4),
                        Telefon3 = reader.IsDBNull(5) ? string.Empty : reader.GetString(5),
                        Email = reader.IsDBNull(6) ? string.Empty : reader.GetString(6),
                        Website = reader.IsDBNull(7) ? string.Empty : reader.GetString(7),
                        Adres = reader.IsDBNull(8) ? string.Empty : reader.GetString(8),
                        Aciklama = reader.IsDBNull(9) ? string.Empty : reader.GetString(9)
                    });
                }
                reader.Close();


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
                Doc.Save(@"C:\Users\Talha\Desktop\C#\27.Ado.Net\Udemy\Database\TelefonRehberVer.xml");
                sonuc = 1;
            }
            catch
            {
                sonuc = 0;
            }
            finally
            {
                DLL.BaglantiAyarla();
            }
            return sonuc;
        }
        public int CSVDataVer()
        {
            int sonuc = 0;
            try
            {
                List<RehberKayit> Kayitlarim = new List<RehberKayit>();

                SqlDataReader reader = DLL.RehberKayitlariGetir();
                while (reader.Read())
                {
                    Kayitlarim.Add(new RehberKayit()
                    {
                        id = reader.IsDBNull(0) ? Guid.Empty : reader.GetGuid(0),
                        isim = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                        soyisim = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                        Telefon1 = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                        Telefon2 = reader.IsDBNull(4) ? string.Empty : reader.GetString(4),
                        Telefon3 = reader.IsDBNull(5) ? string.Empty : reader.GetString(5),
                        Email = reader.IsDBNull(6) ? string.Empty : reader.GetString(6),
                        Website = reader.IsDBNull(7) ? string.Empty : reader.GetString(7),
                        Adres = reader.IsDBNull(8) ? string.Empty : reader.GetString(8),
                        Aciklama = reader.IsDBNull(9) ? string.Empty : reader.GetString(9)
                    });
                }
                reader.Close();

                StreamWriter SW = new StreamWriter(@"C:\Users\Talha\Desktop\C#\27.Ado.Net\Udemy\Database\TelefonRehberVer.csv");
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
            finally
            {
                DLL.BaglantiAyarla();
            }
            return sonuc;
        }

        public int JsonDataVer()
        {
            int sonuc = 0;
            try
            {
                List<RehberKayit> Kayitlarim = new List<RehberKayit>();

                SqlDataReader reader = DLL.RehberKayitlariGetir();
                while (reader.Read())
                {
                    Kayitlarim.Add(new RehberKayit()
                    {
                        id = reader.IsDBNull(0) ? Guid.Empty : reader.GetGuid(0),
                        isim = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                        soyisim = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                        Telefon1 = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                        Telefon2 = reader.IsDBNull(4) ? string.Empty : reader.GetString(4),
                        Telefon3 = reader.IsDBNull(5) ? string.Empty : reader.GetString(5),
                        Email = reader.IsDBNull(6) ? string.Empty : reader.GetString(6),
                        Website = reader.IsDBNull(7) ? string.Empty : reader.GetString(7),
                        Adres = reader.IsDBNull(8) ? string.Empty : reader.GetString(8),
                        Aciklama = reader.IsDBNull(9) ? string.Empty : reader.GetString(9)
                    });
                }
                reader.Close();
                string jsontext = Newtonsoft.Json.JsonConvert.SerializeObject(Kayitlarim);
                File.WriteAllText(@"C:\Users\Talha\Desktop\C#\27.Ado.Net\Udemy\Database\TelefonRehberVer.json", jsontext);

                sonuc = 1;
            }
            catch
            {
                sonuc = 0;
            }
            finally
            {
                DLL.BaglantiAyarla();
            }
            return sonuc;
        }
    }
}
