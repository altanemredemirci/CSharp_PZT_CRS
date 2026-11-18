namespace _15_Class_9_Enum
{

    //Enum:Sabit Veri Tipleri

    enum Gunler
    {
        Pazartesi,Salı,Çarşamba,Perşembe,Cuma,Cumartesi,Pazar
    }

    enum Markalar
    {
        Ford=2,Mazda,Renault,BMW,Mercedes
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazartesi);

            Console.WriteLine(Markalar.Mazda);

            Insan insan = new Insan();

            insan.AdSoyad = "Altan Emre Demirci";
            insan.Araba = Markalar.Mazda;
            insan.DogumGunu = Gunler.Pazartesi;


            Console.WriteLine(insan.AdSoyad);
            Console.WriteLine(insan.DogumGunu);
            Console.WriteLine(insan.Araba);
        }
    }

    class Insan
    {
        public string AdSoyad;
        public Gunler DogumGunu;
        public Markalar Araba;
    }
}
