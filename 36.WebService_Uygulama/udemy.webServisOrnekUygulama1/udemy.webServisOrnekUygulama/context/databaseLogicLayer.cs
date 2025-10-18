using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using udemy.webServisOrnekUygulama.entities;

namespace udemy.webServisOrnekUygulama.context
{
    public class databaseLogicLayer:IDisposable
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;
        int returnValueInt;
        outputType returnValueOutputType;

        public databaseLogicLayer()
        {
            con = new SqlConnection("data source=.; initial catalog = webServisKullanimi; user id=sa; password = 1");
        }

        public void baglantiIslemleri()
        {
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
            else
                con.Close();
        }

        public outputType urunKayitYeni(urun u)
        {

            cmd = new SqlCommand("insert into urun values (@urunKimlik,@tanim,@aciklama,@stokAdet)", con);
            cmd.Parameters.Add("@urunKimlik", SqlDbType.NVarChar).Value = u.urunKimlik;
            cmd.Parameters.Add("@tanim", SqlDbType.NVarChar).Value = u.tanim;
            cmd.Parameters.Add("@aciklama", SqlDbType.NVarChar).Value = u.aciklama;
            cmd.Parameters.Add("@stokAdet", SqlDbType.Int).Value = u.stokAdet;
            baglantiIslemleri();
            returnValueOutputType = cmd.ExecuteNonQuery() > 0 ? outputType.islemBasarili : outputType.islemBasarisiz;
            baglantiIslemleri();
            return returnValueOutputType;
        }

        public outputType urunKimlikKontrol(string urunKimlik)
        {
            cmd = new SqlCommand("select count(1) from urun where urunKimlik = @urunKimlik", con);
            cmd.Parameters.Add("@urunKimlik", SqlDbType.NVarChar).Value = urunKimlik;
            baglantiIslemleri();
            returnValueOutputType = ((int)cmd.ExecuteScalar()) > 0 ? outputType.kayitliUrun : outputType.yeniUrun;
            baglantiIslemleri();
            return returnValueOutputType;
        }

        public outputType urunKayitDuzenle(urun u)
        {
            cmd = new SqlCommand(@"
update urun 
set
tanim = @tanim,
aciklama = @aciklama,
stokAdet = @stokAdet 
where urunKimlik = @urunKimlik
", con);
            cmd.Parameters.Add("@urunKimlik", SqlDbType.NVarChar).Value = u.urunKimlik;
            cmd.Parameters.Add("@tanim", SqlDbType.NVarChar).Value = u.tanim;
            cmd.Parameters.Add("@aciklama", SqlDbType.NVarChar).Value = u.aciklama;
            cmd.Parameters.Add("@stokAdet", SqlDbType.Int).Value = u.stokAdet;
            baglantiIslemleri();
            returnValueOutputType = cmd.ExecuteNonQuery() > 0 ? outputType.islemBasarili : outputType.islemBasarisiz;
            baglantiIslemleri();
            return returnValueOutputType;
        }

        public outputType urunKayitSil(string urunKimlik)
        {
            cmd = new SqlCommand("delete urun where urunKimlik = @urunKimlik", con);
            cmd.Parameters.Add("@urunKimlik", SqlDbType.NVarChar).Value = urunKimlik;
            baglantiIslemleri();
            returnValueOutputType = cmd.ExecuteNonQuery() > 0 ? outputType.islemBasarili : outputType.islemBasarisiz;
            baglantiIslemleri();
            return returnValueOutputType;
        }

        public List<urun> urunKayitListe()
        {
            List<urun> urunListe = new List<urun>();
            cmd = new SqlCommand("select * from  urun", con);

            baglantiIslemleri();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                urunListe.Add(new urun()
                {
                    id = reader.IsDBNull(0) ? -1 : reader.GetInt32(0),
                    urunKimlik = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                    tanim = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                    aciklama = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                    stokAdet = reader.IsDBNull(4) ? 0 : reader.GetInt32(4),
                });
            }
            reader.Close();
            baglantiIslemleri();
            return urunListe;
        }

        public urun urunKayitListe(string urunKimlik)
        {
            urun bulunanUrun = null;
            cmd = new SqlCommand("select * from  urun where urunKimlik = @urunKimlik", con);
            cmd.Parameters.Add("@urunKimlik", SqlDbType.NVarChar).Value = urunKimlik;
            baglantiIslemleri();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                bulunanUrun = new urun()
                {
                    id = reader.IsDBNull(0) ? -1 : reader.GetInt32(0),
                    urunKimlik = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                    tanim = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                    aciklama = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                    stokAdet = reader.IsDBNull(4) ? 0 : reader.GetInt32(4),
                };
            }
            reader.Close();
            baglantiIslemleri();
            return bulunanUrun;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}