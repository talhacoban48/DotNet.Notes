using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromosyonTakip.Core.Database
{
    public class PromosyonSepeti
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader reader;
        int returnInt;
        object ReturnObj;
        public PromosyonSepeti()
        {
            conn = new SqlConnection(ConnectionStringOlustur());

        }

        private string ConnectionStringOlustur()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "TALHA\\SQLEXPRESS";
            builder.InitialCatalog = "PromosyonSepeti";
            builder.UserID = "sa";
            builder.Password = "123456";
            return builder.ConnectionString;
        }

        public void BaglantiDurumuAyarla(bool deger)
        {
            if (deger)
            {
                conn.Open();
            }
            else
            {
                conn.Close();
            }
        }

        public int EkleDuzenleSil(SqlCommand cmd)
        {
            cmd.Connection = conn;
            BaglantiDurumuAyarla(true);
            returnInt = cmd.ExecuteNonQuery();
            BaglantiDurumuAyarla(false);
            return returnInt;
        }

        public SqlDataReader Liste(SqlCommand cmd)
        {
            cmd.Connection = conn;
            BaglantiDurumuAyarla(true);
            return cmd.ExecuteReader();
        }

        public object kolonGetir(SqlCommand cmd)
        {
            cmd.Connection = conn;
            BaglantiDurumuAyarla(true);
            ReturnObj = cmd.ExecuteScalar();
            BaglantiDurumuAyarla(false);
            return ReturnObj;
        }
    }
}
