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
    public class SistemMagazaServis : BaseServis<SistemMagaza>
    {

        Database.PromosyonSepeti db;
        public SistemMagazaServis()
        {
            db = new Database.PromosyonSepeti();
        }

        public int MagazaKullaniciKontrol(string KullaniciAdi, string Sifre)
        {
            cmd = new SqlCommand("select * from SistemMagaza where kullaniciAdi = @KullaniciAdi and sifre = @Sifre");
            cmd.Parameters.Add("@KullaniciAdi", SqlDbType.NVarChar).Value = KullaniciAdi;
            cmd.Parameters.Add("@Sifre", SqlDbType.NVarChar).Value = Sifre;
            obj = db.kolonGetir(cmd);
            return obj == null ? 0 : (int)obj;
        }
    }
}
