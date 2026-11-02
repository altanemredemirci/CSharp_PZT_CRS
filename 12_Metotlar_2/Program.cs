using _12_Metotlar_3;

namespace _12_Metotlar_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan 2 sayı bir işlem alarak dört işlem gerçekleştiren ve sonucu ekrana yazdıran metodu tanımlayınız.

            Hesapla();

            Console.WriteLine("1.Sayı:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Sayı:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İşlem Giriniz:(+,-,*,/)");
            string islem = Console.ReadLine();

            if (islem == "+") { Toplama(sayi1, sayi2); }
            else if (islem == "-") { Cikarma(sayi1, sayi2); }
            else if (islem == "*") { Carpma(sayi1, sayi2); }
            else if (islem == "/") { Bolme(sayi1, sayi2); }
            else
            {
                Console.WriteLine("Hatalı İşlem Seçimi!!");
            }


            DortIslem();

            //Matematik.Hesapla();
        }

        static void Hesapla() //Parametresiz Değer Döndürmeyen Metot
        {
            Console.WriteLine("1.Sayı:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Sayı:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İşlem Giriniz:(+,-,*,/)");
            string islem = Console.ReadLine();

            if (islem == "+") { Console.WriteLine(sayi1+sayi2); }
            else if (islem == "-") { Console.WriteLine(sayi1-sayi2); }
            else if (islem == "*") { Console.WriteLine(sayi1*sayi2); }
            else if (islem == "/") { Console.WriteLine(sayi1/sayi2); }
            else
            {
                Console.WriteLine("Hatalı İşlem Seçimi!!");
            }
        }


        static void DortIslem() //Parametresiz Değer Döndürmeyen Metot
        {
            Console.WriteLine("1.Sayı:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Sayı:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İşlem Giriniz:(+,-,*,/)");
            string islem = Console.ReadLine();

            if (islem == "+") { Toplama(sayi1, sayi2); }
            else if (islem == "-") { Cikarma(sayi1, sayi2); }
            else if (islem == "*") { Carpma(sayi1, sayi2); }
            else if (islem == "/") { Bolme(sayi1, sayi2); }
            else
            {
                Console.WriteLine("Hatalı İşlem Seçimi!!");
            }
        }


        static void Toplama(int s1,int s2)
        {
            Console.WriteLine(s1 + s2);
        }
        static void Cikarma(int s1, int s2)
        {
            Console.WriteLine(s1 - s2);
        }
        static void Carpma(int s1, int s2)
        {
            Console.WriteLine(s1 * s2);
        }
        static void Bolme(int s1, int s2)
        {
            Console.WriteLine(s1 / s2);
        }
    }
}
