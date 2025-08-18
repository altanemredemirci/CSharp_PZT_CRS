using System.Collections;
using System.Diagnostics.Metrics;
using System.Net.Http.Headers;

namespace _12_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  METOTLAR 
           *  Belirli işlemleri bir başlık altında tanımlayarak, ihtiyaç halinde başlık ile ulaşılan ve kullanılan yazılım yapılarıdır.
           *  Metotları () parantezleri temsil eder.
           *  Metotlar 2 ye ayrılır. 
              * Değer Döndüren(option parametre)
              * Değer Döndürmeyen(option parametre)
           * SOLID prensiblerinden ilki olan S — Single-responsibility principle : her metot bir iş için tasarlanmalıdır.

            */

            // ******* KURALLAR *******
            //* Metot içinde metot tanımlanmaz.
            //* - Aynı class altında metot tanımlanırsa {} kesişmemelidir. Kapsam alanları(SCOPE) birbiri içinde olmamalıdır.
            //* Metot ismi yaptığı işe uygun olmalıdır.
            //* Metotların isimleri UNIQUE(benzersiz) olmalıdır.
            //* Benzer işi yapacak metotlar METOT İMZASI(parametre sayısı, parametre veri tipi) denilen tanımlarla ayrışırlar.

            #region DATA ACCESS MODIFIER - Erişim Belirteci
            /*
            public: Bütün solution altında herkes erişilebilir.
            internal: Tanımlı olduğu proje içinde erişilebilir.
            private: Sadece kendi classı içinde erişilebilir.
             
             */
            #endregion


            #region DEĞER DÖNDÜRMEYEN METOTLAR

            //Komşu(Matematik) sınıfta bir toplama metodu bulunuyor. Bunu kendi sınıfımda kullanmak istiyorum.


            //Nonstatic Kullanım
            //Matematik mat = new Matematik();
            //mat.Toplama();

            #region Kullanıcının 4(+,-,*,/) işlem yapabileceği metotları Matematik isimli bir sınıf altında tanımlayınız.

            //Matematik sınıfı altındaki Toplama() metodu kullanımı

            //Matematik mat = new Matematik(); //Nonstatic Kullanım
            //mat.Toplama();


            //mat.Cikarma();


            //Static 
            //Matematik.Carpma();


            //Console.WriteLine("Lütfen işlem seçiniz(+,-,*,/):");
            //string islem = Console.ReadLine();

            //if (islem == "+")
            //{
            //    Matematik mat = new Matematik();
            //    mat.Toplama();
            //}

            //else if (islem == "-")
            //{
            //    Matematik mat = new Matematik();
            //    mat.Cikarma();
            //}

            //else if (islem == "*")
            //{
            //    Matematik.Carpma();
            //}

            //else if (islem == "/")
            //{
            //    Console.WriteLine("1.Sayıyı giriniz:");
            //    int sayi1 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("2.Sayıyı giriniz:");
            //    int sayi2 = Convert.ToInt32(Console.ReadLine());

            //    Matematik.Bolme(sayi1,sayi2);
            //}

            #endregion


            #region SORU1: kullanıcıdan alınacak 2 ürün fiyatından pahalı olana %30 indirim uygulayan metot 
            //ve 3.ürün almak isterse 3.ürüne %50 indirim uygulayarak metot ile kodlayınız


            //Indirim2();
            #endregion



            #endregion

            #region DEĞER DÖNDÜREN METOTLAR

            // void-değer döndürmeyen metotların aksine bu metotlar return keyword ile bize metodun işlem sonucu geri getirir. Yani metot çağrıldığı yere geri döndüğünde data getirir. Bunun amacı metot sonucunun programın akışında başka bir satırda kullanılmasını sağlamaktır.

            #region SORU2: kullanıcıdan alınacak 2 ürün fiyatından pahalı olana %30 indirim uygulayan metot 
            //ve 3.ürün almak isterse 3.ürüne %50 indirim uygulayarak metot ile kodlayınız


            //Indirim2();
            #endregion

            #region SORU3:Bir Arraylist deki en küçük ve en büyük sayıları bulun

            //Random r = new Random();

            //ArrayList sayilar = new ArrayList();

            //for (int i = 0; i < 20; i++)
            //{
            //    sayilar.Add(r.Next(1, 100));
            //}

            //foreach (int item in sayilar)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();

            //int enBuyuSayi = EnBuyukBul(sayilar);





            #endregion

            #region SORU4:Kullanıcıdan alınan aralıkta, kullanıcının istediği kadar rastgele sayı ile diziyi dolduran metot 

            //1.Yol 
            //Console.WriteLine("Kaç adet sayı olacak?");
            //int adet = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Başlangıç?");
            //int basla = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Bitiş?");
            //int bitis = Convert.ToInt32(Console.ReadLine());

            //int[] sayilar = new int[adet];

            //DiziDoldur(sayilar,adet,basla,bitis);

            //foreach (var item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}


            //2.YOL
            //DiziDoldurParametresiz();

            //3.YOL
            //int[] ints = DiziDoldurParametresizDonduren();
            //foreach (var item in DiziDoldurParametresizDonduren())
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region SORU5:Rastgele 1-100 arasında 15 değer tutan bir dizideki tek ve çiftleri ayrı ayrı dizilere atayan metot 

            int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            int[] ciftsayilar = new int[10];
            int[] teksayilar = new int[10];

            TekCiftKontrol(sayilar, teksayilar, ciftsayilar);

            foreach (var item in teksayilar)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
            foreach (var item in ciftsayilar)
            {
                Console.Write(item + " ");
            }

            #endregion

            #endregion





        }


        #region CEVAP1:

        //static void Indirim2()
        //{
        //    Console.WriteLine("1.Ürün Fiyatı:");
        //    double fiyat1 = Convert.ToDouble(Console.ReadLine());
        //    Console.WriteLine("2.Ürün Fiyatı:");
        //    double fiyat2 = Convert.ToDouble(Console.ReadLine());

        //    if (fiyat1 > fiyat2)
        //        fiyat1 = fiyat1 * 0.70; //%30 indirim
        //    else
        //        fiyat2 = fiyat2 * 0.70;

        //    Console.WriteLine("3. ürünü %50 indirimli almak ister misiniz?(E/H)");
        //    string cevap = Console.ReadLine().ToUpper();

        //    if (cevap == "E")
        //    {
        //        Indirim3(fiyat1,fiyat2);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Ödemeniz:"+(fiyat1+fiyat2));
        //    }

        //}
        //static void Indirim3(double f1,double f2)
        //{
        //    Console.WriteLine("3.Ürün Fiyatı:");
        //    double fiyat3 = Convert.ToDouble(Console.ReadLine());

        //    fiyat3 = fiyat3 / 2;

        //    Console.WriteLine("Ödemeniz:"+(f1+f2+fiyat3));
        //}



        #endregion

        #region CEVAP2:
        //static void Indirim2()
        //{
        //    Console.WriteLine("1.Ürün Fiyatı:");
        //    double fiyat1 = Convert.ToDouble(Console.ReadLine());
        //    Console.WriteLine("2.Ürün Fiyatı:");
        //    double fiyat2 = Convert.ToDouble(Console.ReadLine());

        //    if (fiyat1 > fiyat2)
        //        fiyat1 = fiyat1 * 0.70; //%30 indirim
        //    else
        //        fiyat2 = fiyat2 * 0.70;

        //    Console.WriteLine("3. ürünü %50 indirimli almak ister misiniz?(E/H)");
        //    string cevap = Console.ReadLine().ToUpper();

        //    double fiyat3 = 0;
        //    if (cevap == "E")
        //    {
        //        fiyat3 = Indirim3();
        //    }
        //    Console.WriteLine("Ödemeniz:" + (fiyat3 + fiyat2 + fiyat1));


        //    if (cevap == "E")
        //    {
        //        double fiyat3 = Indirim3();
        //        Console.WriteLine("Ödemeniz:" + (fiyat3 + fiyat2 + fiyat1));
        //    }
        //    else
        //    {
        //        Console.WriteLine("Ödemeniz:" + (fiyat2 + fiyat1));
        //    }



        //}
        //static double Indirim3()
        //{
        //    Console.WriteLine("3.Ürün Fiyatı:");
        //    double fiyat3 = Convert.ToDouble(Console.ReadLine());

        //    fiyat3 = fiyat3 / 2;

        //    return fiyat3;
        //}

        #endregion

        #region CEVAP3:

        //static int EnBuyukBul(ArrayList list)
        //{
        //    int buyuk = 0;
        //    foreach (int item in list)
        //    {
        //        if (item > buyuk)
        //        {
        //            buyuk = item;
        //        }
        //    }

        //    return buyuk;
        //}


        #endregion

        #region CEVAP4:

        static void DiziDoldur(int[] dizi,int adet,int basla, int bitis)
        {
            Random r = new Random();

            for (int i = 0; i < adet; i++)
            {
                dizi[i] = r.Next(basla, bitis);
            }
        }

        static void DiziDoldurParametresiz()
        {
            Console.WriteLine("Kaç adet sayı olacak?");
            int adet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Başlangıç?");
            int basla = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bitiş?");
            int bitis = Convert.ToInt32(Console.ReadLine());

            int[] sayilar = new int[adet];

            Random r = new Random();

            for (int i = 0; i < adet; i++)
            {
                sayilar[i] = r.Next(basla, bitis);
            }

            foreach (var item in sayilar)
            {
                Console.WriteLine(item);
            }
        }
       
        static int[] DiziDoldurParametresizDonduren()
        {
            Console.WriteLine("Kaç adet sayı olacak?");
            int adet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Başlangıç?");
            int basla = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bitiş?");
            int bitis = Convert.ToInt32(Console.ReadLine());

            int[] sayilar = new int[adet];

            Random r = new Random();

            for (int i = 0; i < adet; i++)
            {
                sayilar[i] = r.Next(basla, bitis);
            }

            return sayilar;
        }

        #endregion

        #region CEVAP5:
        static void TekCiftKontrol(int[] list, int[] tlist, int[] clist)
        {
            int index = 0;
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] % 2 == 0)
                {
                    clist[index] = list[i];
                    index++;
                }
            }

            int index2 = 0;
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] % 2 != 0)
                {
                    tlist[index2] = list[i];
                    index2++;
                }
            }
        }

        #endregion
    }

    //public class Matematik //classa erişim belirteci verilmez ise default INTERNAL alır.
    //{

    //    //Static:
    //    //NonStatic: Classtan bir örneklem(instance) alınmalıdır.
    //    internal void Toplama() //class içerisinde tanımlı değişken veya metotlara erişim belirteci verilmez ise default PRIVATE alır.
    //    {
    //        int sayi = 10;
    //        int sayi2 = 20;
    //        int toplam = sayi + sayi2;
    //        Console.WriteLine("Toplama Sonucu:" + toplam);
    //    }
    //}
}
