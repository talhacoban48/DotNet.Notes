using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inharitance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            temel_tip t1 = new temel_tip();
            t1.temeltiptest1();

            ogrenci o1 = new ogrenci();
            egitmen e1 = new egitmen();
            personel p1 = new personel();

            e1.temeltiptest1();

            // özel tiplerde boxing ve unboxing
            // bizim objemiz nedir ---> "temel_tip" bizim objemizdir
            temel_tip t2;
            // hangi nesnelerde temel tip obje görevi görür ----> "personel, ogrenci, egitmen"
            // personel, egitmen ve ogrenci temel tip nesnesinden türedikleri için, temel tip nesnesi bu nesnelerde object gibi davranır
            t2 = e1; // egitmen nesnesini temel tip nesnesine atadık    //
            t2 = p1;                                                    // boxing işlemleri
            t2 = o1;                                                    //
            e1 = (egitmen)t2;                       // 
            p1 = (personel)t2;                      // unboxing
            o1 = (ogrenci)t2;                       //

            object ob1 = e1;     //boxing
            e1 = (egitmen)ob1;   //unboxing


            //test test1 = new test();
            // hangi nesnemizin kaltılmasın istemiyoruz ---> sealed

            // object > temel_tip > personel > egitmen

            // protected erişim belirleyicisi:
            // normal şartlarda private davranır ancak kalıtım yapılırsa miras alan class içerisinde kullanılabilir yapar
            temel_tip t5 = new temel_tip();
            //t5.temeltiptest2();
        }
    }
}
