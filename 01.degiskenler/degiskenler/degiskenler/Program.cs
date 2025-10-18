using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace degiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // DeğiskenTipi değişkenAdı = deger;
            string isimSoyisim = "Talha ÇOBAN";
            Console.WriteLine(isimSoyisim);
            string nameSurname;
            nameSurname = "Talha ÇOBAN";
            Console.WriteLine(nameSurname);

            string Upper = nameSurname.ToUpper();
            string Lower = nameSurname.ToLower();
            Console.WriteLine(Lower);
            Console.WriteLine(Upper);

            string partof = nameSurname.Substring(6);
            Console.WriteLine(partof);
            string invpartof = nameSurname.Substring(0,6);
            Console.WriteLine(invpartof);

            // Kullanıcı Seçimi : A;
            char kullaiciSecimi = 'A';
            Console.WriteLine(kullaiciSecimi);

            // byte ve integer değişkenler
            byte deger1 = 10;
            Console.WriteLine(deger1);
            int deger2 = 11;
            Console.WriteLine(deger2);
            byte minDeger = byte.MinValue;
            byte maxDeger = byte.MaxValue;
            Console.WriteLine(minDeger);
            Console.WriteLine(maxDeger);
            int minIntDeger = int.MinValue;
            int maxIntDeger = int.MaxValue;
            Console.WriteLine(minIntDeger);
            Console.WriteLine(maxIntDeger);

            //Double, Decimal, Floar Değişkenler
            double doublevalue1 = 10.2;
            double doublevalue2 = 10;
            double doublevalue3 = 10.9d;
            double doubleminvalue = double.MinValue;
            double doublemaxvalue = double.MaxValue;
            Console.WriteLine(doubleminvalue);
            Console.WriteLine(doublemaxvalue);

            decimal decimalvalue1 = 10.1M;

            float floatvalue = 10.2F;

            Console.ReadLine();
            
        }
    }
}
