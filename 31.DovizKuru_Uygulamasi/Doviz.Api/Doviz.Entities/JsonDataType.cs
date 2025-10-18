using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Doviz.Entities
{
    public class JsonDataType
    {
        public string Isim { get; set; }
        public string CurrencyName { get; set; }
        public decimal _ForexBuying { get; set; }
        public decimal? ForexBuying
        {
            get { return _ForexBuying; }
            set
            {
                if (value == null)
                {
                    this._ForexBuying = 0;
                }
                else
                {
                    this._ForexBuying = value.Value;
                }
            }
        }
        public decimal _ForexSelling { get; set; }

        public decimal? ForexSelling
        {
            get { return _ForexSelling; }
            set
            {
                if (value == null)
                {
                    this._ForexSelling = 0;
                }
                else
                {
                    this._ForexSelling = value.Value;
                }
            }
        }

    }
}



