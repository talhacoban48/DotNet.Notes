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
    public class PotansiyelMusteriServis : BaseServis<PotansiyelMusteri>
    {
        Database.PromosyonSepeti db;
        public PotansiyelMusteriServis()
        {
            db = new Database.PromosyonSepeti();
        }

        public int KayitYeni(PotansiyelMusteri data)
        {
            cmd = new SqlCommand("insert into PotansiyelMusteri values (@tckimlik, @isim, @soyisim, @dogumtarih, @cinsiyet, @meslek, @Email, @EmailBildirimOnay, @Telefon, @TelefonBildirimOnay, @OlusturmaTarihi, @OlusturanMagaza)");
            cmd.Parameters.Add("@tckimlik", SqlDbType.NVarChar).Value = data.tckimlik;
            cmd.Parameters.Add("@isim", SqlDbType.NVarChar).Value = data.isim;
            cmd.Parameters.Add("@soyisim", SqlDbType.NVarChar).Value = data.soyisim;
            cmd.Parameters.Add("@dogumtarih", SqlDbType.DateTime).Value = data.dogumtarih;
            cmd.Parameters.Add("@cinsiyet", SqlDbType.Int).Value = data.cinsiyet;
            cmd.Parameters.Add("@meslek", SqlDbType.NVarChar).Value = data.meslek;
            cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = data.Email;
            cmd.Parameters.Add("@EmailBildirimOnay", SqlDbType.Bit).Value = data.EmailBildirimOnay;
            cmd.Parameters.Add("@Telefon", SqlDbType.NVarChar).Value = data.Telefon;
            cmd.Parameters.Add("@TelefonBildirimOnay", SqlDbType.Bit).Value = data.TelefonBildirimOnay;
            cmd.Parameters.Add("@OlusturmaTarihi", SqlDbType.DateTime).Value = data.OlusturmaTarihi;
            cmd.Parameters.Add("@OlusturanMagaza", SqlDbType.Int).Value = data.OlusturanMagaza;
            sonuc = db.EkleDuzenleSil(cmd);
            return sonuc;
        }

        public int TCKayitSorgula(string tckimlikno)
        {
            cmd = new SqlCommand("select id from PotansiyelMusteri where tckimlik = @tckimlikno");
            cmd.Parameters.Add("@tckimlikno", SqlDbType.NVarChar).Value = tckimlikno;
            obj = db.kolonGetir(cmd);
            return obj == null ? 0 : (int)obj;
        }
    }
}
