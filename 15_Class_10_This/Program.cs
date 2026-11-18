namespace _15_Class_10_This
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci(1,"Viktoria","Hodorozha");
            ogrenci.Kaydet();
        }
    }

    class Ogrenci
    {
        public int Numara;
        public string Ad;
        public string Soyad;

        public Ogrenci(int Numara,string Ad,string Soyad)
        {
            this.Numara = Numara;
            this.Ad = Ad;
            this.Soyad = Soyad;

            this.Kaydet();
        }

        public void Kaydet()
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
