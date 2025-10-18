using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_tanimlama_ve_temel_islemler
{
    internal class arac
    {
        public string marka;
        public string model;
        public int model_yil = 0;
        public decimal km = 0;
        public int yakit_tipi;
        public int vites_tipi;
        public decimal alıs_fiyat = 0M;
        public decimal satıs_fiyat = 0M;
        public decimal max_indirim_fiyat = 0;
        public decimal fiyat = 0M;

        public arac()
        {

        }

        public arac(string _marka, string _model)
        {
            marka = _marka;
            model = _model;
        }

        public arac(string _marka, string _model, int _model_yil)
        {
            marka = _marka;
            model = _model;
            model_yil = _model_yil;
        }
        public arac(string _marka, string _model, int _model_yil, decimal _km)
        {
            marka = _marka;
            model = _model;
            model_yil = _model_yil;
            km = _km;
        }

        internal void BilgileriGoruntule()
        {
            Console.WriteLine("***** Araç Bilgileri *****");
            Console.WriteLine("Marka, model, yıl : {0} {1} {2}", marka, model, model_yil);
        }
    }
}
