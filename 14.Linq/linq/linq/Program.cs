using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region başlarken

            DataSource ds = new DataSource();
            List<Musteri> musteriliste = ds.musteriListesi();
            Console.WriteLine(musteriliste);

            int bulunanToplam = 0;
            for (int i = 0; i < musteriliste.Count; i++)
            {
                if (musteriliste[i].isim[0].ToString() == "A")
                {
                    bulunanToplam ++;
                }
            }
            Console.WriteLine(bulunanToplam);

            #endregion

            #region linq sorgulama çeşitleri

            // 1. Yol
            int toplammusteriadet1 = musteriliste.Where(I => I.isim.StartsWith("A")).Count();

            // 2. Yol
            var toplammusteriadet2 = (from I in musteriliste where I.isim.StartsWith("A") select I).Count();

            #endregion

            #region alıştırmalar
            // Müşteriler içinde ülke değeri a ile başlayanları al

            List<Musteri> secilenMusteriler = (from I in musteriliste where I.ulke.StartsWith("A") select I).ToList();
            Console.WriteLine("Müşteriler içinde ülke değeri a ile başlayanları al");
            for (int i = 0;i < secilenMusteriler.Count;i++)
            {
                Console.WriteLine(secilenMusteriler[i].ulke);
            }
            Console.WriteLine("");


            // musteri listesi içinde isimimde v harfi geçen ve ülke değeri içinde a harfi olan musteriler

            List<Musteri> secilenmusteriler2 = musteriliste.Where(i => i.isim.Contains("V") && i.ulke.Contains("A")).ToList();
            Console.WriteLine("musteri listesi içinde isimimde v harfi geçen ve ülke değeri içinde a harfi olan musteriler");
            for (int i = 0; i < secilenmusteriler2.Count; i++)
            {
                Console.WriteLine($"{secilenmusteriler2[i].isim} {secilenmusteriler2[i].ulke}");
            }
            Console.WriteLine("");

            // musterilerden dogum yılı 1998den büyük olan ve isminin içerisindde a harfi olan müşteriler

            List<Musteri> secilenmusteriler3 = (from I in musteriliste where I.dogumtarih.Year > 1998 && I.isim.Contains("A") select I).ToList();
            Console.WriteLine("musterilerden dogum yılı 1998den büyük olan ve isminin içerisindde a harfi olan müşteriler");
            for (int i = 0; i < secilenmusteriler3.Count; i++)
            {
                Console.WriteLine($"{secilenmusteriler3[i].isim} {secilenmusteriler3[i].dogumtarih.ToShortDateString().ToString()}");
            }
            Console.WriteLine("");

            // musterilerden dogum yılı 1998den büyük olan veya isminin içerisindde a harfi olan müşteriler
            
            List<Musteri> secilenmusteriler4 = (from I in musteriliste where I.dogumtarih.Year > 1998 || I.isim.Contains("A") select I).ToList();
            Console.WriteLine("musterilerden dogum yılı 1998den büyük olan ve isminin içerisindde a harfi olan müşteriler");
            for (int i = 0; i < secilenmusteriler4.Count; i++)
            {
                Console.WriteLine($"{secilenmusteriler4[i].isim} {secilenmusteriler4[i].dogumtarih.ToShortDateString().ToString()}");
            }
            Console.WriteLine("");

            #endregion

            #region func delegate kullanımı
            Func<Musteri, bool> funcDelegate1 = new Func<Musteri, bool>(funcDelegateKullanimi1);

            var delegateKullanimi1 = musteriliste.Where(funcDelegate1);
            var delegateKullanimi2 = musteriliste.Where(new Func<Musteri, bool>(funcDelegateKullanimi1));
            var delegateKullanimi3 = musteriliste.Where(delegate (Musteri m) { return m.isim[0].ToString() == "A" ? true : false; });
            var delegateKullanimi4 = musteriliste.Where((Musteri m) => { return m.isim[0].ToString() == "A" ? true : false; });
            var delegateKullanimi5 = musteriliste.Where((m) => { return m.isim[0].ToString() == "A" ? true : false; });
            var delegateKullanimi6 = musteriliste.Where(m => m.isim[0].ToString() == "A");
            #endregion

            #region predicate delegate kullanımı // geriye sadece boolean değer döner

            Predicate<Musteri> predicate = new Predicate<Musteri>(predicateDelegateMetot);
            var DelegateKullanimiPredicate1 = musteriliste.FindAll(predicate);
            var DelegateKullanimiPredicate2 = musteriliste.FindAll(new Predicate<Musteri>(predicateDelegateMetot));
            var DelegateKullanimiPredicate3 = musteriliste.FindAll(delegate (Musteri m) { return m.dogumtarih.Year > 1999; });
            var DelegateKullanimiPredicate4 = musteriliste.FindAll((Musteri m) => { return m.dogumtarih.Year > 1999; });
            var DelegateKullanimiPredicate5 = musteriliste.FindAll((m) => { return m.dogumtarih.Year > 1999; });
            var DelegateKullanimiPredicate6 = musteriliste.FindAll(m => m.dogumtarih.Year > 1999);

            #endregion

            #region action delegateler

            Action<Musteri> actiondelegate = new Action<Musteri>(musteriListele);
            musteriliste.ForEach(actiondelegate);
            musteriliste.ForEach(new Action<Musteri>(musteriListele));
            musteriliste.ForEach(delegate (Musteri m) { Console.WriteLine(m.isim.ToString() + " " + m.soyisim.ToString()); });
            musteriliste.ForEach((Musteri m) => { Console.WriteLine(m.isim.ToString() + " " + m.soyisim.ToString()); });
            musteriliste.ForEach((m) => { Console.WriteLine(m.isim.ToString() + " " + m.soyisim.ToString()); });
            musteriliste.ForEach(m => Console.WriteLine(m.isim.ToString() + " " + m.soyisim.ToString()));
            
            #endregion
        }

        static bool funcDelegateKullanimi1(Musteri m)
        {
            if (m.isim[0].ToString() == "A")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool predicateDelegateMetot(Musteri m)
        {
            if (m.dogumtarih.Year > 1999)
            {
                return true;
            }
            else { return false; }
        }

        static void musteriListele(Musteri m)
        {
            Console.WriteLine(m.isim.ToString() + " " + m.soyisim.ToString());
        }
    }
}
