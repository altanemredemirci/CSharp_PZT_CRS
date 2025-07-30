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

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.WriteLine(sayilar[i]);
            //}

            //int i = 0;

            //while (i < sayilar.Length)
            //{
            //    Console.WriteLine(sayilar[i]);
            //    i++;
            //}


            //FOREACH
            //foreach(int sayi in sayilar)
            //{
            //    Console.WriteLine(sayi);
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

            //Console.WriteLine("Personel Sayınız:");
            //int personelSayisi = Convert.ToInt32(Console.ReadLine());

            //string[] personeller = new string[personelSayisi];

            //int i = 0;

            //while (i < personelSayisi)
            //{
            //    Console.WriteLine("Personelin Adı:");
            //    personeller[i] = Console.ReadLine();

            //    i++;
            //}



            #endregion




            #endregion

            #region ARRAY SINIFININ METOTLARI

            #region Clear

            //int[] sayilar = { 11, 22, 33, 44, 55 };

            //Array.Clear(sayilar); //Tüm elemanları siler.

            //Array.Clear(sayilar, 1, 2);


            //Array.Clear(sayilar, 1, sayilar.Length-1);

            //foreach (int item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region Copy()
            // Belirli bir koleksiyondan bir diğer koleksiyona istenilen elemanları KOPYALAR.

            //int[] sayilar = { 11, 22, 33, 44, 55 };

            //int[] copySayilar = new int[10];

            ////Array.Copy(sayilar, copySayilar, 2);

            //Array.Copy(sayilar, 1, copySayilar, 3, 2);


            //foreach (int item in copySayilar)
            //{
            //    Console.WriteLine(item);
            //}



            #endregion

            #region IndexOf()

            //string[] adlar = { "Mehmet", "Ercan", "Bahir", "Arhan", "Bahir", "Koray", "Altan","Bahir", "Fatma","Bahir","Uras" };

            //int indexNo = Array.IndexOf(adlar, "Bahir"); //Birden fazla var ise ilk bulduğunu değerin Index ini verir.
            //int indexNo = Array.IndexOf(adlar, "Barış"); //Bulunmayan bir değer için -1 döndürür.
            //Console.WriteLine(indexNo);
            //Console.WriteLine(Array.IndexOf(adlar, "Bahir", 3));


            #region Bütün Bahir isimlerinin Index değerlerini ekrana yazdıran kodu yazınız

            //for (int i = 0; i < adlar.Length; i++)
            //{
            //    if (adlar[i]=="Bahir")
            //        Console.WriteLine(i);
            //}


            //int i = 0;

            //while (i < adlar.Length)
            //{
            //    i = Array.IndexOf(adlar, "Bahir", i);

            //    if (i == -1)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(i);
            //    i++;
            //}


            //for (int i = 0; i < adlar.Length; i++)
            //{
            //    i = Array.IndexOf(adlar, "Bahir", i);

            //    if (i == -1)
            //        break;
            //    Console.WriteLine(i);
            //}






            #endregion
            #endregion

            #region LastIndexOf
            //string[] adlar = { "Mehmet", "Ercan", "Bahir", "Arhan", "Bahir", "Koray", "Altan", "Fatma", "Bahir" };

            //Console.WriteLine(Array.LastIndexOf(adlar,"Bahir"));


            #endregion

            #region Sort()
            // Dizinin elemanlarını 0->9 A->Z ye sıralar.
            //int[] sayilar = { 11, 2, 54, 3, 4,4, 1, 34, 23, 14 };

            //string[] sehirler = { "Mardin","Hatay", "Adana", "Zonguldak", "Adıyaman", "İzmir", "Çanakkale", "İstanbul" };


            //Array.Sort(sehirler);

            //foreach (string item in sehirler)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Reverse
            //string[] sehirler = { "Mardin", "Hatay", "Adana", "Zonguldak", "Adıyaman", "İzmir", "Çanakkale", "İstanbul" };


            //Array.Sort(sehirler);
            //Array.Reverse(sehirler);

            //foreach (string item in sehirler)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region ReSize

            //int[] sayilar = new int[4];
            //sayilar[0] = 11;
            //sayilar[1] = 12;
            //sayilar[2] = 13;
            //sayilar[3] = 14;

            //Array.Resize(ref sayilar, 6);
            //sayilar[4] = 15;

            #endregion


            #endregion

            #region İSTANBUL kelimesinin harflerini alt alta ekrana yazdırınız.
            //string sehir = "İSTANBUL";

            //for (int i = 0; i < sehir.Length; i++)
            //{
            //    Console.WriteLine(sehir[i]);
            //}

            //foreach (char item in sehir)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region Bir dizinin eleman sayısı 10 ile 20 arasında olacak şekilde sistem tarafında otomatik atılmaktadır.
            //Bu dizinin elemanlarını da sistem 0,100 arasında otomatik atmaktadır.
            //Otomatik oluşturulan bu dizinin eleman sayısını ve elemanlarını kullanıcıya gösteriniz
            //Aynı sayılar tekrar atanmayacak
            //Dizideki en büyük ve en küçük sayılar sort() kullanılmadan bulup ekrana yazdırılacak 

            Random r = new Random();
            int boyut = r.Next(10, 20);

            int[] sayilar = new int[boyut];

            //int i = 0;
            //while (i < boyut)
            //{
            //    int rast = r.Next(0, 20);

            //    if (sayilar.Contains(rast) == false)
            //    {
            //        sayilar[i] = rast;
            //        i++;
            //    }
            //}

            for (int i = 0; i < boyut; i++)
            {
                while (true)
                {
                    int rast = r.Next(0, 20);

                    if (sayilar.Contains(rast) == false)
                    {
                        sayilar[i] = rast;
                        break;
                    }
                }            

            }




            Console.WriteLine("Dizinin Boyutu:" + boyut);
            foreach (int item in sayilar)
            {
                Console.Write(item + " ");
            }

            #endregion
        }
    }
}
