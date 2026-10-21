namespace _09_Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* ****** ARRAYS ******
              Aynı veri tipinde birden fazla değeri bir başlık altında tutmaya yarar.
             Dizi adına INDEX denilen 0'dan başlayarak 1'er 1'er artan numaralandırma işlemi ile değerleri tutarlar.
             */

            //int sayi = 12;

            //Dolu bir dizi tanımı
            //int[] sayilar = { 11, 12, 13 };

            //Console.WriteLine(sayilar[0]);
            //Console.WriteLine(sayilar[1]);
            //Console.WriteLine(sayilar[2]);
            //Console.WriteLine(sayilar[3]); //Olamayan bir index numarası çağrılırsa IndexOutOfRangeException hatasını verir.


            //for(int i=0; i<sayilar.Length; i++)
            //{
            //    Console.WriteLine(sayilar[i]);
            //}

            //int indx = 0;

            //while (indx < sayilar.Length)
            //{
            //    Console.WriteLine(sayilar[indx]);
            //    indx++;
            //}




            //Boş dizi tanımı
            //int[] sayilar = new int[3];

            //Diziye değer ekleme
            //sayilar[0] = 22;
            //sayilar[1] = 23;
            //sayilar[2] = 24;
            //sayilar[3] = 25;


            //Kullanıcıdan alınan 4 sayıyı bir diziye ekleyiniz.

            //int[] sayilar = new int[4];

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.WriteLine("Sayı:");
            //    sayilar[i] = Convert.ToInt32(Console.ReadLine());
            //}

            #region Kullanıcıdan kaç personeli olduğu bilgisini isteyiniz. Daha sonra personel isimlerini kullanıcıdan alarak diziye ekleyin ve işlem bittiğinde ekrana yazdırınız

            //Console.WriteLine("Personel sayısı: ");
            //int personelSayisi = Convert.ToInt32(Console.ReadLine());

            //string[] personeller = new string[personelSayisi];

            //for (int i = 0; i < personelSayisi; i++)
            //{
            //    Console.WriteLine("Personel adı:");
            //    personeller[i] = Console.ReadLine();
            //}

            //Console.WriteLine("PERSONEL LİSTESİ: ");

            //for (int i = 0; i < personelSayisi; i++)
            //{
            //    Console.WriteLine(personeller[i]);
            //}


            #endregion

            #region ARRAY SINIFI METOTLARI

            #region CLEAR()

            //int[] sayilar = { 11, 22, 33, 44 };

            ////Array.Clear(sayilar); //Bütün dizi elemanlarını siler.

            //Array.Clear(sayilar, 1, 2); //1.indexten başlayarak 2 değer siler

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.WriteLine(sayilar[i]);
            //}

            #endregion

            #region COPY()

            //int[] sayilar = { 11, 22, 33, 44 };

            //int[] sayilar2 = new int[10];


            ////Array.Copy(sayilar, sayilar2, 2); //Kaynak dizi, hedef dizi, kopyalanacak değer sayısı

            //Array.Copy(sayilar, 2, sayilar2, 4, 2);


            //for (int i = 0; i < sayilar2.Length; i++)
            //{
            //    Console.WriteLine(sayilar2[i]);
            //}

            #endregion

            #region INDEXOF()

            //string[] isimler = { "Altan", "Emre", "Altan", "Mehmet", "Efe", "Altan", "Erdinç", "Doğukan", "Altan", "Miraç" };

            //int index = Array.IndexOf(isimler, "Altan"); //ilk Altan değerinin index numarasını getirir.

            //int index = Array.IndexOf(isimler, "Altan",1); 

            //Console.WriteLine("Altan index numarası:"+index);

            #region Yukarıdaki bütün Altan değerlerinin index numaralarını ekrana yazdıran döngüyü yazınız.

            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    if (isimler[i] == "Altan")
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            //int i = -1;

            //while (i < isimler.Length)
            //{
            //    i = Array.IndexOf(isimler, "Altan", i + 1);

            //    if (i == -1)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(i);
            //}


            #endregion
            #endregion

            #region LASTINDEX()
            //string[] isimler = { "Altan", "Emre", "Altan", "Mehmet", "Efe", "Altan", "Erdinç", "Doğukan", "Altan", "Miraç" };

            //Console.WriteLine(Array.LastIndexOf(isimler,"Altan"));

            #endregion

            #region SORT()

            //string[] sehirler = { "Yozgat", "Adana", "Balıkesir", "Zonguldak", "İstanbul", "Çanakkale" };

            //Array.Sort(sehirler);

            //for (int i = 0; i < sehirler.Length; i++)
            //{
            //    Console.WriteLine(sehirler[i]);
            //}

            #endregion

            #region REVERSE()

            //string[] sehirler = { "Yozgat", "Adana", "Balıkesir", "Zonguldak", "İstanbul", "Çanakkale" };

            //Array.Reverse(sehirler);

            //for (int i = 0; i < sehirler.Length; i++)
            //{
            //    Console.WriteLine(sehirler[i]);
            //}


            #endregion

            #region RESIZE

            //int[] sayilar = new int[3];

            //sayilar[0] = 11;
            //sayilar[1] = 22;
            //sayilar[2] = 33;

            //Array.Resize(ref sayilar, 5); //sayilar dizisinin boyutunu 5'e çıkardık.

            //sayilar[3] = 44;

            #endregion

            #endregion

            #region Bir dizinin eleman sayısı 10 ile 20 arasında rastgele atansın.
            //Bu dizinin elemanlarını sistem 0-100 aralığında rastgele otomatik doldursun
            //Aynı sayı tekrar diziye eklenmesin
            //Dizinin en büyük ve en küçük değerlerini ekran yazdırınız.

            //Random r = new Random();

            //int boyut = r.Next(10, 20);

            //int[] sayilar = new int[boyut];
            //Console.WriteLine("Boyut:"+boyut);

            //int i = 0;
            //while(i<boyut)
            //{
            //    int sayi = r.Next(1, 25);

            //    if(sayilar.Contains(sayi) == false)
            //    {
            //        sayilar[i] = sayi;
            //        i++;
            //    }                
            //}

            //int enBuyuk = sayilar[0];
            //int enKucuk = sayilar[0];

            //for (int j = 0; j < boyut; j++)
            //{
            //    if (sayilar[j] > enBuyuk)
            //    {
            //        enBuyuk = sayilar[j];
            //    }
            //    if (sayilar[j] < enKucuk)
            //    {
            //        enKucuk = sayilar[j];
            //    }
            //}

            //Console.WriteLine("En büyük:"+enBuyuk);
            //Console.WriteLine("En küçük:"+enKucuk);

            //for (int k = 0; k < sayilar.Length; k++)
            //{
            //    Console.WriteLine(sayilar[k]);
            //}


            #endregion



            #region FOREACH
            //Koleksiyonları ekrana yazdırmak için kullanılır.
            
            //int[] sayilar = { 11, 22, 33, 44 };

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.WriteLine(sayilar[i]);
            //}

            //foreach (int sayi in sayilar)
            //{
            //    Console.WriteLine(sayi);
            //}




            #endregion



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
