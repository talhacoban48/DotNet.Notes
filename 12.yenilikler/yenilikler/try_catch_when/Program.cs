using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try_catch_when
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new FormatException("Format Hatası");
            }
            catch (FieldAccessException fex)
            {
                Console.WriteLine(fex.Message);
            }
            catch (FormatException fex) when (fex.Message == "Format Hatası")
            {
                Console.WriteLine(fex.Message);
            }
            catch (FormatException fex)
            {
                Console.WriteLine(fex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
