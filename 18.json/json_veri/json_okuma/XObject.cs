using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace json_okuma
{
    public class XObject
    {
        public Guid ID { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string Email { get; set; }
        public string TelefonNumarasi { get; set; }
        public string Sehir { get; set; }

        public override string ToString()
        {
            return isim + " " + soyisim;
        }
    }
}
