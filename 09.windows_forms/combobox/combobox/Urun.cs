using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace combobox
{
    public class Urun
    {
        public Guid id { get; set; }
        public string urunAdi { get; set; }
        public string urunKategori { get; set; }
        public string stokAdeti { get; set; }
        public string yazar { get; set; }
        public string aciklama { get; set; }
        public string KitapResim { get; set; }

        public override string ToString()
        {
            return urunAdi;
        }

    }
}
