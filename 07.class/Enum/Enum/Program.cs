using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    public class Program
    {
        static void Main(string[] args)
        {
            musteri m1 = new musteri();
            m1.id = 1;
            m1.isim = "Talha";
            m1.soyisim = "ÇOBAN";
            m1.emailAdres = "coban@gmail.com";
            m1.musteriNumara = "530959348";

            sanalDatabase sanalDB = new sanalDatabase();
            musteriReturnValue sonuc = sanalDB.musteriYenikayit(m1);
            if (sonuc == musteriReturnValue.kayitbasarili)
            {
                Console.WriteLine("kayit başarılı");
            }
            Console.WriteLine((int)musteriReturnValue.kayitbasarili);
            Console.ReadLine();
        }
    }
}
