using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace xmlRead
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XmlReader XmlRead = XmlReader.Create(@"C:\xml\Personellerim.xml");
            while (XmlRead.Read())
            {
                Console.WriteLine($"{XmlRead.Name.ToString()} - {XmlRead.Value.ToString()}");
            }
            Console.ReadLine();
        }
    }
}
