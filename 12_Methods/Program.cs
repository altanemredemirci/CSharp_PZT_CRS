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


            Console.WriteLine("Lütfen işlem seçiniz(+,-,*,/):");
            string islem = Console.ReadLine();

            if (islem == "+")
            {
                Matematik mat = new Matematik();
                mat.Toplama();
            }

            else if (islem == "-")
            {
                Matematik mat = new Matematik();
                mat.Cikarma();
            }

            else if (islem == "*")
            {
                Matematik.Carpma();
            }

            else if (islem == "/")
            {
                Console.WriteLine("1.Sayıyı giriniz:");
                int sayi1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("2.Sayıyı giriniz:");
                int sayi2 = Convert.ToInt32(Console.ReadLine());

                Matematik.Bolme(sayi1,sayi2);
            }

            #endregion


            #endregion

        }



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
