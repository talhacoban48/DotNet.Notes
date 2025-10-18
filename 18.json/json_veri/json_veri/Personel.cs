using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace json_veri
{
    public class Personel
    {
        public Guid id { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string Email { get; set; }
        public string TelefonNumarasi { get; set; }
        public string Sehir { get; set; }
    }
}
