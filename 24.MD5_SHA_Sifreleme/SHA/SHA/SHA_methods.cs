using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SHA
{
    public static class SHA
    {
        public static string SHA256Sifrele(string deger)
        {
            SHA256 sha256 = SHA256Managed.Create();
            byte[] degerbyte = Encoding.UTF8.GetBytes(deger);
            byte[] sha256byte = sha256.ComputeHash(degerbyte);
            return HashtoByte(sha256byte);
        }

        public static string SHA512Sifrele(string deger)
        {
            SHA512 sha512 = SHA512Managed.Create();
            byte[] degerbyte = Encoding.UTF8.GetBytes(deger);
            byte[] sha256byte = sha512.ComputeHash(degerbyte);
            return HashtoByte(sha256byte);
        }

        private static string HashtoByte(byte[] data)
        {
            StringBuilder sonuc = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sonuc.Append(data[i].ToString("X2"));
            }

            return sonuc.ToString();
        }
    }
}
