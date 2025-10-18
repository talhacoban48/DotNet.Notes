using PromosyonTakip.Core.Entites;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromosyonTakip.Core.BusinessLogicService
{
    public class KatilimciPromosyonServis : BaseServis<KatilimciPromosyon>
    {
        Database.PromosyonSepeti db;
        public KatilimciPromosyonServis()
        {
            db = new Database.PromosyonSepeti();
        }

        public int KayitYeni(KatilimciPromosyon data)
        {
            cmd = new SqlCommand("insert into KatilimciPromosyon values (@PotansiyelMusteriID, @PromosyonUrunID, @OlusturmaTarihi, @MagazaID)");
            cmd.Parameters.Add("@PotansiyelMusteriID", SqlDbType.Int).Value = data.PotansiyelMusteriID;
            cmd.Parameters.Add("@PromosyonUrunID", SqlDbType.Int).Value = data.PromosyonUrunID;
            cmd.Parameters.Add("@OlusturmaTarihi", SqlDbType.DateTime).Value = data.OlusturmaTarihi;
            cmd.Parameters.Add("@MagazaID", SqlDbType.Int).Value = data.MagazaID;
            return db.EkleDuzenleSil(cmd);
        }
    }
}
