using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partial_class
{
    public partial class ogrenci
    {
        public int yenikayit(ogrenci o)
        {
            Console.WriteLine("yeni kayit tamamlandı");
            return 1;
        }
        public int kayitguncelle(ogrenci o)
        {
            Console.WriteLine("kayit güncellendi");
            return -1;
        }
        public int kayitsil(ogrenci o)
        {
            Console.WriteLine("kayit silindi");
            return 0;
        }
    }
}
