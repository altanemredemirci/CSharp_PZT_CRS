namespace _12_Metotlar_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //METOT İMZASI - Aynı isimde tanımlanan metotları birbirinden ayıran ve özelleştiren özelliğe metot imzası denir. Metot imzası metodun parametre sayısı ve parametre veri tipi ile belirlenir. 
            //Metotların aynı isimle birden fazla kez tanımlanmasına OVERLOAD işlemi denir.

            Topla();

            Topla(1, 2);

            Topla(1, 4.5);

            Topla(5.5, 3);
        }

        static void Topla()
        {
            Console.WriteLine("1.Sayı:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Sayı:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(sayi2+sayi1);
        }

        static void Topla(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1+sayi2);
        }

        static void Topla(int sayi1, double sayi2)
        {
            Console.WriteLine(sayi1 + sayi2);
        }

        static void Topla(double sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 + sayi2);
        }
    }
}
