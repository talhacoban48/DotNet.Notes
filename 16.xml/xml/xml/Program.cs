using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace xml
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XmlTextWriter XmlText = new XmlTextWriter(@"C:\xml\Personellerim.xml",
                System.Text.UTF8Encoding.UTF8);
            XmlText.WriteComment("Xml işlemlerim");
            XmlText.WriteStartElement("Personellerim");
            XmlText.WriteStartElement("Personel");
            XmlText.WriteAttributeString("ID", "1");
            XmlText.WriteElementString("isim", "Talha");
            XmlText.WriteElementString("soyisim", "ÇOBAN");
            XmlText.WriteElementString("Email", "cobantalha19@gmail.com");
            XmlText.WriteEndElement();
            XmlText.WriteStartElement("Personel");
            XmlText.WriteAttributeString("ID", "2");
            XmlText.WriteElementString("isim", "Sude");
            XmlText.WriteElementString("soyisim", "KARACA");
            XmlText.WriteElementString("Email", "karacasude24@gmail.com");
            XmlText.WriteEndElement();
            XmlText.WriteEndElement();
            XmlText.Close();
        }
    }
}
