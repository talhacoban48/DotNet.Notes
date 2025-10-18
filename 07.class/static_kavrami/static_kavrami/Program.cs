using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_kavrami
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // static : Nesne örnegi almadan ulaşabildiğimiz metot, field, class dır. 
            // static ile oluşturulan classın örneği alınamaz

            ogrenci o1; // bu aşamada stack bölgede pointer imiz oluştu
            /*
             * stack bölgede pointer oluştuğu zaman static olan bir yapıcı method çalıştı ve yine class içerisinde tanımlı olan
             * static methodlar, static fieldlar static dediğimiz bçlgede oluşturuldu
             */

            o1 = new ogrenci(); // stack bölgedeki pointer kendisini heap bölgede static olmayan tanımları tamamladı
            o1.Test1(); // ogrenci classını tanımladıktan sonra static olmayan methoda ulaşabildim

            ogrenci.Test2(); // ogrenci classını örneklemeden önce de bu methoda ulaşbildim
            
        }
    }
}
