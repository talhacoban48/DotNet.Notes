using Doviz.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doviz.Core
{
    public class DatabaseLogicLayer: BaseClass
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader reader;

        public DatabaseLogicLayer()
        {
            conn = new SqlConnection(@"Data Source=TALHA\SQLEXPRESS;Initial Catalog=Doviz;User ID=sa;Password=123456;");
            
        }

        public void BaglantiIslemleri()
        {
            if(conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
            else { conn.Open(); }
        }

        public SqlDataReader ParaBirimiListesi()
        {
            TryCatch(() =>
            {
                cmd = new SqlCommand("Select * from Parabirimi", conn);
                BaglantiIslemleri();
                reader = cmd.ExecuteReader();
            });
            return reader;
        }
        public SqlDataReader KurListe()
        {
            TryCatch(() =>
            {
                cmd = new SqlCommand("Select * from Kur", conn);
                BaglantiIslemleri();
                reader = cmd.ExecuteReader();
            });
            return reader;
        }

        public SqlDataReader KurListe(Guid ParabirimiID)
        {
            TryCatch(() =>
            {
                cmd = new SqlCommand("Select * from Kur where ParaBirimiID = @ParaBirimiID", conn);
                cmd.Parameters.Add("@ParaBirimiID", SqlDbType.UniqueIdentifier).Value = ParabirimiID;
                BaglantiIslemleri();
                reader = cmd.ExecuteReader();
            });
            return reader;
        }

        public SqlDataReader KurGecmisiListe()
        {
            TryCatch(() =>
            {
                cmd = new SqlCommand("Select * from KurGecmisi", conn);
                BaglantiIslemleri();
                reader = cmd.ExecuteReader();
            });
            return reader;
        }

        public SqlDataReader KurGecmisiListe(Guid ParabirimiID)
        {
            TryCatch(() =>
            {
                cmd = new SqlCommand("Select * from KurGecmisi where ParaBirimiID = @ParaBirimiID", conn);
                cmd.Parameters.Add("@ParaBirimiID", SqlDbType.UniqueIdentifier).Value = ParabirimiID;
                BaglantiIslemleri();
                reader = cmd.ExecuteReader();
            });
            return reader;
        }
        public void KurKayitEkle(Kur kur)
        {
            TryCatch(() =>
            {
                cmd = new SqlCommand("KurkayitEkle", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@KurID", SqlDbType.UniqueIdentifier).Value = kur.KurID;
                cmd.Parameters.Add("@ParaBirimiID", SqlDbType.UniqueIdentifier).Value = kur.ParaBirimiID;
                cmd.Parameters.Add("@ForexBuying", SqlDbType.Decimal).Value = kur.ForexBuying;
                cmd.Parameters.Add("@ForexSelling", SqlDbType.Decimal).Value = kur.ForexSelling;
                cmd.Parameters.Add("@olusturmaTarihi", SqlDbType.DateTime).Value = kur.olusturmaTarihi;
                BaglantiIslemleri();
                cmd.ExecuteNonQuery();
            });
            BaglantiIslemleri();
        }
    }
}
