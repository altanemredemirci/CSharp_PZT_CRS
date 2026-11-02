namespace _12_Metotlar_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Değer Döndüren Metotlarda metot tanımlanırken döndüreceği veri tipi yazılır. Metot bitişinde return komutu ile değer döndürülür.

            //Bir metodun sonucu kodun akışında kullanılacak ise değer döndüren metot tanımlanır.


            Topla();


            int sonuc = Topla2();

            Console.WriteLine(sonuc);
        }

        static void Topla()
        {
            Console.WriteLine("1.Sayı:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Sayı:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(sayi2+sayi1);

        }

        static int Topla2()
        {
            Console.WriteLine("1.Sayı:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Sayı:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            return sayi1 + sayi2;

        }
    }

    
}
