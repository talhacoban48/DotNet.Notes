using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kapsulleme
{
    internal class musteri
    {
        public musteri()
        {
            this.id = IdUret();
        }

        //class fields
        private int id;
        public int Id
        {
            private set
            {
                this.id = value;
            }
            get
            {
                return this.id;
            }
        }
        public string email;
        public string name;
        private string surname;
        public string Surname
        {
            get { return this.surname; }
            set
            {
                this.surname = value;
                this.email = string.Format("{0}.{1}@hotmail.com", this.name, this.surname);
            }
        }

        //class fields

        private string emailAdress;
        // class -> property
        public string EmailAdress
        {
            //get; // database veya farklı bir veri kaynagı (classı çağıran programcıya datayı gösterdiğimiz kısım)
            //set; // dış dümyadan alınan verinin field içerisinde private olarak değer atandıpı kısımdır
            set
            {
                this.emailAdress = value;
            }
            get
            {
                return this.emailAdress;
            }
        }

        private string tckimliknumarasi;
        public string TCkimliknumarasi
        {
            get
            {
                return this.tckimliknumarasi.Substring(0,3);
            }
            set
            {
                if (value.Length == 11)
                {
                    bool bayrak = false;
                    for (int i = 0; i < value.Length; i++)
                    {
                        bool charkontrol = char.IsNumber(value[i]);
                        if (charkontrol)
                        {
                            continue;
                        }
                        else
                        {
                            bayrak = true;
                            break;
                        }
                    }
                    if (bayrak)
                    {
                        Console.WriteLine("Sayı değeri girmelisiniz");
                    }
                    else
                    {
                        this.tckimliknumarasi = value;
                    }
                }
                else
                {
                    Console.WriteLine("TC kimlik no 11 haneli olmalıdır");
                }
            }
        }
        private int IdUret()
        {
            Random Rnd = new Random();
            return Rnd.Next(10000,90000);
        }
    }
}
