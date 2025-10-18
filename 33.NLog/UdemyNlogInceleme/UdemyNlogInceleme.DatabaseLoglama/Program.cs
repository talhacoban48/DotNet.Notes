using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyNlogInceleme.DatabaseLoglama
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int Sayi1 = 0;
                int Sonuc = 10 / Sayi1;
            }
            catch (Exception ex)
            {
                Logger logger = LogManager.GetLogger("databaseLogger");
                logger.Error(ex.Message);
            }
        }
    }
}
