using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromosyonTakip.Core.Entites
{
    public class KatilimciPromosyon
    {
        public int ID { get; set; }
        public int PotansiyelMusteriID { get; set; }
        public int PromosyonUrunID { get; set; }
        public DateTime OlusturmaTarihi { get; set; }
        public int MagazaID { get; set; }

    }
}
