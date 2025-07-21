using System;

namespace _10_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int vize1 = 50; //Değişkenler tek data tutarlar.

            //int vize2 = 70;

            //string meyve = "Elma";
            //string meyve2 = "Armut";
            //string meyve3 = "Karpuz";

            //Birden fazla veriyi bir tanım altında tutmak için KOLEKSİYONLAR kullanılır.

            #region **** ARRAYS - DİZİLER ****
            //Bir dizi tanımlanırken veritipi ve kaç değer tutacağı bilgilerinin tanımlaması zorunludur.
            //Diziler birden fazla değeri barındırdıkları için bu değerleri INDEX adı verilene, 0 dan başlarak 1'er 1'er artan numaralandırma yöntemi ile tutarlar.



            ////Dolu Dizi Tanımı
            //int[] sayilar = { 50, 70, 90 };

            ////Dizi Değerine Ulaşma
            //Console.WriteLine(sayilar[1]);


            #region Boş Dizi Tanımı


            //string[] meyveler = new string[5];  // new vertipi[kapasitesi]

            ////Diziye Eleman Ekleme
            //meyveler[0] = "Elma";
            //meyveler[1] = "Armut";
            //meyveler[3] = "Karpuz";

            //meyveler[5] = "Ejder Meyvesi"; //System.IndexOutOfRangeException
            #endregion

            #region İstenilen Index'e Eleman Ekleme

            //int[] sayilar = { 50, 70, 90,34,12,67 };

            //sayilar[2] = 45;

            //sayilar[6] = 100;

            #endregion

            #region Dizi Yazdırma
            //int[] sayilar = { 50, 70, 90, 34, 12, 67 };

            //for (int i = 0; i < 6; i++)
            //{
            //    Console.WriteLine(sayilar[i]);
            //}

            #endregion

            #region Kullanıcıdan bir dizinin kapasitesini alınız. Verilen kapasite kadar değeri kullanıcıdan isteyerek diziyi doldurunuz. Dizi dolduğunda ekrana yazdırınız.

            //Console.WriteLine("Dizi kapasitesi ?");
            //int boyut = Convert.ToInt32(Console.ReadLine());

            //int[] sayilar = new int[boyut];

            //for (int i = 0; i < boyut; i++)
            //{
            //    Console.WriteLine("Sayı giriniz:");
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //    sayilar[i] = sayi;
            //}

            //Console.WriteLine(" ----- Dizi Elemanları -----");
            //for (int i = 0; i < boyut; i++)
            //{
            //    Console.WriteLine(sayilar[i]);
            //}

            #endregion

            #region İşverene kaç personeliniz var? sorusunu soralım ve personel isimlerini girmesini isteyelim.

            Console.WriteLine("Personel Sayınız:");
            int personelSayisi = Convert.ToInt32(Console.ReadLine());

            string[] personeller = new string[personelSayisi];

            int i = 0;

            while (i < personelSayisi)
            {
                Console.WriteLine("Personelin Adı:");
                personeller[i] = Console.ReadLine();

                i++;
            }



            #endregion

            #endregion
        }
    }
}
