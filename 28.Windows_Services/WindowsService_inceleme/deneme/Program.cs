using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsService_inceleme;

namespace deneme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataAccessLayer DAL = new DataAccessLayer();
            DAL.OlayGunluguEkle("amk olayı", DateTime.Now);
        }
    }
}
