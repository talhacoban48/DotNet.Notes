using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace udemy.webServisOrnekUygulama.entities
{
    public class guvenlik
    {
        public string kullaniciAdi { get; set; }
        public string sifre { get; set; }

        public string clientKey { get; set; }
        public string tokenTime { get; set; }
        public int privateValue { get; set; }
    }
}