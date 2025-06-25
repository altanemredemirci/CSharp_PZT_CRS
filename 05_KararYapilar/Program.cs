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

            double fiyat = 1000;

            fiyat = fiyat * 0.75;

            Console.WriteLine(fiyat);
            #endregion

            #region Aylık geliri 40000 üstünde ise %12 vergi kesilecek,
            // 40000 ve altında ise %9 vergi kesimi yapılarak 
            // kullanıcıya yeni gelirini bu hesaplamalar sonucunda gösteriniz
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

            #endregion
            
            #region  1-50 arasındaki sayıların içinde 7'e tam bölünenleri ekrana teker teker yazdırınız.
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

            #endregion


        }
    }
}
