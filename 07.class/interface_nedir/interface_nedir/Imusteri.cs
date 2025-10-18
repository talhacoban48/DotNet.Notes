using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_nedir
{
    public interface Imusteri
    {
        //public Imusteri()
        //{

        //}
        //interface içinde yapıcı method kullanılamaz

        // field
        int musteri_id { get; set; }
        string isim { get; set; }
        string soyisim { get; set; }

        // method
        int yenikayit(string _isim, string _soyisim);
        int kayitduzenle(string _isim, string _soyisim);
        int kayitsil(string _isim, string _soyisim);    

    }
}
