using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using xml_olusturma_2;

namespace xml_okuma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ogrenci> ogrenciler = new List<ogrenci>();
            XDocument Doc = XDocument.Load(@"C:\xml\linq_to_xml_3.xml");

            List<XElement> okunanXElementler = Doc.Descendants("ogrenciler").ToList();
            List<XElement> okunanogrenciler = okunanXElementler.Descendants("Ogrenci").ToList();
            for (int i = 0; i < okunanogrenciler.Count; i++)
            {
                ogrenci temp = new ogrenci();
                temp.isim = okunanogrenciler[i].Element("isim").Value.ToString();
                temp.soyisim = okunanogrenciler[i].Element("soyisim").Value.ToString();
                temp.numara = int.Parse(okunanogrenciler[i].Element("numara").Value);
                temp.ID = Guid.Parse(okunanogrenciler[i].Attribute("ID").Value);

                ogrenciler.Add(temp);
            }
        }
    }
}
