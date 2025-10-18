using PromosyonTakip.Core.Entites;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PromosyonTakip.Core.BusinessLogicService
{
    public class PromosyonUrunServis : BaseServis<PromosyonUrun>
    {
        Database.PromosyonSepeti db;
        public PromosyonUrunServis()
        {
            db = new Database.PromosyonSepeti();
        }

        public List<PromosyonUrun> UrunListesiGetir()
        {
            liste = new List<PromosyonUrun>();
            cmd = new SqlCommand("select top 30 * from PromosyonUrun where KullanimDurum = 1 order by NEWID()");
            reader = db.Liste(cmd);
            while (reader.Read())
            {
                liste.Add(new PromosyonUrun()
                {
                    ID = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                    tanim = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                    aciklama = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                    gecerlilikTarihi = reader.IsDBNull(2) ? DateTime.MinValue : reader.GetDateTime(3),
                    KullanimDurum = reader.IsDBNull(4) ? false : reader.GetBoolean(4)
                });
            }
            reader.Close();
            db.BaglantiDurumuAyarla(false);
            return liste;
        }

        public PromosyonUrun UrunGetir(int ID)
        {
            data = new PromosyonUrun();
            cmd = new SqlCommand("select * from PromosyonUrun where ID = @ID");
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
            reader = db.Liste(cmd);
            while (reader.Read())
            {
                data.ID = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                data.tanim = reader.IsDBNull(1) ? string.Empty : reader.GetString(1);
                data.aciklama = reader.IsDBNull(2) ? string.Empty : reader.GetString(2);
                data.gecerlilikTarihi = reader.IsDBNull(2) ? DateTime.MinValue : reader.GetDateTime(3);
                data.KullanimDurum = reader.IsDBNull(4) ? false : reader.GetBoolean(4);
            }
            reader.Close();
            db.BaglantiDurumuAyarla(false);
            return data;
        }

        public int UrunKullanildi(int id)
        {
            cmd = new SqlCommand("update PromosyonUrun set KullanimDurum = @KullanimDurum where ID = @ID");
            cmd.Parameters.Add("id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@KullanimDurum", SqlDbType.Bit).Value = false;
            return db.EkleDuzenleSil(cmd);
        }
    }
}
