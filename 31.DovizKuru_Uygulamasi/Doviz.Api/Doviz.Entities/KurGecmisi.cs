using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doviz.Entities
{
    public class KurGecmisi
    {
        public Guid KurGecmisiID { get; set; }
        public Guid KurID { get; set; }
        public Guid ParaBirimiID { get; set; }
        public decimal ForexBuying { get; set; }
        public decimal ForexSelling { get; set; }
        public DateTime olusturmaTarihi { get; set; }
    }
}
