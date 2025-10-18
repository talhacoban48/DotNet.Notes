using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    public class sanalDatabase
    {
        ArrayList sanalDB = new ArrayList();
        public musteriReturnValue musteriYenikayit(musteri m)
        {
            sanalDB.Add(m);
            return musteriReturnValue.kayitbasarili;
        }
    }
}
