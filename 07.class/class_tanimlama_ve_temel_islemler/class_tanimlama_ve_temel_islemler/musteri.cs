using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_tanimlama_ve_temel_islemler
{
    internal class musteri
    {
        /*
         * TC numarası
         * adi
         * soyadi
         * cinsiyet
         */

        public musteri()
        {
            TCNumarasi = "1234456777";
        }

        public musteri(string _isim)
        {
            isim = _isim;
        }   
        public musteri(string _isim, string _soyisim)
        {
            isim= _isim;
            soyisim= _soyisim;
        }

        public string isim;
        public string soyisim;
        public string TCNumarasi;
        public int Cinsiyet;
    }
}
