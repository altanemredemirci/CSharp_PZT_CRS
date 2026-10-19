namespace _08_Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Döngüler: Belirli bir işlemi veya işlem kodunu tekrarlı çalıştırmayı sağlar. Bir koşula bağlı olarak(koşul true olduğu sürece) kod bloğunu tekrar tekrar çalıştırır.

            //1-10 aralığındaki sayıları alt alta ekrana yazdırınız.

            //Console.WriteLine(1);
            //Console.WriteLine(2);
            //Console.WriteLine(3);

            #region ******** WHILE ************

            //int i = 1;

            //while (i < 11)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            #region 250-50 aralığındaki sayıları ekrana yazdırınız.

            //int i = 250;

            //while (i >= 50)
            //{
            //    Console.WriteLine(i);
            //    i--;
            //}
            #endregion

            #region 250-50 aralığındaki 3'ün katı olan sayıları ekrana yazdırınız.

            //int i = 250;

            //while (i >= 50)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i--;
            //}


            #endregion

            #region 1-10 aralığındaki sayıların toplamını ekrana yazdırınız.

            //int i = 1;

            ////0 toplama işleminde etkisiz elemandır.Başlangıç değeri verilmezse ilk sayının toplanmasında hata alırız.
            //int toplam = 0; 

            //while (i < 11)
            //{
            //    toplam = toplam + i; //toplam+=i;
            //    i++;
            //}

            //Console.WriteLine("Toplam:"+toplam);

            #endregion

            #region 1-100 aralığındaki tek sayı ayrı çift sayıları ayrı toplayarak ekrana yazdırınız.

            //int i = 1;
            //int tekToplam = 0;
            //int ciftToplam = 0;

            //while (i <= 100)
            //{
            //    if (i % 2 == 0)
            //    {
            //        ciftToplam += i;
            //    }
            //    else
            //    {
            //        tekToplam += i;
            //    }

            //    i++;
            //}

            //Console.WriteLine("Tek sayıların toplamı  " + tekToplam);
            //Console.WriteLine("Çift sayıların toplamı " + ciftToplam);


            #endregion

            #region BREAK ve CONTINUE

            //break: Döngünün koşul dışında bir sebepten kırılmasını/durmasını istiyorsak kullanılır.

            //int i = 1;

            //while (i < 11)
            //{
            //    Console.WriteLine(i);
            //    if (i == 7)
            //    {
            //        break; //Kendi içinde bulunduğu döngüyü bitirir.
            //    }
            //    i++;
            //}

            //continue: Döngü continue komutunu okuduğu satırdan koşul satırına geri döner.

            //int i = 1;

            //while (i < 11)
            //{               
            //    if (i == 7)
            //    {
            //        i++;
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //    i++;
            //}


            #endregion

            #region SONSUZ DÖNGÜ

            //while(1==1)

            //while (true)
            //{
            //    Console.WriteLine("Bir sayı giriniz:");
            //    int sayi = Convert.ToInt32(Console.ReadLine());

            //    if (sayi == 0)
            //    {
            //        break;
            //    }

            //    Console.WriteLine(sayi);
            //}

            #endregion

            #region 1-100 aralığındaki sayıların toplamını ekrana yazdırınız
            //sayı 7'nin katı ise toplama dahil edilmesin,
            //sayının 3 katının 7 fazlası 37'in katı ise toplama işlemi bitsin

            //int toplam = 0;
            //int i = 1;

            //while (i < 100)
            //{
            //    if (i % 7 == 0)
            //    {
            //        i++;
            //        continue;
            //    }
            //    if (((i * 3) + 7) % 37 == 0)
            //    {
            //        Console.WriteLine("Sonuç:" + toplam);
            //        break;
            //    }

            //    toplam += i;
            //    i++;
            //}
            //Console.WriteLine("Sonuç:"+toplam);


            #endregion

            #region Kullanıcıdan 0 girilene kadar pozitif sayılar girmesini isteyin
            //0 girilene kadar girilen pozitif sayılar toplansın ve ortalaması hesaplasın
            //Kullanıcı 0 girdiğinde döngü bitsin ve toplam,ortalama ekrana yazdırılsın
            //**kullanıcı negatif sayı girdiğinde "Lütfen pozitif sayı giriniz" uyarısı verilsin


            //int toplamlar = 0;
            //int sayac = 0;

            //while (true)
            //{
            //    Console.WriteLine("Sayı:");
            //    int i = Convert.ToInt32(Console.ReadLine());

            //    if (i == 0)
            //    {
            //        Console.WriteLine(toplamlar);
            //        Console.WriteLine("Ort: " + (toplamlar / sayac));
            //        break;
            //    }

            //    else if (i < 0)
            //    {
            //        Console.WriteLine("Lütfen pozitif sayı giriniz.");
            //    }

            //    else
            //    {
            //        toplamlar += i;
            //        sayac += 1;
            //    }
            //}


            #endregion




            #endregion

            #region ********** FOR **********

            //int i = 0;

            //while (i < 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //for(int i=0; i<10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            #region Başlangıç ve bitiş değerini kullanıcıdan aldığınız ve aralıktaki sayıları ekrana yazdırdığınız for döngüsüni yazınız.

            //Console.WriteLine("Başlangıc: ");
            //int baslangic = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Bitis: ");
            //int bitis = Convert.ToInt32(Console.ReadLine());

            //if (baslangic > bitis)
            //{
            //    int temp = baslangic;
            //    baslangic = bitis;
            //    bitis = temp;
            //}

            //for (int i = baslangic; i <= bitis; i++)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion
            #region Kullanıcının girmiş olduğu sayının faktöriyelinin hesaplayan for döngüsünü yazınız

            //5 => 1*2*3*4*5=120

            //Console.WriteLine("sayi : ");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //int faktoriyel = 1;

            //for (int i = 1; i <= sayi; i++)
            //{
            //    faktoriyel = faktoriyel * i;
            //}

            //Console.WriteLine(faktoriyel);

            #endregion

            #region 1-500 aralığındaki 13'ün katı olan kaç adet sayı vardır ve toplamları nedir?

            //int toplam = 0;
            //int sayac = 0;

            //for (int i = 1; i <= 500; i++)
            //{
            //    if (i % 13 == 0)
            //    {
            //        sayac++;
            //        toplam += i;
            //    }

            //}

            //Console.WriteLine(sayac);
            //Console.WriteLine(toplam);


            #endregion


            #endregion

            #region ******** RANDOM ********

            //Belirtilen aralıkta rastgele int tipinde sayı üretir.

            //Random r = new Random(); //Random classından bir nesne (örneklem) üretildi.

            //int rastgele = r.Next();

            //int rastgele = r.Next(100);

            //int rastgele = r.Next(5,10);


            //Console.WriteLine(rastgele);

            #region Bilgisayar 1-100 aralığında bir rastgele sayı üretsin. Kullanıcı 5 hak da bu sayıyı tahmin etmeye çalışsın. Bu haklarda "Lütfen tahmininizi büyültünüz" veya "Lütfen tahmininizi küçültünüz" gibi yönlendirmeler yapılsın. 5 hakkı bittiğinde "Hakkınız Bitti" mesajını yazdırılsın.

            //Random r = new Random();
            //int rastgele = r.Next(1, 100);
            //Console.WriteLine(rastgele);

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("tahmin:");
            //    int tahmin = Convert.ToInt32(Console.ReadLine());

            //    if (tahmin == rastgele)
            //    {
            //        Console.WriteLine("OLLEY BİLDİNİZ");
            //        break;
            //    }

            //    else if (i == 4)
            //    {
            //        Console.WriteLine("Hakkınız bitti maalesef ");
            //    }

            //    else if (tahmin < rastgele)
            //    {
            //        Console.WriteLine("Lütfen tahmininizi büyütün ");
            //    }

            //    else
            //    {
            //        Console.WriteLine("Lütfen tahmininizi küçültün");
            //    }              

            //}


            #endregion



            #endregion


            #region Aşağıdaki şekilleri for döngüsü ile oluşturunuz

            /*
             
            *
            **
            ***
            ****
            *****
            ******
            *******
            */

            //for (int i = 1; i < 8; i++)
            //{
            //    for (int j = i; j >0 ; j--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}




            /*
            *****************
            *               *
            *               *
            *               *
            *               *
            *               *
            *****************
            */

            //for (int i = 0; i < 7; i++)
            //{
            //    if (i == 0 || i == 6)
            //    {
            //        Console.WriteLine("****************");
            //    }
            //    else
            //    {
            //        Console.WriteLine("*              *");
            //    }
            //}



            /*


                    *
                   ***
                  *****
                 *******
                *********
               ***********          
             */
            //int bosluk = 10;

            //for (int i = 1; i < 12; i+=2)
            //{
            //    for (int j = 0; j < bosluk; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int yildiz = 0; yildiz < i; yildiz++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //    bosluk--;
            //}





            /*


               ***********
                *********
                 *******
                  *****
                   ***                
                    *
                   ***
                  *****
                 *******
                *********
               ***********          


             
             */
            //int bosluk2 = 0;

            //for (int i = 13; i >0; i -= 2)
            //{
            //    for (int j = bosluk2; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int yildiz = i; yildiz > 0; yildiz--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //    bosluk2++;
            //}

            //int bosluk = 6;

            //for (int i = 1; i < 12; i += 2)
            //{
            //    for (int j = 0; j < bosluk; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int yildiz = 0; yildiz < i; yildiz++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //    bosluk--;
            //}



            int toplamSatir = 12;
            for (int satir = 0; satir <= toplamSatir; satir++)
            {
                int bosluk, yildiz;

                if (satir < 7)
                {
                    bosluk = satir;
                    yildiz = 13 - (2 * satir);
                }
                else
                {
                    bosluk = 12 - satir;
                    yildiz = (2 * (satir - 6)) + 1;
                }

                for (int i = 0; i < bosluk; i++)
                {
                    Console.Write(" ");
                }
                for (int i = 0; i < yildiz; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }



            /*
             
             1x1=1  2x1=2  .... ....  10x1=10
             1x2=2  2x2=4
             ..
            ...
            ..
             1x10=10          



             */



            #endregion

        }
    }
}
