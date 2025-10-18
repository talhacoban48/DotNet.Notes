using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace xml_olusturma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XDocument XDoc = new XDocument(
                new XDeclaration("1.0", "UTF-8", "yes"), 
                new XElement("VeriTabanim", 
                    new XElement("Personellerim", 
                        new XElement("isim","Talha"),
                        new XElement("soyisim", "ÇOBAN"),
                        new XElement("email", "cobantalha19@gmail.com")
                        )
                    )
                );
            XDoc.Save(@"C:\xml\linq_to_xml_1.xml");


            XDocument XDoc2 = new XDocument(
                new XDeclaration("1.0", "UTF-8", "yes"),
                new XElement("VeriTabanim",
                    new XComment("Personellerim Bilgilerini taşır"),
                    new XElement("Personellerim",
                        new XElement("isim", "Talha"),
                        new XElement("soyisim", "ÇOBAN"),
                        new XElement("email", "cobantalha19@gmail.com")
                        )
                    )
                );
            XDoc2.Save(@"C:\xml\linq_to_xml_2.xml");


        }
    }
}
