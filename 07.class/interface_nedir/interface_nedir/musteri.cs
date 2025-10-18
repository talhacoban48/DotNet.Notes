using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_nedir
{
    public class musteri : Imusteri
    {
        int _id;
        string _isim;
        string _soyisim;
        public int musteri_id 
        { 
            get { return _id; }
            set { this._id = value; }
        }
        public string isim
        {
            get { return _isim; }
            set { this._isim = value; }
        }
        public string soyisim
        {
            get { return _soyisim; }
            set { this._soyisim = value; }
        }

        public int kayitduzenle(string _isim, string _soyisim)
        {
            Console.WriteLine("kayit düzenlendi");
            return 1;
        }

        public int kayitsil(string _isim, string _soyisim)
        {
            Console.WriteLine("kayit düzenlendi");
            return 1;
        }

        public int yenikayit(string _isim, string _soyisim)
        {
            Console.WriteLine("kayit düzenlendi");
            return 1;
        }
    }
}
