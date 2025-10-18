using checkbox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkbox
{
    public static class Database
    {

        public static List<Urun> UrunTablo = new List<Urun>()
        {
            new Urun()
            {
                id = Guid.NewGuid(),
                urunAdi = "Bir ömür nasıl yaşanır",
                yazar = "ilber ortaylı",
                stokAdeti = "10",
                urunKategori = "Roman",
                KitapResim = @"C:\\Users\\Talha\\Downloads\\1.jpg",
                aciklama = "İlber Ortaylı, yediden yetmişe herkesin faydalanacağı, bilge şahsiyetinden ve yaşam tecrübesinden süzülen tavsiyelerden oluşan bir eserle karşımızda. İlber Hoca bu kitapta, bir insanın, çocukluktan itibaren hayatın hemen her alanında ihtiyaç duyacağı çözümleri nasıl bulabileceğini örnekler vererek anlatıyor. “Herkes kendi talihinin mimarıdır” sözünü hatırlatarak, kendi yolunu çizmenin ne anlama geldiğini tüm kritik noktalarıyla yorumluyor."
            },
            new Urun()
            {
                id = Guid.NewGuid(),
                urunAdi = "İrade Terbiyesi",
                yazar = "dostoyevski",
                stokAdeti = "25",
                urunKategori = "Roman",
                KitapResim = @"C:\\Users\\Talha\\Downloads\\2.jpg",
                aciklama = "Eğitimci Jules Payot, İrade Terbiyesi’nde, tembellikten arındırılmış sağlam bir zihni nasıl yaratabileceğimizi anlatıyor. Çabalamayı asla bırakmamamızı, arzu ettiğimiz hayata ulaşabilmemiz için zaruri bir terbiyeye ihtiyacı olan irademizi sürekli sınavdan geçirmemizi öğütlüyor. Özellikle gençlere ve zihin işçilerine seslenen Payot, safsatalardan, tembel arkadaşlardan, dikkatimizi dağıtacak ve azmimizi azaltacak durumlardan nasıl kaçınabileceğimizi açıklıyor"
            },
            new Urun()
            {
                id = Guid.NewGuid(),
                urunAdi = "İnsancıklar",
                yazar = "dostoyevski",
                stokAdeti = "32",
                urunKategori = "Roman",
                KitapResim = @"C:\\Users\\Talha\\Downloads\\3.jpg",
                aciklama = "Dostoyevski’nin henüz yirmi dört yaşında kaleme aldığı İnsancıklar, Rus edebiyatının ilk toplumsal romanlarından biri kabul ediliyor. Sınıf çatışması, edebiyat sevgisi ve hayata tutunma çabasının iki dostun mektuplarıyla anlatıldığı bu eser, büyük yazarın okuyucunun karşısına çıktığı ilk kitabı"
            },
            new Urun()
            {
                id = Guid.NewGuid(),
                urunAdi = "Açlık",
                yazar = "dostoyevski",
                stokAdeti = "2",
                urunKategori = "Hikaye",
                KitapResim = @"C:\\Users\\Talha\\Downloads\\4.jpg",
                aciklama = "Yirminci yüzyılın önemli olduğu kadar tartışmalı yazarı Knut Hamsun’un otobiyografik ögeler taşıyan romanı Açlık, kendini arayan ve bir yandan da mükemmel bir yazın ortaya koymayı amaçlayan genç bir yazarın açlık, yoksulluk ve çaresizlikle mücadelesini anlatıyor"
            },
            new Urun()
            {
                id = Guid.NewGuid(),
                urunAdi = "Pal Sokağı Çocukları",
                yazar = "dostoyevski",
                stokAdeti = "7",
                urunKategori = "Roman",
                KitapResim = @"C:\\Users\\Talha\\Downloads\\5.jpg",
                aciklama = "Dünyanın neresine giderseniz gidin, onun hakkında sohbet edebileceğiniz birilerini bulabileceğiniz bir kitap Pál Sokağı Çocukları"
            }
        };
    }
}
