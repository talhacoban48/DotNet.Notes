using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace innerType_modelleme
{
    public class musteri
    {
        #region tekil olarak oluşturulan fieldlar
        public int musteri_id { get; set; }
        public string TCKimlikNo { get; set; }
        public string musteri_name { get; set; }
        public string musteri_surname { get; set; }
        public DateTime olusturma_tarihi { get; set; }
        public int kullanıcı_id { get; set; }
        #endregion

        #region inner type
        public musteri_adress[] musteriAdresleri;
        public musteri_iletisim[] musteriIletisimBilgileri;
        public musteriSiparis[] musteriSiparisleri;
        #endregion

        public musteri()
        {
            musteriAdresleri = new musteri_adress[5];
            musteriIletisimBilgileri = new musteri_iletisim[5]; 
            musteriSiparisleri = new musteriSiparis[5];
        }
    }
}
