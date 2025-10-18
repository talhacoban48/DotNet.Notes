using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kapsulleme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            musteri m1 = new musteri();

            /*
             * KAPSULLEME
             * Field içerisine değer atanamasın ama değer okunabilsin  
             * Field içerisindeki dgeer okunamason ama değer atanabilsin
             * Field içerisine değer atanabilsin ama değerin ilk 4 hanesi okunabilsin
             * Field içerisine değer atanabilsin okunabilsin ama bu iki işlem bizim belirlediğimiz
             *      bir işlemden geçsin veri daha sonra gösterilsin
             * ...
             */

            // Class
            // Field
            // property
            // get - set

            //m1.emailAdress = "cobantalha19@gmail.com";
            m1.EmailAdress = "cobantalha19@gmail.com";
            Console.WriteLine(m1.EmailAdress);

            // 1. Field içerisine değer atanamasın ama değer okunabilsin  
            Console.WriteLine(m1.Id.ToString());
            //m1.Id = 5561;

            // 2.Field içerisindeki dgeer okunamasın ama değer atanabilsin
            m1.TCkimliknumarasi = "54094433114";
            Console.WriteLine(m1.TCkimliknumarasi);

            //*Field içerisine değer atanabilsin okunabilsin ama bu iki işlem bizim belirlediğimiz
            //bir işlemden geçsin veri daha sonra gösterilsin

            m1.name = "Talha";
            m1.Surname = "ÇOBAN";
            Console.WriteLine(m1.email);
        }
    }
}
