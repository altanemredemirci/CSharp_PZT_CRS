namespace _12_Methods
{
    internal class Program
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


            //Kullanıcıdan alınan sayıları toplayan işlem
            //Console.WriteLine("1.sayı:");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("2.sayı:");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Toplam:"+(sayi1+sayi2));


            //Toplam();
            //Console.WriteLine("Selam");
            //Toplam();

            //Console.WriteLine("Ürünlerde indirim var");
            //Toplam();


            int toplam= Toplam();

            Console.WriteLine(toplam);
        }

        //static void Toplam()
        //{
        //    Console.WriteLine("1.sayı:");
        //    int sayi1 = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine("2.sayı:");
        //    int sayi2 = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine("Toplam:" + (sayi1 + sayi2));
        //}


        static int Toplam()
        {
            Console.WriteLine("1.sayı:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2.sayı:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

           return sayi1 + sayi2;
        }

    }
}
