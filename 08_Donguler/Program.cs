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

            Console.WriteLine("Başlangıc: ");
            int baslangic = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Bitis: ");
            int bitis = Convert.ToInt32(Console.ReadLine());

            if (baslangic > bitis)
            {
                int temp = baslangic;
                baslangic = bitis;
                bitis = temp;
            }

            for (int i = baslangic; i <= bitis; i++)
            {
                Console.WriteLine(i);
            }

            #endregion


            #endregion
        }
    }
}
