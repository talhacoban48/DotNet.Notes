using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inharitance
{
    public class personel : temel_tip
    {
        public DateTime is_baslangic_tarihi { get; set; }
        public DateTime is_bitis_tarihi { get; set; }
        public int izin_gun_sayisi { get; set; }

        public personel()
        {
            Console.WriteLine("personel nesnesinin yapici methodu çalıştı");
        }
    }
}
