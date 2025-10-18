using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsService_inceleme
{
    public class DataAccessLayer
    {
        SqlConnection conn;
        SqlCommand cmd;
        int ReturnValues;

        public DataAccessLayer()
        {
            conn = new SqlConnection(@"Data Source=TALHA\SQLEXPRESS;Initial Catalog=OlayGunlugu;User ID=sa;Password=123456;");
        }

        public int OlayGunluguEkle(string Olay, DateTime olusturmaTarihi)
        {   
            try
            {
                cmd = new SqlCommand("insert into OlayGunlugu (olay, olusturmaTarihi) values (@olay, @olusturmaTarihi)", conn);
                cmd.Parameters.Add("@olay", SqlDbType.NVarChar).Value = Olay;
                cmd.Parameters.Add("@olusturmaTarihi", SqlDbType.DateTime).Value = olusturmaTarihi;
                conn.Open();
                ReturnValues = cmd.ExecuteNonQuery();
            }
            catch
            {
                ReturnValues = 0;
            }
            finally
            {
                conn.Close();
            }
            return ReturnValues;
        }
    }
}
