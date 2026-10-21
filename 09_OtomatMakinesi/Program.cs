namespace _09_OtomatMakinesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region OTOMAT MAKİNESİ

            //            1.Başlangıç ve Veri Yapılarının Tanımlanması
            //Dizileri(Array) Oluştur:

            //            urunler adında 50 eleman kapasiteli bir metin dizisi(string array) tanımla.

            //fiyatlar adında 50 eleman kapasiteli bir sayı dizisi(integer array) tanımla.

            //Değişkenleri Tanımla:

            //urunSayisi = 3(Şu an sistemde var olan ürün sayısı).

            //gunSonuSatis = 0(Toplam kazancı tutacak değişken).

            //Başlangıç Verilerini Diziye Ekle:

            //urunler[0] = "Fanta", fiyatlar[0] = 40

            //urunler[1] = "Kola", fiyatlar[1] = 40

            //urunler[2] = "Çikolata", fiyatlar[2] = 30

            //2.Ana Akış(Sonsuz Döngü)
            //Program kapanana kadar ana menü sürekli ekranda kalmalıdır. Bunun için bir While Döngüsü başlatılır.

            //Ekrana seçenekleri yazdır: 1 - Müşteri Ekranı, 2 - Admin Paneli, 0 - Çıkış.

            //Kullanıcıdan modSecimi al.

            //EĞER modSecimi == 1 ise Müşteri Algoritmasına git.

            //EĞER DEĞİLSE(ELSE IF) modSecimi == 2 ise Admin Paneli Algoritmasına git.

            //EĞER DEĞİLSE(ELSE IF) modSecimi == 0 ise döngüyü kır ve programı bitir.

            //3.Müşteri Ekranı Algoritması
            //Ürünleri Listele(For Döngüsü):

            //i = 0'dan başlayıp urunSayisi değerine kadar dönen bir döngü kur.

            //Her adımda ekrana i+1.ürünün adını(urunler[i]) ve fiyatını(fiyatlar[i]) yazdır.

            //Ürün Seçimi:

            //Kullanıcıdan almak istediği ürünün sıra numarasını iste(secim).

            //Seçim Kontrolü(IF):

            //EĞER secim 0'dan büyük ve urunSayisina eşit ya da küçükse işlem geçerlidir:

            //Seçilen ürünün indeksini bul: index = secim - 1.

            //Seçilen ürünün fiyatını hafızaya al: urunFiyati = fiyatlar[index].

            //Kullanıcıdan para atmasını iste ve yatirilanPara değişkenine kaydet.

            //Ödeme Kontrolü(While Döngüsü): (Para yetersiz olduğu sürece bu döngü tekrarlanır)

            //Durum A(Tam Para): EĞER yatirilanPara == urunFiyati ise;

            //            Ekrana "Afiyet olsun" yazdır.

            //gunSonuSatis değişkenine urunFiyati kadar ekleme yap.

            //Ödeme döngüsünden çık.

            //Durum B(Fazla Para): EĞER DEĞİLSE(ELSE IF) yatirilanPara > urunFiyati ise;

            //            Para üstünü hesapla: paraUstu = yatirilanPara - urunFiyati.

            //            Ekrana "Afiyet olsun, para üstü: [paraUstu] alınız" yazdır.

            //gunSonuSatis değişkenine urunFiyati kadar ekleme yap.

            //Ödeme döngüsünden çık.

            //Durum C(Eksik Para): DEĞİLSE(ELSE);

            //            Ekrana "Yetersiz bakiye" yazdır.

            //Seçenek sun: 1 - Para Ekle, 2 - Para İade.

            //EĞER kullanıcı 1'i seçerse; eklenecek tutarı sor, girilen yeni parayı yatirilanPara değişkeninin üzerine topla (Döngü başa    sarar  ve   paranın yetip yetmediğini tekrar kontrol eder).

            //EĞER DEĞİLSE kullanıcı 2'yi seçerse; "Para iade edildi" yazdır ve ödeme döngüsünden çık.

            //4.Admin Paneli Algoritması
            //Admin panelinde işlemler bittiğinde ana menüye atmaması, admin menüsünde kalması için ayrı bir While Döngüsü başlatılır.

            //Ekrana seçenekleri yazdır: 1 - Ekle, 2 - Güncelle, 3 - Sil, 4 - Listele, 0 - Geri.

            //Adminin seçimini al(adminSecim).

            //1.Yeni Ürün Ekleme Algoritması
            //EĞER urunSayisi dizi kapasitesinden(50) küçükse;

            //            Kullanıcıdan yeni ürünün adını al ve urunler[urunSayisi] konumuna kaydet.

            //Kullanıcıdan yeni ürünün fiyatını al ve fiyatlar[urunSayisi] konumuna kaydet.

            //urunSayisi değerini 1 arttır.

            //DEĞİLSE; "Makine kapasitesi dolu" uyarısı ver.

            //2.Ürün Güncelleme Algoritması
            //For Döngüsü ile mevcut ürünleri listele.

            //Adminden güncellenecek ürünün sıra numarasını iste(guncelIndex).

            //EĞER girilen numara geçerli bir ürün ise;

            //            Yeni ürün adını al ve urunler[guncelIndex] içerisine yaz(eski verinin üzerine yazılır).

            //Yeni fiyatı al ve fiyatlar[guncelIndex] içerisine yaz.

            //3.Ürün Silme Algoritması(Dizi Kaydırma Yöntemi)
            //Standart dizilerden(Array) bir eleman silindiğinde arada boşluk kalmaması için sağdaki elemanlar sola kaydırılır.

            //For Döngüsü ile mevcut ürünleri listele.

            //Adminden silinecek ürünün sıra numarasını al(silIndex = girilenSayi - 1).

            //Kaydırma Döngüsü(For): i = silIndex konumundan başla, urunSayisi -1 değerine kadar dön.

            //Her adımda bir sağdaki ürünün adını, soldaki kutuya kopyala: urunler[i] = urunler[i + 1].

            //Her adımda bir sağdaki ürünün fiyatını, soldaki kutuya kopyala: fiyatlar[i] = fiyatlar[i + 1].

            //Döngü bittiğinde urunSayisi değerini 1 azalt(Böylece en sondaki çift kopya eleman sistemden dışlanmış olur).

            //4.Ürünleri Listeleme Algoritması
            //i = 0'dan urunSayisina kadar dönen bir For Döngüsü kur ve tüm diziyi ekrana yazdır.

            #endregion
        }
    }
}
