namespace _12_Metotlar_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DortIslem.Hesapla();

            Matematik.Hesapla();
        }
    }

    class DortIslem //Classa bir erişim belirteci tanımlanmazsa default internal alır.
    {
        //DATA ACCESS MODIFIER - Erişim Belirteci
        /*
         public: Bütün Solution altındaki projeler erişebilir
         internal: Kendi projesi altındaki bütün dosyalar erişebilir.
         private: Kendi classı içinde erişilebilir.
         
         */

        //Metoda bir erişim belirteci tanımlanmazsa default private alır.
        internal static void Hesapla() //Parametresiz Değer Döndürmeyen Metot
        {
            Console.WriteLine("1.Sayı:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Sayı:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İşlem Giriniz:(+,-,*,/)");
            string islem = Console.ReadLine();

            if (islem == "+") { Console.WriteLine(sayi1 + sayi2); }
            else if (islem == "-") { Console.WriteLine(sayi1 - sayi2); }
            else if (islem == "*") { Console.WriteLine(sayi1 * sayi2); }
            else if (islem == "/") { Console.WriteLine(sayi1 / sayi2); }
            else
            {
                Console.WriteLine("Hatalı İşlem Seçimi!!");
            }
        }

        static void Sonuc()
        {
            Hesapla();
        }
    }
}
