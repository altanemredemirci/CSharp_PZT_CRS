namespace _17_OOP_3_Inheritance_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    class Vatandas
    {
        public long TC { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public void Kaydet()
        {
            Console.WriteLine("TC:");
            TC = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Ad:");
            Ad = Console.ReadLine();

            Console.WriteLine("Soyad:");
            Soyad = Console.ReadLine();
        }

        class InsanKaynaklari : Vatandas
        {
            public int PersonelSayisi { get; set; }

            //public new void Kaydet() //NameHiding
            //{
            //    Console.WriteLine("TC:");
            //    TC = Convert.ToInt64(Console.ReadLine());

            //    Console.WriteLine("Ad:");
            //    Ad = Console.ReadLine();

            //    Console.WriteLine("Soyad:");
            //    Soyad = Console.ReadLine();

            //    Console.WriteLine("Personel Sayisi:");
            //    PersonelSayisi = Convert.ToInt32(Console.ReadLine());
            //}

            public new void Kaydet() //NameHiding
            {
                base.Kaydet(); //base kelimesi miras alınan temel sınıfı temsil eder.

                Console.WriteLine("Personel Sayisi:");
                PersonelSayisi = Convert.ToInt32(Console.ReadLine());
            }

        }
    }
}
