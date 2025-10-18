using Doviz.Entities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Doviz.Core
{
    public class BusinessLogicLayer: BaseClass
    {
        DatabaseLogicLayer DLL;

        public BusinessLogicLayer()
        {
            DLL = new DatabaseLogicLayer();
        }

        public List<ParaBirimi> ParaBirimiListesi()
        {
            List<ParaBirimi> ParaBirimleri = new List<ParaBirimi>();
            SqlDataReader reader = DLL.ParaBirimiListesi();
            while (reader.Read())
            {
                ParaBirimleri.Add(new ParaBirimi()
                {
                    ParabirimiID = reader.IsDBNull(0) ? Guid.Empty : reader.GetGuid(0),
                    CurrencyName = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                    Tanim = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                    Uyarilimit = reader.IsDBNull(3) ? 0 : reader.GetDecimal(3)
                });
            }
            reader.Close();
            DLL.BaglantiIslemleri();
            return ParaBirimleri;
        }

        public List<Kur> KurListe()
        {
            List<Kur> KurDegerleri = new List<Kur>();
            SqlDataReader reader = DLL.KurListe();
            while (reader.Read())
            {
                KurDegerleri.Add(new Kur
                {
                    KurID = reader.IsDBNull(0) ? Guid.Empty : reader.GetGuid(0),
                    ParaBirimiID = reader.IsDBNull(1) ? Guid.Empty : reader.GetGuid(1),
                    ForexBuying = reader.IsDBNull(2) ? 0 : reader.GetDecimal(2),
                    ForexSelling = reader.IsDBNull(3) ? 0: reader.GetDecimal(3),
                    olusturmaTarihi = reader.IsDBNull(4) ? DateTime.Now : reader.GetDateTime(4)
                });
            }
            reader.Close();
            DLL.BaglantiIslemleri();
            return KurDegerleri;
        }

        public Kur KurListe(Guid ParaBirimiID)
        {
            Kur kur = new Kur();
            SqlDataReader reader = DLL.KurListe(ParaBirimiID);
            while (reader.Read())
            {
                kur.KurID = reader.IsDBNull(0) ? Guid.Empty : reader.GetGuid(0);
                kur.ParaBirimiID = reader.IsDBNull(1) ? Guid.Empty : reader.GetGuid(1);
                kur.ForexBuying = reader.IsDBNull(2) ? 0 : reader.GetDecimal(2);
                kur.ForexSelling = reader.IsDBNull(3) ? 0 : reader.GetDecimal(3);
                kur.olusturmaTarihi = reader.IsDBNull(4) ? DateTime.Now : reader.GetDateTime(4);
            }
            reader.Close();
            DLL.BaglantiIslemleri();
            return kur;
        }

        public List<KurGecmisi> KurGecmisiListe()
        {
            List<KurGecmisi> KurGecmisDegerleri = new List<KurGecmisi>();
            SqlDataReader reader = DLL.KurGecmisiListe();
            while (reader.Read())
            {
                KurGecmisDegerleri.Add(new KurGecmisi
                {
                    KurGecmisiID = reader.IsDBNull(0) ? Guid.Empty : reader.GetGuid(0),
                    KurID = reader.IsDBNull(1) ? Guid.Empty : reader.GetGuid(1),
                    ParaBirimiID = reader.IsDBNull(2) ? Guid.Empty : reader.GetGuid(2),
                    ForexBuying = reader.IsDBNull(3) ? 0 : reader.GetDecimal(3),
                    ForexSelling = reader.IsDBNull(4) ? 0 : reader.GetDecimal(4),
                    olusturmaTarihi = reader.IsDBNull(5) ? DateTime.Now : reader.GetDateTime(5)
                });
            }
            reader.Close();
            DLL.BaglantiIslemleri();
            return KurGecmisDegerleri;
        }

        public List<KurGecmisi> KurGecmisiListe(Guid ParaBirimiID)
        {
            List<KurGecmisi> KurGecmisDegerleri = new List<KurGecmisi>();
            SqlDataReader reader = DLL.KurGecmisiListe(ParaBirimiID);
            while (reader.Read())
            {
                KurGecmisDegerleri.Add(new KurGecmisi
                {
                    KurGecmisiID = reader.IsDBNull(0) ? Guid.Empty : reader.GetGuid(0),
                    KurID = reader.IsDBNull(1) ? Guid.Empty : reader.GetGuid(1),
                    ParaBirimiID = reader.IsDBNull(2) ? Guid.Empty : reader.GetGuid(2),
                    ForexBuying = reader.IsDBNull(3) ? 0 : reader.GetDecimal(3),
                    ForexSelling = reader.IsDBNull(4) ? 0 : reader.GetDecimal(4),
                    olusturmaTarihi = reader.IsDBNull(5) ? DateTime.Now : reader.GetDateTime(5)
                });
            }
            reader.Close();
            DLL.BaglantiIslemleri();
            return KurGecmisDegerleri;
        }

        public void KurKayitEkle(Guid KurID, Guid ParaBirimiID, decimal Buying, decimal selling, DateTime Tarih)
        {
            if (KurID != Guid.Empty && ParaBirimiID != Guid.Empty && Tarih > DateTime.MinValue)
            {
                DLL.KurKayitEkle(new Kur()
                {
                    KurID = KurID,
                    ParaBirimiID= ParaBirimiID,
                    ForexBuying= Buying,
                    ForexSelling = selling,
                    olusturmaTarihi = Tarih
                });
            }
            else
            {

            }
        }

        public void KurBilgileriniGuncelle()
        {
            TryCatch(() =>
            {
                Encoding enTr = Encoding.GetEncoding("windows-1254");
                WebClient client = new WebClient();
                string response = client.DownloadString("http://hasanadiguzel.com.tr/api/kurgetir");

                JObject jsonData = JObject.Parse(response);
                JToken data = jsonData.SelectToken("TCMB_AnlikKurBilgileri");

                List<JsonDataType> DovizKurBilgileri = JsonConvert.DeserializeObject<List<JsonDataType>>(data.ToString());

                List<ParaBirimi> ParaBirimiListe = ParaBirimiListesi();
                for (int i = 0; i < ParaBirimiListe.Count; i++)
                {
                    string eleman = ParaBirimiListe[i].CurrencyName.ToString();
                    JsonDataType BulunanKur = DovizKurBilgileri.FirstOrDefault(I => I.CurrencyName == ParaBirimiListe[i].CurrencyName);
                    KurKayitEkle(Guid.NewGuid(), ParaBirimiListe[i].ParabirimiID, BulunanKur._ForexBuying, BulunanKur._ForexSelling, DateTime.Now);
                }
            });
        }

        public DataTable KurGecmisGorontule()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Döviz Cinsi", typeof(string));
            dataTable.Columns.Add("Alış Değeri", typeof(string));
            dataTable.Columns.Add("Satış Değeri", typeof(string));
            dataTable.Columns.Add("Oluşturma Tarihi", typeof(string));

            List<KurGecmisi> kurgecmisliste = KurGecmisiListe();
            List<ParaBirimi> parabirimliste = ParaBirimiListesi();
            for (int i = 0; i < kurgecmisliste.Count; i++)
            {
                dataTable.Rows.Add(
                    parabirimliste.FirstOrDefault(I => I.ParabirimiID == kurgecmisliste[i].ParaBirimiID).CurrencyName,
                    kurgecmisliste[i].ForexBuying.ToString(),
                    kurgecmisliste[i].ForexSelling.ToString(),
                    kurgecmisliste[i].olusturmaTarihi.ToString("dd.MM.yyyy hh:mm")
                    );
            }

            return dataTable;
        }
    }
}
