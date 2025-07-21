using System.ComponentModel;
using System.Net.WebSockets;

namespace _07_Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            **** LOOPS:  ****
            *While:
            *For:
            *DoWhile:
            *Foreach:
            
             Belirli bir kod satırının istenilen kadar tekrar etmesini sağlar. 
             
             */

            #region ****** WHILE LOOP ******
            //1-10 a kadar olan sayıları alt alta ekrana yazdırınız

            //int sayi = 1;

            //while (sayi < 11)
            //{
            //    Console.WriteLine(sayi);
            //    sayi++;
            //}

            #region 200 ile 0 arasındaki sayılardan 3'e tam bölünenleri ekrana yazdırınız.

            //int i = 200;

            //while (i > 0)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }

            //    i--;
            //}


            #endregion


            #region 1-10 arasındaki sayıların toplamı
            //int i = 1;
            //int toplam = 0;


            //while (i < 11)
            //{
            //    toplam = toplam + i;
            //    i++;
            //}
            //Console.WriteLine("Toplam:"+toplam);
            #endregion



            #region 0 ile 500 arasındaki sayılardaki çift ve tek sayıların toplamlarını ayrı ayrı ekrana yazdırınız.

            //int s = 0;
            //int ciftToplam = 0;
            //int tekToplam = 0;

            //while (s < 500)
            //{
            //    if (s % 2 == 0)
            //    {
            //        ciftToplam += s;
            //    }
            //    else
            //    {
            //        tekToplam += s;
            //    }
            //    s++;
            //}

            //Console.WriteLine("Tek sayıların toplamı:"+tekToplam);
            //Console.WriteLine("Çift sayıların toplamı:"+ciftToplam);

            #endregion


            #region BREAK VE CONTINUE KOMUTLARI 

            //break: istenilen satırda döngünün bitmesini-kırılmasını sağlar.

            //continue: istenilen satırdan döngü koşuluna geri dönülmesini sağlar.

            //1-20 arasındaki sayıları toplayınız
            //7 sayısı toplama işleminde atlansın
            //sayı 15 olduğunda döngü bitsin

            //int i = 1;
            //int toplam=0;
            //while (i < 21)
            //{
            //    if (i == 7)
            //    {
            //        i++;
            //        continue;                   
            //    }

            //    if (i == 15)
            //    {
            //        Console.WriteLine("Toplam=" + toplam);
            //        break;
            //    }

            //    toplam += i; //toplam=toplam+i;
            //    i++;
            //}


            #endregion



            #region Kullanıcıdan 0 girilene kadar pozitif sayılar girmesi istensin. 
            //0 girilene kadar girilen pozitif sayılar toplansın ve ortalaması hesaplansın.
            // Kullanıcı 0 girdiğinde döngü bitsin ve toplam,ortalama ekrana yazdırılsın.
            // ** Kullanıcı ilk sayıyı 0 girerse tekrar sayı istensin
            // ** kullanıcı negatif sayı girerse "lütfen Pozitif Sayı Giriniz!!" uyarısını verilsin.


            //double toplam = 0;
            //int sayac = 0;
            //while (true)
            //{
            //    Console.WriteLine("Sayı giriniz:");
            //    int sayi = Convert.ToInt32(Console.ReadLine());

            //    if(sayi==0 && sayac == 0)
            //    {
            //        Console.WriteLine("Tekrar sayı giriniz");
            //        continue;
            //    }

            //    if (sayi == 0)
            //    {
            //        break;
            //    }

            //    else if (sayi < 0)
            //    {
            //        Console.WriteLine("Pozitif Sayı giriniz");
            //    }

            //    else
            //    {
            //        toplam += sayi;
            //        sayac++;
            //    }

            //}

            //Console.WriteLine("Toplam:"+toplam);
            //Console.WriteLine("Ortalama:"+(toplam/sayac));



            //Console.WriteLine("Sayı giriniz:");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //double toplam = 0;
            //int sayac = 0;

            //while (sayi != 0)
            //{
            //    while (sayi < 0)
            //    {
            //        Console.WriteLine("Pozitif sayı giriniz");
            //        sayi = Convert.ToInt32(Console.ReadLine());
            //    }

            //    toplam += sayi;
            //    sayac++;

            //    Console.WriteLine("Sayı giriniz:");
            //    sayi = Convert.ToInt32(Console.ReadLine());


            //}

            //Console.WriteLine("Toplam:"+toplam);
            //Console.WriteLine("Ortalama:"+(toplam/sayac));

            #endregion




            #endregion


            #region ****** FOR LOOP *******

            //1-10 arasında sayıları ekrana yazdırınız

            //int i = 1;
            //while (i < 11)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            /*
            0-Başla
            1-sayaç tanımlanır
            2-koşul kontrolü(sayaç<11) - True 3 False 5
            3-kod bloğu çalışır
            4-sayaç revize -> 2
            5-Bitir            
             
             */

            //for(int i=1; i<11; i++)
            //{
            //    Console.WriteLine(i);
            //}

            #region Kullanıcının girmiş olduğu ilk 5 pozitif sayıyı toplayınız.

            //int toplam = 0;

            //for (int i = 0; i < 5; i++) //i:0,1,2,3,4
            //{
            //    Console.WriteLine("Pozitif sayı giriniz:");
            //    int sayi = Convert.ToInt32(Console.ReadLine());

            //    if (sayi >= 0)
            //    {
            //        toplam += sayi;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Negatif girmeyiniz...");
            //        i--;
            //    }                
            //}

            //Console.WriteLine("Toplam="+toplam);



            //int toplam = 0;
            //int i = 0;
            //while (i < 5)
            //{
            //    Console.WriteLine("Pozitif sayı giriniz:");
            //    int sayi = Convert.ToInt32(Console.ReadLine());

            //    if (sayi >= 0)
            //    {
            //        toplam += sayi;
            //        i++;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Pozitif Giriniz!!");
            //    }

            //}

            #endregion


            #region Kullanıcıdan alınan başlangıç ve bitiş değerlerinin arasındaki sayılardan 3'ün katı olanları ekrana yazdıran For Loop

            //Console.WriteLine("Başlangıç değeri:");
            //int basla = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Bitiş değeri:");
            //int bitis = Convert.ToInt32(Console.ReadLine());

            //for (int i = basla; i < bitis; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            #endregion

            #region Kullanıcıdan alınan bir sayının faktöriyeli hesaplayan for döngüsünü yazınız.

            //5

            //1*2*3*4*5 = 120 5'in faktöriyeli

            //Console.WriteLine("Faktöriyel hesaplanacak Sayıyı Giriniz:");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //int fakt = 1; //çarpma işleminde 1 etkisiz elemandır.

            //for(int i=1; i<=sayi; i++)
            //{
            //    fakt = fakt * i;
            //}

            //Console.WriteLine("Faktöriyel:"+fakt);
            #endregion


            #region 1-500 arasındaki sayıların içinden 13 katlarının sayısını ve toplamlarını hesaplayınız

            //int toplam = 0;

            //for(int i=1; i<500; i++)
            //{
            //    if (i % 13 == 0)
            //    {
            //        Console.WriteLine(i);
            //        toplam += i;
            //    }
            //}

            //Console.WriteLine("Toplam:"+toplam);

            #endregion

            #region  PASCAL ÜÇGENİ
            /*
            
            *
            **
            ***
            ****
            *****
            ******           

            Console.Write()  // Yazdıktan sonra alt satıra geçmez
            Console.WriteLine()  // Yazdıktan sonra alt satıra geçer
             */

            //for(int i=1; i<7; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();

            //}



            #endregion

            #region KARE
            /*
             
            *********
            *       *
            *       *
            *       *
            *       *
            *       *
            *       *
            *       *
            *       *
            *********
               
             */

            //for (int i = 0; i <10; i++) //10 Adım
            //{
            //    if(i==0 || i == 9)
            //    {
            //        Console.WriteLine("**********");
            //    }
            //    else
            //    {
            //        Console.WriteLine("*        *");
            //    }
            //}


            #endregion

            #region Yılbaşı Ağacı
            /*             
                    *
                   ***
                  *****
                 *******
                *********
               ***********
              
             */

            //int bosluk = 5;

            //for (int yildizSayisi = 1; yildizSayisi < 15; yildizSayisi += 2)
            //{
            //    for (int k = bosluk; k >= 0; k--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int yildiz = yildizSayisi; yildiz > 0; yildiz--)
            //    {
            //        Console.Write("*");
            //    }
            //    bosluk--;
            //    Console.WriteLine();
            //}



            #endregion

            #region Ters Çam Ağacı
            /*
          *************
           ***********
            *********
             *******
              *****
               ***
                *

          */

            //int bosluk = 0;

            //for (int i = 15; i >0; i-=2)
            //{
            //    for (int j = 0; j < bosluk; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = i; k > 0; k--)
            //    {
            //        Console.Write("*");
            //    }
            //    bosluk++;
            //    Console.WriteLine();
            //}
            #endregion



            #region Çarpım Tablosu

            /*
             
            1*1=1  2*1=2 3*1=3 ...
            1*2=2
            1*3=3
            
             */

            //for (int i = 1; i < 11; i++)
            //{
            //    for (int j = 1; j < 11; j++)
            //    {
            //        Console.Write(j+"x"+i+"="+(i*j)+"\t");
            //    }
            //    Console.WriteLine();
            //}
            #endregion


            #region Kullanıcının girmiş olduğu sayının asal olup olmadığını ekrana yazdıran döngü.
            //Asal sayı 1 ve kendisi dışında hiç bir sayıya bölünmeyen sayıdır. 
            //1 ve altındaki sayılar asal değildir.
            //2 en küçük asal sayıdır.

            //Console.WriteLine("Bir sayı giriniz");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //bool asalMi = true; //Asal mı?

            //if (sayi <= 1)
            //{
            //    asalMi = false;
            //}
            //else if (sayi == 2)
            //{
            //    asalMi = true;
            //}
            //else
            //{
            //    for (int i = 2; i < sayi; i++) //i: Bölen  sayi=50
            //    {
            //        if (sayi % i == 0)
            //        {
            //            asalMi = false;
            //            break;
            //        }
            //    }
            //}

            //if (asalMi)
            //{
            //    Console.WriteLine("Asaldır");
            //}
            //else
            //{
            //    Console.WriteLine("Asal Değildir");
            //}


            #endregion

            #region 1 ile 1000000 arasındaki asal sayıları ekrana yazdıran döngü.

            for (int sayi = 1; sayi < 10000000; sayi++)
            {
                bool asalMi = true; //Asal mı?

                if (sayi <= 1)
                {
                    asalMi = false;
                }
                else if (sayi == 2)
                {
                    asalMi = true;
                }
                else
                {
                    for (int i = 2; i < sayi; i++) //i: Bölen  sayi=50
                    {
                        if (sayi % i == 0)
                        {
                            asalMi = false;
                            break;
                        }
                    }
                }

                if (asalMi)
                {
                    Console.WriteLine(sayi);
                }
            }

           
            #endregion


            #endregion


            #region ****** DO-WHILE ******

            //int i = 0;

            //while (i < 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}


            //int j = 0;
            //do
            //{

            //    Console.WriteLine(j);
            //    j++;

            //} while (j < 10);


            #region Kullanıcı 0 girene kadar girilen sayıları toplayarak ekrana yazdırınız.

            //int toplam = 0;
            //while (true)
            //{
            //    Console.WriteLine("Sayı giriniz:");
            //    int sayi = Convert.ToInt32(Console.ReadLine());

            //    if (sayi == 0)
            //        break;

            //    toplam += sayi;
            //}
            //Console.WriteLine("Toplam:"+toplam);





            //Console.WriteLine("Sayı giriniz:");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //int toplam = 0;

            //while (sayi != 0)
            //{
            //    toplam += sayi;

            //    Console.WriteLine("Sayı giriniz:");
            //    sayi = Convert.ToInt32(Console.ReadLine());
            //}

            //Console.WriteLine("Toplam:" + toplam);




            //int toplam = 0;
            //do
            //{
            //    Console.WriteLine("Sayı giriniz:");
            //    int sayi = Convert.ToInt32(Console.ReadLine());

            //    if(sayi==0)
            //        break;

            //    toplam += sayi;

            //} while (true);

            //Console.WriteLine("Toplam:" + toplam);




            //int sayi;
            //int toplam = 0;
            //do
            //{
            //    Console.WriteLine("Sayı giriniz:");
            //    sayi= Convert.ToInt32(Console.ReadLine());


            //    toplam += sayi;

            //} while (sayi!=0);

            //Console.WriteLine("Toplam:" + toplam);
            #endregion

            #endregion


        }
    }
}
