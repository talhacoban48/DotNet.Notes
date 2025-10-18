using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromosyonTakip.Core.Entites
{
    public class PotansiyelMusteri
    {
        public int ID { get; set; }
        public string tckimlik { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public DateTime dogumtarih { get; set; }
        public int cinsiyet { get; set; }
        public string meslek { get; set; }
        public string Email { get; set; }
        public bool EmailBildirimOnay { get; set; }
        public string Telefon { get; set; }
        public bool TelefonBildirimOnay { get; set; }
        public DateTime OlusturmaTarihi { get; set; }
        public int OlusturanMagaza { get; set; }

    }
}