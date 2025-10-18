using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doviz.Entities
{
    public class ParaBirimi
    {
        public Guid ParabirimiID { get; set; }
        public string CurrencyName { get; set; }
        public string Tanim { get; set; }
        public decimal Uyarilimit { get; set; }
    }
}
