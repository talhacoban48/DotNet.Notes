using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace Registry_Deger_Ekleme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ekleme
            Registry.CurrentUser.SetValue("Anahtar", "Merhaba Registry");

            // Okuma
            string gelendeger = Registry.CurrentUser.GetValue("Anahtar").ToString();
            Console.WriteLine($"gelen deger : {gelendeger}");

            // silme
            Registry.CurrentUser.DeleteValue("Anahtar");

            // subkey (klasör) oluşturma
            Registry.CurrentUser.CreateSubKey("xyzProjesi");
            // subkey (klasör) erişme
            RegistryKey xyzProjesi = Registry.CurrentUser.OpenSubKey("xyzProjesi", true);
            // subkey (klasör) içine değer ekleme
            xyzProjesi.SetValue("Numara4", "12345678");
            // subkey (klasör) içinden değer alma
            string gelendeger2 = xyzProjesi.GetValue("Numara4").ToString();
            Console.WriteLine($"gelen deger : {gelendeger2}");
            xyzProjesi.Close();

            // subkey deger listeleme
            RegistryKey xyzProjesi2 = Registry.CurrentUser.OpenSubKey("xyzProjesi");
            string[] gelendegerler = xyzProjesi2.GetValueNames();
            foreach (string key in gelendegerler)
            {
                string value = xyzProjesi2.GetValue(key).ToString();
                Console.WriteLine($"{key} : {value}");
            }

            Console.ReadLine();
        }
    }
}
