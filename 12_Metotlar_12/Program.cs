using System.Collections;

namespace _12_Metotlar_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList halMeyve = new ArrayList() { "ELMA", "ARMUT", "KİRAZ" };
            ArrayList halSebze = new ArrayList() { "PATLICAN", "SOĞAN", "PATATES" };

            ArrayList manavMeyve = new ArrayList();
            ArrayList manavSebze = new ArrayList();

            ArrayList manavKiloMeyve = new ArrayList();
            ArrayList manavKiloSebze = new ArrayList();

            ArrayList musteri = new ArrayList();

            Console.WriteLine("HALE HOŞGELDİNİZ");

            while (true)
            {
                Console.WriteLine("Meyve için M / Sebze için S / Çıkış Q\nSeçiminiz:");
                string secim = Console.ReadLine().ToUpper();

                if (secim == "M") 
                {
                    Metotlar.HalUrunAl(halMeyve, manavMeyve, manavKiloMeyve);
                }
                else if (secim == "S") 
                { 
                    Metotlar.HalUrunAl(halSebze, manavSebze, manavKiloSebze);
                }
                else if (secim == "Q") 
                {
                    Console.WriteLine("Yine Bekleriz.");
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı Seçim!!");
                }
            }

            while (true)
            {
                Console.WriteLine("Meyve için M / Sebze için S / Çıkış Q\nSeçiminiz:");
                string secim = Console.ReadLine().ToUpper();

                if (secim == "M")
                {
                    Metotlar.ManavUrunAl(manavMeyve, musteri, manavKiloMeyve);
                }
                else if (secim == "S")
                {
                    Metotlar.HalUrunAl(manavSebze, musteri, manavKiloSebze);
                }
                else if (secim == "Q")
                {
                    Console.WriteLine("Yine Bekleriz.");
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı Seçim!!");
                }
            }
        }
    }
}
