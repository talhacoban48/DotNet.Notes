using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace udemy.webServisOrnekUygulama.entities
{
    public class urun
    {
        public int id { get; set; }
        public string urunKimlik { get; set; }
        public string tanim { get; set; }
        public string aciklama { get; set; }
        public int stokAdet { get; set; }
    }
}