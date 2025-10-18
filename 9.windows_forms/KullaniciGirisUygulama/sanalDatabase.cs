using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S19.D2.KullaniciGirisUygulama
{
    public class sanalDatabase
    {
        public static List<kullanici> KullaniciTablo = new List<kullanici>();

        static sanalDatabase()
        {
            KullaniciTablo.Add(new kullanici()
            {
                id = 1,
                isim = "Cengiz",
                soyisim = "Atilla",
                kullaniciAdi = "cengiz.atilla",
                sifre = "1",
                aciklama = "Cengiz Atilla Kullanıcı profil bilgisi"
            });

            KullaniciTablo.Add(new kullanici()
            {
                id = 2,
                isim = "Hamza",
                soyisim = "Atilla",
                kullaniciAdi = "hamza.atilla",
                sifre = "2",
                aciklama = "hamza Atilla Kullanıcı profil bilgisi"
            });
        }
    }
}
