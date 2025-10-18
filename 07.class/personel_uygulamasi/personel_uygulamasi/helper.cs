using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personel_uygulamasi
{
    public static class helper
    {
        
        // static olan bir class içerisine static olmayan field method vs. hiç bir şey yazılamaz

        /*
         * public helper()
         * {
         *  class her örneklendiğinde static olmayan bir class ise, yapıcı method her örneklemede çalışır
         * }
         */

        static helper()
        {
            // uygulama içerisinde istenildiği kadar çaırılsınlar, sadece bir lkere çalışır (ilk çağırılmada)
            Console.WriteLine("burası sadece bir kere çalışır");
        }

        public static void emailGonder(string aliciEmailAdress, string konu, string mesaj)
        {
            Console.WriteLine("Gönderim başarılı.");
        }

    }
}
