using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _02_Degiskenler_VeriTipleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region DEĞİŞKENLER
            //Değişkenler - Variables : Yazılım içerisinde değer tanımlama, değeri taşıma ve kullanma işlemleri için kullanılan yapılardır.

            //Değişken Tanımlama : veritipi değişkenadı = değer

            //Değişken İsimlendirme Kuralları
            /*
             * yanlışlar: 5sayi, ?sayi, sayi!, ad soyad, 
             * doğrular : sayi5, _sayi, sayi_, ad_soyad, adsoyad
             ** Yazılım dillerinde kabul edilen tek özel karakter _ alt çizgilidir.
             
            -- Case Sensitive
            UpperCase : ADSOYAD
            LowerCase: adsoyad
            PascalCase: AdSoyad
            CamelCase: adSoyad
            SnakeCase: ad_soyad
            KebabCase: ad-soyad
            

            string isim = "Altan Emre";

            Console.WriteLine(isim);

            int sayi = 10;
            Console.WriteLine(sayi);
             */
            #endregion


            #region VERİ TİPLERİ
            //Veri tipi: Oluşturulan veya orataya çıkan değerin sayısal mı(ondalıklı, tam sayı) sözel mi olsuğu belirlediğimiz yapılara veri tipi denir.

            /*
             SAYISAL VERİ TİPLERİ: Sayısal değerleri tanımlayan veri tipidir.
                Tam Sayı:byte,sbyte,short,ushort,int,uint,long,ulong
                
                Ondalıklı Sayı: float, double

                DECIMAL: decimal
                
              int sayi = 12;
            long tc = 122323123213123;

            Console.WriteLine(sayi);

            double yas = 10.5;
            float yas2 = 55.5f;

            decimal sayi2 = 15;
            decimal sayi3 = 45.5M;

            Console.WriteLine(yas2);


             SÖZEL VERİ TİPLERİ(STRING):
                *char: Tek karakter tutan veri tipidir. ' tek tırnak ile tanımlanır.
                *string: Belirli bir boyutu-sınırı olmayan bir sözel veri tipidir. " " çift tırnak içerisine değer tanımlanır.
             

            //char k = 'A';
            //char l = '?';
            //char n = '1';

            //string ad = "Altan Emre"; 
            //string soyad = "Demirci";


            //string sayi = "5";
            //string sayi2 = "5";
            ////Console.WriteLine(sayi+sayi2); //Concat-Birleştirme

            //int sayi3 = 10;
            //Console.WriteLine(sayi2+sayi3);

            //int sayi = 10;
            //double sayi2 = 10;

            //double toplam = sayi + sayi2;


            //int sayi = 10;
            //double sayi2 = 3;
            //double sonuc = sayi / sayi2;

            //Console.WriteLine(sonuc);

            MANTIKSAL VERİ TİPİ(BOOLEAN):
                bool: Bir karşılaştırma sonucu true veya false olarak tutmamızı sağlar.

            */

            //bool sonuc = 5 > 3;

            //Console.WriteLine(sonuc);

            #endregion


            #region SCOPE - KAPSAM

            //{
            //    int sayi = 5;
            //    Console.WriteLine(sayi);
            //}
            //Console.WriteLine(sayi); //Kapsam dışı olması sebebiyle sayi değişkenini kullanılamaz



            //{
            //    int a=10;
            //    {
            //        Console.WriteLine(a);
            //    }
            //}

            //Console.WriteLine(a);
            #endregion


            //int sayi = 10;
            ////int sayi = 20; //Daha önce aynı isimle tanımlanan bir değişken vardır. Değişken isimleeri unique - BENZERSİZ olmalıdır.

            //sayi = 20; //Tanımlı değişkenin değeri revize edildi.

            //const string ad = "Ömer";

            //ad = "Hamza"; //Constant - Sabit değişken tanımlama

        }
    }
}
