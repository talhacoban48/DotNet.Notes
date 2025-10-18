using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromosyonTakip.Core.Entites
{
    public class PromosyonUrun
    {
        public int ID { get; set; }
        public string tanim { get; set; }
        public string aciklama { get; set; }
        public DateTime gecerlilikTarihi { get; set; }
        public bool KullanimDurum { get; set; }

    }
}
