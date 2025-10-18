using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic_class
{
    public class musterigeneric<T>
    {
        public T id { get; set; }
        public T numarasi { get; set; }
        public string TCNumarasi { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public DateTime dogumyili { get; set; }

        public T musteriNumarasiAl()
        {
            return this.numarasi;
        }
    }
}
