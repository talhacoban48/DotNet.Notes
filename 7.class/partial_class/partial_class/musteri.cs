using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partial_class
{
    public class musteri
    {
        public int id { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string emaii { get; set; }

        public int yenikayit(musteri m)
        {
            Console.WriteLine("yeni kayit tamamlandı");
            return 1;
        }

        public int kayitguncelle(musteri m)
        {
            Console.WriteLine("kayit güncellendi");
            return -1;
        }
        public int kayitsil(musteri m)
        {
            Console.WriteLine("kayit silindi");
            return 0;
        }
    }
}
