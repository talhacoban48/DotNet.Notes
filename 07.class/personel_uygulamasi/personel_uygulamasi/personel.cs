using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personel_uygulamasi
{
    internal class personel
    {
        public static string domainAdress;
        public string isim { get ; set; }
        public string soyisim { get; set; }
        private string emailAdress;
        public string EmailAdress
        {
            get
            {
                return emailAdress;
            }
            set
            {
                this.emailAdress = value.ToLower() + "@" + personel.domainAdress;
            }
        }
        public int cinsiyet { get; set; }

        public personel()
        {
            Console.WriteLine("her örneklemede çalışan personel klasının yapıcı methodu");
        }

        static personel()
        {
            domainAdress = "benimsirketim.com";
        }
    }
}
