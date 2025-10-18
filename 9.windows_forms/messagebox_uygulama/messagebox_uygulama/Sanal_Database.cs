using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace messagebox_uygulama
{
    public static class Sanal_Database
    {
        public static List<Custemer> Custemers { get; set;}

        static Sanal_Database()
        {
            Custemers = new List<Custemer>();  
        }
    }
}
