using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace json_okuma
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string jsonOkunanData = File.ReadAllText("C:\\Users\\Talha\\Desktop\\C#\\18.json\\json_veri\\veri\\Personellerim.json");
            List<XObject> Data = Newtonsoft.Json.JsonConvert.DeserializeObject<List<XObject>>(jsonOkunanData);

            foreach (XObject XObject in Data)
            {
                Console.WriteLine(XObject.ToString());
            }
            Console.ReadLine();
        }
    }
}
