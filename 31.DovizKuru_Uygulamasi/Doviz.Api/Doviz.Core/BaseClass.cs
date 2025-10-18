using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Doviz.Core
{
    public class BaseClass
    {
        public void TryCatch(Action action)
        {
            try
            {
                action();
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex);
                // loglama işlemeri burada yapılacak
            }
        }
    }
}
