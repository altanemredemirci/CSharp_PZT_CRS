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





        }
    }
}
