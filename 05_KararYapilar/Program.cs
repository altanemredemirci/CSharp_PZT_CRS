namespace _05_KararYapilar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region KARAR YAPILAR 
            /*
             IF ELSE
             SWITCH CASE

            Birden fazla koşul olması durumunda ilk koşul if bloğu ile kontrol edilir, alternatif her koşul için else if bloğu kullanılır.
            Koşullar dışında kalan her durum için else bloğu kullanılır. 
                ** Geri kalan her durum else bloğu ile kontrol edilir bu sebeple KOŞUL TANIMLANMAZ.

             */

            //Kullanıcı yaşı 18 den büyük ise "Yetişkin" bilgisi ekrana yazdırılsın

            //Console.WriteLine("Yaşınız:");
            //int yas = Convert.ToInt32(Console.ReadLine());

            //string cevap = yas > 18 ? "Yetişkin" : "Çocuk";
            //Console.WriteLine("Sonuç:"+cevap);

            /*
            1-Başla
            2-int yas = Kullanıcıdan yaş bilgisini alınız
            3-Eğer yas>18 ise Ekrana "Yetişkin" yaz
            4-Değilse Ekrana "Çocuk" yaz
            5-Bitti
             */

            //Console.WriteLine("Yaşınız:");
            //int yas = Convert.ToInt32(Console.ReadLine());

            //if (yas > 18)
            //{
            //    Console.WriteLine("Yetişkin");
            //}
            //else
            //{
            //    Console.WriteLine("Çocuk");
            //}
            #endregion

            #region If - Else if - Else

            //Kullanıcıdan bir sayı alınız. Alınan sayının 1-10, 11-20, 21-30 veya üzerinde olduğunu ekrana yazdırınız.

            /*
            1-Başla
            2-int sayi = Bir sayı giriniz
            3-Eğer sayi>0 ve sayi<11 ise Ekrana "1-10 aralığındadır."
            4-Değilse Eğer sayi>10 ve sayi<21 ise Ekrana "11-20 aralığındadır."
            5-Değilse Eğer sayi>20 ve sayi<31 ise Ekrana "21-30 aralığındadır."
            6-Değilse Ekrana "30'dan büyüktür"
            7-Bitir.
             */

            //Console.WriteLine("Bir sayı giriniz:");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //if (sayi > 0 && sayi < 11)
            //{
            //    Console.WriteLine("1-10 aralığındadır.");
            //}
            //else if (sayi > 10 && sayi < 21)
            //{
            //    Console.WriteLine("11-20 aralığındadır.");
            //}
            //else if (sayi > 20 && sayi < 31)
            //{
            //    Console.WriteLine("21-30 aralığındadır.");
            //}
            //else
            //{
            //    Console.WriteLine("30'dan büyük veya 1'dden küçüktür.");
            //}


            #endregion

            #region Kullanıcıdan alınan sayının pozitif mi negatif mi olduğunu ekrana yazdırınız

            //Console.WriteLine("Bir sayı giriniz:");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //if (sayi > 0)
            //{
            //    Console.WriteLine("Pozitif");
            //}
            //else
            //{
            //    Console.WriteLine("Negatif");
            //}

            #endregion

            #region Kullanıcıya haftanın kaçıncı günü olduğunu soralım ve girilen rakama göre gün adını ekrana yazdıralım.

            //Console.WriteLine("Haftanın gün sayısı:");
            //int gun = Convert.ToInt32(Console.ReadLine());

            //if (gun > 7 || gun<1)
            //{
            //    Console.WriteLine("Lütfen 1-7 arasında bir sayı giriniz.");
            //}
            //else if (gun == 1)
            //{
            //    Console.WriteLine("Pazartesi " + gun);
            //}
            //else if (gun == 2)
            //{
            //    Console.WriteLine("salı " + gun);
            //}
            //else if (gun == 3)
            //{
            //    Console.WriteLine("carsamba " + gun);
            //}
            //else if (gun == 4)
            //{
            //    Console.WriteLine("persembe " + gun);
            //}
            //else if (gun == 5)
            //{
            //    Console.WriteLine("cuma " + gun);
            //}
            //else if (gun == 6)
            //{
            //    Console.WriteLine("Cumartesi " + gun);
            //}
            //else
            //{
            //    Console.WriteLine("Pazar " + gun);
            //}

            #endregion

            #region Kullanıcıdan iki ürün fiyatı isteyin, ürün fiyat toplamları 2500 tl geçerse ucuz ürüne  % 25 indirim uygulayınız

            /*
            1-Başla
            2-İki adet ürün fiyatı alınız
            3-Ürün fiyatlarını toplayınız
            4-Eğer toplamı 2500'den büyük ise 
                4.1-Ucuz ürünü bul
                4.2-Ucuz ürüne %25 indirim uygula
                4.3-Toplamı ekrana yazdır
            5-Değilse Toplamı ekrana yazdır.
             */

            //Console.WriteLine("1.Ürün Fiyatı:");
            //double fiyat1 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("2.Ürün Fiyatı:");
            //double fiyat2 = Convert.ToDouble(Console.ReadLine());

            //double odeme = fiyat1 + fiyat2;

            //if (odeme > 2500)
            //{
            //    if (fiyat1 < fiyat2)
            //    {
            //        fiyat1 = fiyat1 * 0.75;

            //    }
            //    else
            //    {                    
            //        fiyat2 = fiyat2 * 0.75;
            //    }              
            //}
            //Console.WriteLine("Ödeme:" + (fiyat1 + fiyat2));

            #endregion
            #region Aylık geliri 40000 üstünde ise %12 vergi kesilecek,
            // 40000 ve altında ise %9 vergi kesimi yapılarak 
            // kullanıcıya yeni gelirini bu hesaplamalar sonucunda gösteriniz

            //Console.WriteLine("Aylık geliriniz:");
            //double aylik = Convert.ToDouble(Console.ReadLine());

            #region 1.Yol
            //if (aylik > 40000)
            //{
            //    //aylik = aylik * 0.88;
            //    double vergi = (aylik / 100) * 12;
            //    aylik = aylik - vergi;

            //    Console.WriteLine("Vergi Tutarı:" + vergi);
            //    Console.WriteLine("Aylık:" + aylik);
            //}
            //else
            //{
            //    double vergi = (aylik / 100) * 9;
            //    aylik = aylik - vergi;

            //    Console.WriteLine("Vergi Tutarı:" + vergi);
            //    Console.WriteLine("Aylık:" + aylik);
            //}
            #endregion

            #region 2.Yol
            //int vergiOrani = aylik > 40000 ? 12 : 9;

            ///*
            // int vergiOrani=0;
            //if(aylik>40000)
            //    vergiOrani=12;
            //else
            //    vergiOrani=9;
            // */

            //double vergi = (aylik / 100) * vergiOrani;
            //double netAylik = aylik - vergi;

            //Console.WriteLine("Vergi Tutarı:" + vergi);
            //Console.WriteLine("Aylık:" + aylik);
            #endregion


            #endregion

            #region Öğrenciden vize ve final notlarını alınız ve vize %40 final %60 alınarak ortalamasını hesaplayınız. 

            //ortalamaya göre 
            /*
             * 
            0,24   FF
            25,44  DD
            45,54  CC
            55,69  CB
            70,84  BB
            85,100 AA

             */
            //GOTO komutu: Belirli bir satırdan kod okuyucuyu istemilen satıra gönderir.

            //VIZE:
            //    Console.Write("Vize Notunu Giriniz: ");
            //    double vizeNotu = Convert.ToDouble(Console.ReadLine());

            //    if (vizeNotu >= 0 && vizeNotu <= 100)
            //    {
            //    FINAL:
            //        Console.Write("Final Notunu Giriniz: ");
            //        double finalNotu = Convert.ToDouble(Console.ReadLine());

            //        if (finalNotu >= 0 && finalNotu <= 100)
            //        {
            //            double ortalama = vizeNotu * 0.40 + finalNotu * 0.60;

            //            if (ortalama < 25)
            //            {
            //                Console.WriteLine("FF");
            //            }
            //            else if (ortalama < 45)
            //            {
            //                Console.WriteLine("DD");
            //            }
            //            else if (ortalama < 55)
            //            {
            //                Console.WriteLine("CC");
            //            }
            //            else if (ortalama < 70)
            //            {
            //                Console.WriteLine("BC");
            //            }
            //            else if (ortalama < 85)
            //            {
            //                Console.WriteLine("BB");
            //            }
            //            else
            //            {
            //                Console.WriteLine("AA");
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("Final Notu 0-100 aralığında olmalıdır!!!");
            //            goto FINAL;
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Vize Notu 0-100 aralığında olmalıdır!!!");
            //        goto VIZE;
            //    }


            #endregion

            #region  1-50 arasındaki sayıların içinde 7'e tam bölünenleri ekrana teker teker yazdırınız.
            //    int basla = 1;
            //    int bitir = 50;

            //DON:
            //    if (basla < bitir)
            //    {
            //        if (basla % 7 == 0)
            //        {
            //            Console.WriteLine(basla);
            //        }
            //        basla += 1;
            //        goto DON;
            //    }


            #endregion

            #region   Kullanıcıdan isim, yaş, maaş ve çocuk sayısı alınsın.
            /*
                Eğer kulanıcının yaşı 45'in altındaysa;
                    Çocuk sayısına bakılacak.Ve çocuk sayısı 3'ten az ise çocuk başına 2500₺,
                                                          3 ve 3'ten çok ise çocuk başına 2000₺ 
                                                                maaşa ekleme yapılacak.
                45 ve 45'in üzerinde ise çocuk başına para verilmeyecek ancak 5000₺ ekleme yapılacak.
                Son olarak ekrana: "Nesrin Yılmaz, Maaşınız: 40000₺" yazılacak.
             */

            //Console.WriteLine("İsim:");
            //string isim = Console.ReadLine();

            //Console.WriteLine("Yaş:");
            //int yas = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Maaş:");
            //double maas = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Çocuk Sayısı:");
            //int cocukSayisi = Convert.ToInt32(Console.ReadLine());

            //if (yas < 45)
            //{
            //    if (cocukSayisi < 3)
            //    {
            //        maas = maas + (cocukSayisi * 2500);
            //    }
            //    else
            //    {
            //        maas += cocukSayisi * 2000;
            //    }
            //}
            //else
            //{
            //    maas += 5000;
            //}

            //Console.WriteLine($"{isim}, Maaşınız:{maas.ToString("c")}");
            #endregion

            #region EMEKLİLİK HESABI
            /*
                 kullanıcıdan alınan cinsiyet bilgisine göre
          ==> ERKEK ise
                yaşı 60 ve üstü ise maaşının 10 katı kadar ikramiye alaral emekli edilecek, 
                yaş 60'ın altında ise çalıştığı gün sayısına göre 
                    eğer 6000 ve üstü ise maaşının 11 katı kadar ikramiye alarak emekli edilecek, 
                    6000 altında ise emekli edilmeyecek bilgisi kullanıcıya gösterilecek
          ==> KADIN ise
           yaşı 58 ve üstü ise maaşının 10 katı kadar ikramiye alarak emekli edilecek, yaş 58'ın altında ise çalıştığı gün sayısına göre eğer 3600 ve üstü ise maaşının 11 katı kadar ikramiye alarak emekli edilecek, 3600 altında ise emekli edilmeyecek bilgisi kullanıcıya gösterilecek
          ==> cinsiyet bilgisi switch-case ile sorgulanacak
             
             */

            //Console.WriteLine("Cinsiyet(E/K):");
            //string cinsiyet = Console.ReadLine().ToUpper();

            //if (cinsiyet == "E")
            //{
            //    Console.WriteLine("Yaş:");
            //    int yas = Convert.ToInt32(Console.ReadLine());

            //    if (yas >= 60)
            //    {
            //        Console.WriteLine("Maaş:");
            //        double maas = Convert.ToDouble(Console.ReadLine());

            //        Console.WriteLine("İkramiyeniz:"+(maas*10));
            //    }
            //    else
            //    {
            //        Console.WriteLine("Prim gün sayısı:");
            //        int prim = Convert.ToInt32(Console.ReadLine());

            //        if (prim >= 6000)
            //        {
            //            Console.WriteLine("Maaş:");
            //            double maas = Convert.ToDouble(Console.ReadLine());

            //            Console.WriteLine("İkramiyeniz:" + (maas * 11));
            //        }
            //        else
            //        {
            //            Console.WriteLine("Emeklilik hayal. Çalışmaya devam :)");
            //        }
            //    }


            //}
            //else if (cinsiyet == "K")
            //{
            //    Console.WriteLine("Yaş:");
            //    int yas = Convert.ToInt32(Console.ReadLine());

            //    if (yas >= 58)
            //    {
            //        Console.WriteLine("Maaş:");
            //        double maas = Convert.ToDouble(Console.ReadLine());

            //        Console.WriteLine("İkramiyeniz:" + (maas * 10));
            //    }
            //    else
            //    {
            //        Console.WriteLine("Prim gün sayısı:");
            //        int prim = Convert.ToInt32(Console.ReadLine());

            //        if (prim >= 3600)
            //        {
            //            Console.WriteLine("Maaş:");
            //            double maas = Convert.ToDouble(Console.ReadLine());

            //            Console.WriteLine("İkramiyeniz:" + (maas * 11));
            //        }
            //        else
            //        {
            //            Console.WriteLine("Emeklilik hayal. Çalışmaya devam :)");
            //        }
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("Hatalı Cinsiyet Girişi!!!");
            //}
            #endregion


            #region SWITCH-CASE
            /*
             Bu karar yapısı bir verinin eşit olduğu duruma göre çalışır.
             
             */

            //int sayi = 5;
            //switch (sayi)
            //{
            //    case 1:
            //        //yapılacak işlem
            //        break;
            //    case 2:
            //        //yapılacak işlem
            //        break;
            //    default:
            //        break;
            //}

            #region 1.Örnek

            //Kullanıcıya haftanın kaçıncı günü olduğunu soralım ve girilen rakama göre gün adını ekrana yazdıralım.

            //Console.WriteLine("Haftanın gün sayısı:");
            //int gun = Convert.ToInt32(Console.ReadLine());

            //switch (gun) // ==
            //{
            //    case 1:
            //        Console.WriteLine("Pazartesi");
            //        break;
            //    case 2:
            //        Console.WriteLine("Salı");
            //        break;
            //    case 3:
            //        Console.WriteLine("Çarşamba");
            //        break;
            //    case 4:
            //        Console.WriteLine("Perşembe");
            //        break;
            //    case 5:
            //        Console.WriteLine("Cuma");
            //        break;
            //    case 6:
            //        Console.WriteLine("Cumartesi");
            //        break;
            //    case 7:
            //        Console.WriteLine("Pazar");
            //        break;

            //    default: //else
            //        Console.WriteLine("Hafta 7 günden oluşur.!!!");
            //        break;
            //}

            #endregion

            #region Klavyeden iki sayı, bir işlem(+,-,*,/) girilecek. Sayılar girilen işleme göre sonucu ekrana yazdıran switch case.

            //Console.WriteLine("1.Sayıyı Giriniz");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("2.Sayıyı Giriniz");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("İşlem Seçiniz(+,-,*,/):");
            //string islem = Console.ReadLine();

            //switch (islem)
            //{
            //    case ("+"):
            //        Console.WriteLine(sayi1+sayi2);
            //        break;
            //    case ("-"):
            //        Console.WriteLine(sayi1 - sayi2);
            //        break;
            //    case ("*"):
            //        Console.WriteLine(sayi1 * sayi2);
            //        break;
            //    case "/":
            //        Console.WriteLine(sayi1 / sayi2);
            //        break;
            //    default:
            //        Console.WriteLine("Hatalı İşlem Seçimi!!");
            //        break;
            //}




            #endregion
            #region   
            /*
            kullanıcıdan alınan cinsiyet bilgisine göre
            ==> ERKEK ise
            yaşı 60 ve üstü ise maaşının 10 katı kadar ikramiye alaral emekli edilecek, yaş 60'ın altında ise çalıştığı gün sayısına göre eğer 6000 ve üstü ise maaşının 11 katı kadar ikramiye alarak emekli edilecek,    6000 altında ise emekli edilmeyecek bilgisi kullanıcıya gösterilecek
            ==> KADIN ise
             yaşı 58 ve üstü ise maaşının 10 katı kadar ikramiye alarak emekli edilecek, yaş 58'ın altında ise çalıştığı gün sayısına göre eğer 3600 ve üstü ise maaşının 11 katı kadar ikramiye alarak emekli edilecek, 3600 altında ise emekli edilmeyecek bilgisi kullanıcıya gösterilecek
            ==> cinsiyet bilgisi switch-case ile sorgulanacak
             */

            #endregion

            //Console.WriteLine("Cinsiyet:");
            //string cinsiyet = Console.ReadLine().ToUpper();

            //switch (cinsiyet)
            //{
            //    case "ERKEK":

            //        Console.WriteLine("Yaş:");
            //        int yas = Convert.ToInt32(Console.ReadLine());

            //        if (yas > 59)
            //        {
            //            Console.WriteLine("Maaş:");
            //            int maas = Convert.ToInt32(Console.ReadLine());
            //            Console.WriteLine("İkramiyeniz:" + (maas * 10));
            //        }
            //        else
            //        {
            //            Console.WriteLine("Prim Gününüz:");
            //            int prim = Convert.ToInt32(Console.ReadLine());
            //            if (prim >= 6000)
            //            {
            //                Console.WriteLine("Maaş:");
            //                int maas = Convert.ToInt32(Console.ReadLine());
            //                Console.WriteLine("İkramiyeniz:" + (maas * 11));
            //            }
            //            else
            //            {
            //                Console.WriteLine("Emeklilik hayal. WELCOME TO TURKEY");
            //            }
            //        }
            //        break;

            //    case "KADIN":

            //        Console.WriteLine("Yaş:");
            //        int age = Convert.ToInt32(Console.ReadLine());
            //        if (age > 57)
            //        {
            //            Console.WriteLine("Maaş:");
            //            int maas = Convert.ToInt32(Console.ReadLine());
            //            Console.WriteLine("İkramiyeniz:" + (maas * 10));
            //        }
            //        else
            //        {
            //            Console.WriteLine("Prim Gününüz:");
            //            int prim = Convert.ToInt32(Console.ReadLine());
            //            if (prim >= 3600)
            //            {
            //                Console.WriteLine("Maaş:");
            //                int maas = Convert.ToInt32(Console.ReadLine());
            //                Console.WriteLine("İkramiyeniz:" + (maas * 11));
            //            }
            //            else
            //            {
            //                Console.WriteLine("Emeklilik hayal. WELCOME TO TURKEY");
            //            }
            //        }


            //        break;
            //}
            #endregion

        }
    }
}
