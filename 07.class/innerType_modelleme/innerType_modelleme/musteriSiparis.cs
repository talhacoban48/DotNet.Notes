using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace innerType_modelleme
{
    public class musteriSiparis
    {
        public string siparisnumarasi { get; set; }

        public urun[] urunler;

        public musteriSiparis()
        {
            urunler = new urun[4];
        }
    }
}
