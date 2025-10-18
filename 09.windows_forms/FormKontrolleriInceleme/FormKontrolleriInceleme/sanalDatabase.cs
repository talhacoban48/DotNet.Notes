using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormKontrolleriInceleme
{
    public class sanalDatabase
    {
        public static List<Customer> customers = new List<Customer>();
        static sanalDatabase()
        {
            customers.Add(new Customer
            {
                id = Guid.NewGuid(),
                isim = "Talha",
                soyisim = "ÇOBAN",
                email = "cobantalha19@gmail.com",
                Telefon = "5309596348"
            });
            customers.Add(new Customer
            {
                id = Guid.NewGuid(),
                isim = "Sude",
                soyisim = "Karaca ÇOBAN",
                email = "karacasude24@gmail.com",
                Telefon = "5303914843"
            });
        }
    }
}
