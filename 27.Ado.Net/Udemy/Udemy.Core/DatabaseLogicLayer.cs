using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.Entities;
using Newtonsoft;
using System.Linq.Expressions;
using System.Data.SqlClient;
using System.Data;

namespace Udemy.Core
{
    public class DatabaseLogicLayer
    {
        SqlConnection conn;
        SqlCommand cmd;
        int ReturnValues;

        public DatabaseLogicLayer()
        {
            conn = new SqlConnection(@"Data Source=TALHA\SQLEXPRESS;Initial Catalog=TelefonRehberi;User ID=sa;Password=123456;");
        }

        public void BaglantiAyarla()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
            else 
            { 
                conn.Close(); 
            }
        }

        public int KullaniciKontrol(Kullanici K)
        {
            try
            {
                cmd = new SqlCommand("select count(*) from Kullanici where @KullaniciAdi = KullaniciAdi and Sifre = @Sifre", conn);
                cmd.Parameters.Add("@KullaniciAdi", SqlDbType.NVarChar).Value = K.KullaniciAdi;
                cmd.Parameters.Add("@Sifre", SqlDbType.NVarChar).Value = K.Sifre;
                BaglantiAyarla();
                ReturnValues = (int)cmd.ExecuteScalar();
            }
            catch
            {
                ReturnValues = -1;
            }
            finally
            {
                BaglantiAyarla();
            }
            return ReturnValues;
        }

        public int KayitEkle(RehberKayit rehberKayit)
        {
            try
            {
                cmd = new SqlCommand("insert into Rehber (ID, isim, soyisim, TelefonNumarasi1, TelefonNumarasi2, TelefonNumarasi3, Email, WebSite, Adress, Aciklama) " +
                    "values (@ID, @isim, @soyisim, @TelefonNumarasi1, @TelefonNumarasi2, @TelefonNumarasi3, @Email, @WebSite, @Adress, @Aciklama)", conn);
                cmd.Parameters.Add("@ID", SqlDbType.UniqueIdentifier).Value = rehberKayit.id;
                cmd.Parameters.Add("@isim", SqlDbType.NVarChar).Value = rehberKayit.isim;
                cmd.Parameters.Add("@soyisim", SqlDbType.NVarChar).Value = rehberKayit.soyisim;
                cmd.Parameters.Add("@TelefonNumarasi1", SqlDbType.NVarChar).Value = rehberKayit.Telefon1;
                cmd.Parameters.Add("@TelefonNumarasi2", SqlDbType.NVarChar).Value = rehberKayit.Telefon2;
                cmd.Parameters.Add("@TelefonNumarasi3", SqlDbType.NVarChar).Value = rehberKayit.Telefon3;
                cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = rehberKayit.Email;
                cmd.Parameters.Add("@WebSite", SqlDbType.NVarChar).Value = rehberKayit.Website;
                cmd.Parameters.Add("@Adress", SqlDbType.NVarChar).Value = rehberKayit.Adres;
                cmd.Parameters.Add("@Aciklama", SqlDbType.NVarChar).Value = rehberKayit.Aciklama;

                BaglantiAyarla();
                ReturnValues = cmd.ExecuteNonQuery();
            }
            catch
            {
                ReturnValues = -1;
            }
            finally
            {
                BaglantiAyarla();
            }
            return ReturnValues;
        }

        public int KayitGuncelle(RehberKayit rehberKayit)
        {
            try
            {
                cmd = new SqlCommand("update Rehber set " +
                    "isim = @isim," +
                    "soyisim = @soyisim," +
                    "TelefonNumarasi1 = @TelefonNumarasi1," +
                    "TelefonNumarasi2 = @TelefonNumarasi2," +
                    "TelefonNumarasi3 = @TelefonNumarasi3," +
                    "Email = @Email," +
                    "WebSite = @WebSite," +
                    "Adress = @Adress," +
                    "Aciklama = @Aciklama " +
                    "where ID = @ID", conn);
                cmd.Parameters.Add("@ID", SqlDbType.UniqueIdentifier).Value = rehberKayit.id;
                cmd.Parameters.Add("@isim", SqlDbType.NVarChar).Value = rehberKayit.isim;
                cmd.Parameters.Add("@soyisim", SqlDbType.NVarChar).Value = rehberKayit.soyisim;
                cmd.Parameters.Add("@TelefonNumarasi1", SqlDbType.NVarChar).Value = rehberKayit.Telefon1;
                cmd.Parameters.Add("@TelefonNumarasi2", SqlDbType.NVarChar).Value = rehberKayit.Telefon2;
                cmd.Parameters.Add("@TelefonNumarasi3", SqlDbType.NVarChar).Value = rehberKayit.Telefon3;
                cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = rehberKayit.Email;
                cmd.Parameters.Add("@WebSite", SqlDbType.NVarChar).Value = rehberKayit.Website;
                cmd.Parameters.Add("@Adress", SqlDbType.NVarChar).Value = rehberKayit.Adres;
                cmd.Parameters.Add("@Aciklama", SqlDbType.NVarChar).Value = rehberKayit.Aciklama;

                BaglantiAyarla();
                ReturnValues = cmd.ExecuteNonQuery();
            }
            catch
            {
                ReturnValues = -1;
            }
            finally
            {
                BaglantiAyarla();
            }
            return ReturnValues;
        }

        public int KayitSil(Guid id)
        {
            try
            {
                cmd = new SqlCommand("delete Rehber where ID = @ID", conn);
                cmd.Parameters.Add("@ID", SqlDbType.UniqueIdentifier).Value = id;

                BaglantiAyarla();
                ReturnValues = cmd.ExecuteNonQuery();
            }
            catch
            {
                ReturnValues = -1;
            }
            finally
            {
                BaglantiAyarla();
            }
            return ReturnValues;
        }


        public SqlDataReader RehberKayitlariGetir()
        {
            cmd = new SqlCommand("select * from Rehber", conn);
            BaglantiAyarla();
            return cmd.ExecuteReader();
        }

        public SqlDataReader RehberKayitGetir(Guid id)
        {
            cmd = new SqlCommand("select * from Rehber where ID = @ID", conn);
            cmd.Parameters.Add("@ID", SqlDbType.UniqueIdentifier).Value = id;
            BaglantiAyarla();
            return cmd.ExecuteReader();
        }
    }
}
