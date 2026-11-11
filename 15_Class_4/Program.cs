namespace _15_Class_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Ogrenci> ogrenciler = new List<Ogrenci>();

            //Ogrenci.Kaydet(ogrenciler);

            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Kaydet2();

            ogrenciler.Add(ogrenci);

            foreach (Ogrenci item in ogrenciler)
            {
                Console.WriteLine(item.Ad);
                Console.WriteLine(item.Soyad);
            }
        }
    }
}
