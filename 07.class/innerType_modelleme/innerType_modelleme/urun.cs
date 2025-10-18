using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace innerType_modelleme
{
    public class urun
    {
        public int urun_id { get; set; }
        public string tanim { get; set; }
        public decimal fiyat { get; set; }

        public urun()
        {
            Console.WriteLine("ürün yapıcı method çalıştı");
        }

        public void uruntest()
        {
            Console.WriteLine("ürün classı içindeki method çalştı");
        }
    }
}
