using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodlar_genel_kullanim
{
    public class ogrenci
    {
        // [erişim yetkisi] <geri dönüş değeri> Method adı (parametreler)
        // {

        // }

        /*
         * Erişim belirleyicileri:
         * Public
         * private
         * protected
         * internal 
         * internal protected
         * 
         */
        private void ogrenciMethod1(string ogrenciAdı, string ogrenciSoyadi)
        {
            Console.WriteLine("Merhaba {0} {1}", ogrenciAdı, ogrenciSoyadi);
        }

        public void ogrenciMethod2()
        {
            ogrenciMethod1("Talha", "ÇOBAN");
        }
    }
}
