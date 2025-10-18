using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace auto_property
{
    internal class araba
    {
        private string plaka;

        public string Plaka
        {
            get
            {
                return this.plaka;
            }
            set
            {
                this.plaka = value;
            }
        }
        public string marka { get; set; }
        public int motorhacmi { private get; set; }
        public int motorgucu { get; private set; }
        public araba()
        {
            
        }
    }
}
