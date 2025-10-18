using PromosyonTakip.Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromosyonTakip.Core.Helper
{
    public static class StaticFieldList
    {
        public static int magazaID { get; set; }

        public static List<Cinsiyet> CinsiyetGetir()
        {
            List<Cinsiyet> cinsiyetliste = new List<Cinsiyet>();
            cinsiyetliste.Add(new Cinsiyet() { id = 1, tanim = "Kadın" });
            cinsiyetliste.Add(new Cinsiyet() { id = 2, tanim = "Erkek" });
            return cinsiyetliste;
        }
    }
}
