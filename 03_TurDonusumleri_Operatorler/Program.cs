using System.Diagnostics.Metrics;

namespace _03_TurDonusumleri_Operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region TÜR DÖNÜŞÜMLERİ



            /*
             Kullanıcıdan bir data almak için Console.ReadLine() komutu kullanılır.
             Kullanıcıya bilgi vermek(konsole mesaj yazmak) için Console.WriteLine() komutu kullanılır.

             */
            //int yas1 = 35;
            //int yas2 = 15;
            //int toplam = yas1 + yas2;

            //Console.WriteLine(yas1);
            //Console.WriteLine(yas2);
            //Console.WriteLine(yas1+yas2);
            //Console.WriteLine(toplam);

            #region Kullanıcıdan adı ve soyadını alınız. Ekrana Ad ve Soyadı yazdırınız.

            //Console.WriteLine("Adınız:"); //Kullanıcıya mesaj verdik.
            //string ad = Console.ReadLine();

            //Console.WriteLine("Soyad:");
            //string soyad = Console.ReadLine();

            //Console.WriteLine(ad + " " + soyad);

            #endregion

            #region İki kardeşim yaşları toplamı
            /*
            1-Başla
            2-yas1=birinci kardeşin yaşı
            3-yas2=ikinci kardeşin yaşı
            4-toplam=yas1+yas2
            5-Ekrana Yaz(toplam)


            1-başla
            2-"1.kardeşin yaşı:"
            3-string yas1 = console oku
            4-yas1 int çevir            

            */

            //Console.WriteLine("1.Kardeşin Yaşı:");
            //int yas1 =Convert.ToInt32(Console.ReadLine());

            ////int y1 = Convert.ToInt32(yas1); //yas1 değişkenindeki değeri sayısal veri tipine çevirmek


            //Console.WriteLine("2.Kardeşin Yaşı:");
            //int yas2 =Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(yas1 + yas2);

            #endregion

            #region Kullanıcıdan alınan vize ve final notları üzerinden ortalamayı hesaplayarak ekrana yazdırınız.

            //Console.WriteLine("Vize notunuzu giriniz: ");
            //double vize = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Final notunuzu giriniz: ");
            //double final = Convert.ToDouble(Console.ReadLine());

            //double ortalama = (vize * 0.4) + (final * 0.6);
            //Console.WriteLine("Ortalama: " + ortalama);

            #endregion


            #region Tür Dönüşümü

            //string sayi = "566734676378463";
            //int s1 = Convert.ToInt32(sayi);
            //int sayi1 = int.Parse(sayi); // Convert komutunun alternatifi

            #endregion

            // *************** TÜR DÖNÜŞÜMLERİ - VERİ TİPİ DÖNÜŞÜMÜ ***************

            #region Bilinçli Tür Dönüşümü

            //*Sözel-Sayısal tipe dönüşüm
            //Console.WriteLine("Yaş:");
            //int yas = Convert.ToInt32(Console.ReadLine());

            //*Sayısal-Sözel tipe dönüşümü
            //int sayi = 12312;
            //string sayi2 = Convert.ToString(sayi);
            //string sayi3 = sayi.ToString(); //*** bu format çok popülerdir.

            #endregion


            #region Bilinçsiz Tür Dönüşümü

            //Küçük veri tipini Büyük veri tipine atama
            //int sayi = 10;
            //double sayi2 = sayi;

            //** BOXING()
            //Büyük veri tipini Küçük veri tipine atama
            //double sayi = 5;
            //int sayi2 = (int)sayi;


            //double sayi = 573654273654736;
            //long sayi2 = (long)sayi;

            //Console.WriteLine(sayi2);

            #endregion


            #region SCOPE
            //her tanım kendi {} içerisinde erişilebilir.
            //string tv = "LG";

            //{
            //    int sayi = 5;
            //    Console.WriteLine(tv);
            //}

            //{
            //    Console.WriteLine(sayi); //sayi tanımı farklı bir scope bulunduğu için erişilmezdir. 
            //    Console.WriteLine(tv);
            //}

            #endregion


            #region CONSTANT
            //const: sabit değişken

            //int sayi = 5;
            //int sayi = 15; //Hata: Aynı sisimde bir tanımlama yapıldı.

            //sayi = 15; //sayi değişkenin değeri revize edildi.

            //int sayi2 = 10; // Farklı bir değeri tutmak için değişken tanımlandı.


            //const int sayi = 10;
            //sayi = 15;
            #endregion

            //Console.WriteLine("Hello World");

            //Console.WriteLine("klsmdmadsmdsd");

            #endregion

            #region OPERATÖRLER

            #region *** MATEMATİKSEL OPERATÖRLER (+,-,*,/,%)
            //int sayi = 5;
            //int sayi2 = 12;

            ////Mod Alma(%)

            //Console.WriteLine(sayi%sayi2);


            //Bölme işleminde, işleme uğrayan sayılardan biri dahi ondalıklı ise sonuç ondalıklı ama her iki sayıda int ise sonuç TAM SAYI çıkar.
            //double sayi = 12;
            //int sayi2 = 5;

            //int sonuc = (int)(sayi / sayi2);

            //Console.WriteLine("Sonuç:"+sonuc);
            #endregion

            #region  *** ATAMA(=) ve İŞLEMLİ ATAMA OPERATÖRLERİ ***
            //int sayi = 5;

            //sayi +=1;  //sayi = sayi + 1;
            //sayi -=1;  //sayi = sayi - 1;
            //sayi *=2;  //sayi = sayi * 2;
            //sayi /=2;  //sayi = sayi / 2;

            //BİR ARTTIRMA, BİR AZALTMA

            //int sayi = 5;
            //sayi++;  //sayi += 1;   //sayi = sayi + 1;
            //Console.WriteLine(sayi);

            //sayi--;  //sayi -= 1;   //sayi = sayi - 1;
            //Console.WriteLine(sayi);

            //Örnek:
            //int a = 5;
            //int b = a++; //a değerini b ye ata sonra a değerini 1 arttır.
            //int c = ++a; //a değerini 1 arttır sonra a değerini c ye ata.
            //int d = b + c;
            //double e = d / a;

            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
            //Console.WriteLine(d);
            //Console.WriteLine(e);
            #endregion

            #region *** KARŞILAŞTIRMA OPERATÖRLERİ ***

            //int sayi = 5;
            //int sayi2 = 6;

            //bool sonuc  = sayi > sayi2;
            //bool sonuc2 = sayi < sayi2;
            //bool sonuc3 = sayi >= sayi2;
            //bool sonuc4 = sayi <= sayi2;
            //bool sonuc5 = sayi == sayi2; // sayi ile sayi2 eşit mi?
            //bool sonuc6 = sayi != sayi2; // sayi ile sayi2 eşit değil mi?

            //Console.WriteLine("Sonuç:"+sonuc);
            //Console.WriteLine($"Sonuç:{sonuc2}");
            //Console.WriteLine("Sonuç:{0}",sonuc3);
            //Console.WriteLine("Sonuç:" + sonuc4);
            //Console.WriteLine("Sonuç:" + sonuc5);
            //Console.WriteLine("Sonuç:" + sonuc6);
            #endregion

            #region *** KIYAS OPERATÖRÜ(?:) *** 
            // ? kıyas durumu TRUE ise atanacak değer 
            // : kıyas durumu FALSE ise atanacak değer
            //int sayi = 5;

            //string sonuc = 5 > 6 ? "Büyüktür" : "Küçüktür";
            //int sonuc2 = 5 > 6 ? 1 : 0;

            #endregion

            #region *** ERİŞİM OPERATÖRÜ(.) ***

            //Console.WriteLine();

            //Console.ReadLine().ToString().ToLower();

            #endregion

            #region *** MANTIKSAL OPERATÖRLERİ ***
            // AND - &&
            //// Bir işlemin başarılı(true) olması için her şartın sağlanması gerekiyor ise && kullanılır.

            //string username = "muhammed";
            //string password = "1";

            //Console.WriteLine("Kullanıcı Adınız:");
            //string kullaniciAdi = Console.ReadLine();

            //Console.WriteLine("Şifreniz:");
            //string pass = Console.ReadLine();

            ////Oturum açma işleminin sağlnması için hem kullanıcıadı hemde şifresi uyuşmalıdır.

            //bool girisDurumu = username == kullaniciAdi && password==pass;

            //Console.WriteLine(girisDurumu);

            /* Çarpma işlemi mantığı ile çalışır.
             1  2   Sonuc
             0  0   0
             0  1   0
             1  0   0
             1  1   1 
             */



            // OR - ||
            //// Bir işlemin başarılı(true) olması için şartlardan herhangi birinin sağlanması gerekiyor ise || kullanılır.

            //string username = "muhammed";
            //string email = "altanemre@gmail.com";
            //string password = "1";

            //Console.WriteLine("Kullanıcı Adı/Email:");
            //string kullanici = Console.ReadLine();


            //Console.WriteLine("Şifreniz:");
            //string pass = Console.ReadLine();

            //////Oturum açma işleminin sağlanması için (kullanıcıadı veya email'in uyuşması) ve şifrenin uyuşması gereklidir.

            //bool girisDurumu = (username == kullanici || email == kullanici) && pass==password;

            //Console.WriteLine(girisDurumu);

            /* Toplama işlemi mantığı ile çalışır.
             1  2   Sonuc
             0  0   0
             0  1   1
             1  0   1
             1  1   1 
             */



            // NOT - !


            #endregion

            #region Kullanıcıdan yaş, mezuniyet ve Cinsiyet bilgilerini alınız.  
            //Ehliyet alma koşulu: Yaş 18 den büyük ve mezuniyet Lise olamalı. veya cinsiyet erkek olmalı. 


            //Console.WriteLine("Yaş:");
            //int yas = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Mezuniyet:");
            //string mezuniyet = Console.ReadLine().ToLower();

            //Console.WriteLine("Cinsiyet:");
            //string cinsiyet = Console.ReadLine().ToUpper();

            //bool sonuc = (yas > 18 && mezuniyet == "lise") || cinsiyet == "ERKEK";

            //Console.WriteLine("Sonuç:"+sonuc);

            #endregion

            #endregion


            #region ALIŞTIRMALAR
            /*
             ### Değişkenler ve Veri Tipleri
            1. *Soru:* Kullanıcının adını, yaşını ve boyunu (metre cinsinden) alıp ekrana yazdıran bir program yazın.
            - *İpucu:* string, int, ve double veri tiplerini kullanabilirsiniz.

            Console.WriteLine("Kullanıcı adı:");
            string username = Console.ReadLine();

            Console.WriteLine("Yaş:");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Boyunuz(m):");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Kullanıcı Adı:"+username+" Yaş:"+age+" Boy:"+height);
            Console.WriteLine($"Kullanıcı Adı:{username} Yaş:{age} Boy:{height}");


            2. *Soru:* Aşağıdaki değişkenleri tanımlayın ve uygun değerler atayın:
            - bool isStudent
            - char grade
            - float temperature

            
            bool isStudent = true;
            char grade = 'A';
            float temperature = 10.5f;
}


            ### Tür Dönüşümleri
            3. *Soru:* Kullanıcıdan bir sayı alın ve bu sayıyı hem int hem de double veri tipine dönüştürerek ekrana yazdırın.
            - *İpucu:* Convert.ToInt32() ve Convert.ToDouble() yöntemlerini kullanabilirsiniz.
            
            Console.WriteLine("Bir sayı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(sayi);

            double sayi2 = Convert.ToDouble(sayi);
            Console.WriteLine(sayi2);



            Console.WriteLine("Bir sayı giriniz");
            object sayi = Console.ReadLine();

            int sayi3 = (Convert.ToInt32(sayi));

            double sayi2 = Convert.ToDouble(sayi);
            Console.WriteLine(sayi2+sayi3);


            4. *Soru:* double türünde bir değişken oluşturun ve bu değişkenin değerini string olarak ekrana yazdırın.
            - *İpucu:* ToString() yöntemini kullanabilirsiniz.
            

            ### Operatörler
            5. *Soru:* İki tam sayı alın ve bu sayılar üzerinde toplama, çıkarma, çarpma ve bölme işlemlerini yaparak sonuçları ekrana yazdırın.
            - *İpucu:* +, -, *, / operatörlerini kullanabilirsiniz.

            int bolunen = 10;
            double bolen = 3;

            double sonuc = (int)(bolunen / bolen);
            Console.WriteLine(sonuc);

            Console.WriteLine(bolunen/bolen);


            6. *Soru:* Kullanıcıdan iki sayı alın ve bu sayıların birbirine eşit olup olmadığını kontrol edin. Sonucu ekrana yazdırın.
            - *İpucu:* == operatörünü kullanabilirsiniz.

            ### Karma Sorular
            7. *Soru:* Kullanıcıdan bir sayı alın ve bu sayının tek mi çift mi olduğunu kontrol edin. Sonucu ekrana yazdırın.
            - *İpucu:* % operatörü kullanarak kalan değerini kontrol edebilirsiniz.

            Console.WriteLine("1.sayı:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            bool sonuc = sayi1 % 2 == 0;

            string cevap = sonuc == true ? "Çift" : "Tek";
            Console.WriteLine(cevap); //sayi1%2: sayi1 2'ye bölümünden kalanı verir.


            8. *Soru:* Kullanıcıdan bir sıcaklık değeri alın ve bu değerin 0°C'nin altında olup olmadığını kontrol edin. Eğer öyleyse "Dondurucu soğuk!" mesajını ekrana yazdırın.
            - *İpucu:* < operatörünü kullanabilirsiniz.
            
            Console.WriteLine("Hava kaç derece?");
            int derece = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(derece<0 ? "Dondurucu Soğuk" : "Yakıcı Sıcak");

            bool sonuc = derece < 0;

            string havaDurumu = sonuc==true ? "Dondurucu Soğuk" : "Yakıcı Sıcak";
            Console.WriteLine("Hava Durumu:"+havaDurumu);
             */
            #endregion

            //Console.WriteLine("Bakiye:");
            //float bakiye = Convert.ToSingle(Console.ReadLine());

            //float balance = float.Parse(Console.ReadLine());


        }
    }
}
