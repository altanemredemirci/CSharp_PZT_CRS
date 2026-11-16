namespace _15_Class_8_Constructor_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
        }
    }

    class Ogrenci
    {
        public int Numara;
        public string Ad;
        public string Soyad;

        public Ogrenci()
        {
            Kaydet();
        }

        private void Kaydet()
        {
            Console.WriteLine("Numara:");
            Numara = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ad:");
            Ad = Console.ReadLine();

            Console.WriteLine("Soyad:");
            Soyad = Console.ReadLine();
        }
    }
}
