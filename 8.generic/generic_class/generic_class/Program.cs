using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic_class
{
    public class Program
    {
        static void Main(string[] args)
        {
            musteri m1 = new musteri();
            m1.isim = "Talha";
            m1.soyisim = "ÇOBAN";
            m1.TCNumarasi = "54094433114";
            m1.id = 1;
            m1.numarasi = "5309596348";
            m1.dogumyili = DateTime.Parse("30.07.1998");

            musterigeneric<int> musterigeneric1 = new musterigeneric<int>();
            musterigeneric1.id = 1;

            musterigeneric<string> musterigeneric2 = new musterigeneric<string>();
            musterigeneric2.id = "2";
            musterigeneric2.numarasi = "5309596348";

            string numara = musterigeneric2.musteriNumarasiAl();
        }
    }
}
