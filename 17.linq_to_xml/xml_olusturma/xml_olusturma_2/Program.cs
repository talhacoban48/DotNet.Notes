using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace xml_olusturma_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ogrenci> ogrenciler = new List<ogrenci>();

            for (int i = 0; i < 100; i++)
            {
                ogrenci temp = new ogrenci();
                temp.ID = Guid.NewGuid();
                temp.isim = FakeData.NameData.GetFirstName();
                temp.soyisim = FakeData.NameData.GetSurname();
                temp.numara = FakeData.NumberData.GetNumber(100, 500);

                ogrenciler.Add(temp);
            }

            XDocument Doc = new XDocument(
                new XDeclaration("1.0", "UTF-8", "yes"),
                new XElement("ogrenciler", ogrenciler.Select(i=>
                    new XElement("Ogrenci", 
                    new XAttribute("ID", i.ID.ToString()),
                        new XElement("isim", i.isim),
                        new XElement("soyisim", i.soyisim),
                        new XElement("numara", i.numara.ToString())
                        ))
                    )
                );
            Doc.Save(@"C:\xml\linq_to_xml_3.xml");

        }
    }
}
