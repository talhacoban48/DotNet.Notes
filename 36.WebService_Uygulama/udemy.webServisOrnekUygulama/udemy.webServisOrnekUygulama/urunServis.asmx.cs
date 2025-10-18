using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using udemy.webServisOrnekUygulama.context;
using udemy.webServisOrnekUygulama.entities;
using udemy.webServisOrnekUygulama.guvenlikIslemleri;

namespace udemy.webServisOrnekUygulama
{
    /// <summary>
    /// Summary description for urunServis
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class urunServis : System.Web.Services.WebService
    {

        //[WebMethod]
        //public outputType urunKayitYeni(urun u, guvenlik g)
        //{
        //    string siflenmisData  = "5A66C393-9C0F-48B6-80DC-13F63B82DA43" + g.privateValue.ToString() + g.tokenTime;
        //    if (g.clientKey == SHA.SHA256Olustur(siflenmisData))
        //    {
        //        using (databaseLogicLayer dll = new databaseLogicLayer())
        //        {
        //            if (dll.urunKimlikKontrol(u.urunKimlik) == outputType.yeniUrun)
        //                return dll.urunKayitYeni(u);
        //            else
        //                return outputType.kayitliUrun;
        //        }
        //    }
        //    else
        //    {
        //        return outputType.guvenlikHatasi;
        //    }

        //}

        public guvenlik guvenlikSoapHeader;

        [WebMethod]
        [SoapHeader("guvenlikSoapHeader", Required = true)]
        public outputType urunKayitDuzenle(urun u)
        {
            if (guvenlikSoapHeader.kontrol())
            {
                using (databaseLogicLayer dll = new databaseLogicLayer())
                {
                    if (dll.urunKimlikKontrol(u.urunKimlik) == outputType.kayitliUrun)
                        return dll.urunKayitDuzenle(u);
                    else
                        return outputType.urunBulunamadi;
                }
            }
            else
                return outputType.guvenlikHatasi;

        }

        [WebMethod]
        public outputType urunKayitSil(string urunKimlik)
        {
            using (databaseLogicLayer dll = new databaseLogicLayer())
            {
                if (dll.urunKimlikKontrol(urunKimlik) == outputType.kayitliUrun)
                    return dll.urunKayitSil(urunKimlik);
                else
                    return outputType.urunBulunamadi;
            }
        }

        [WebMethod]
        public List<urun> urunTumListe()
        {
            using (databaseLogicLayer dll = new databaseLogicLayer())
            {
                return dll.urunKayitListe();
            }
        }

        [WebMethod]
        [SoapHeader("guvenlikSoapHeader", Required = true)]
        public urun urunGetir(string urunKimlik)
        {
            if (guvenlikSoapHeader.kontrol())
            {
                using (databaseLogicLayer dll = new databaseLogicLayer())
                {
                    if (dll.urunKimlikKontrol(urunKimlik) == outputType.kayitliUrun)
                        return dll.urunKayitListe(urunKimlik);
                    else
                        return new urun();
                }
            }
            else
                return new urun();

        }
    }
}
