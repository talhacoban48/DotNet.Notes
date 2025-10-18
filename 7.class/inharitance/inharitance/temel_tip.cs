using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inharitance
{
    public class temel_tip
    {
        public int id { get; set; }
        public int referans_kod { get; set; }
        public string TCKimlikNo { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public int cinsiyet { get; set; }
        public DateTime kayit_tarih { get; set; }
        public int kayit_kullanici { get; set; }
        public DateTime guncelleme_tarih { get; set; }
        public int guncelleme_kullanici { get; set; }
        public bool silindi { get; set; }


        public temel_tip()
        {
            Console.WriteLine("temel tip yapıcı methodu");
            idAt();
        }
        private void idAt()
        {
            Random rand = new Random();
            this.id = rand.Next(1000,2000);
        }

        public void temeltiptest1()
        {
            Console.WriteLine("temel tip method 1");
        }
        protected void temeltiptest2()
        {
            Console.WriteLine("temel tip protected methodu");
        }
    }
}
