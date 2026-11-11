namespace _15_Class_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Manav Otomasyonu Class'a çeviriniz.

            List<Urun> HalUrunler = new List<Urun>()
            {
                new Urun(){Ad="Elma",Fiyat=100,Stok=200,Tur="M"},
                new Urun(){Ad="Armut",Fiyat=150,Stok=200,Tur="M"},
                new Urun(){Ad="Kiraz",Fiyat=120,Stok=200,Tur="M"},
                new Urun(){Ad="Patates",Fiyat=110,Stok=200,Tur="S"},
                new Urun(){Ad="Soğan",Fiyat=110,Stok=200,Tur="S"},
                new Urun(){Ad="Biber",Fiyat=120,Stok=200,Tur="S"}
            };

            List<Urun> ManavUrunler = new List<Urun>();

            List<Urun> MusteriUrunler = new List<Urun>();

            while (true)
            {
                Console.WriteLine("****** HALE HOŞGELDİNİZ *******");
                Console.WriteLine("Meyve için M / Sebze için S / Çıkış Q\nSeçiminiz:");
                string secim = Console.ReadLine();

                if (secim == "M")
                {
                    Urun.Listele(HalUrunler, secim);

                    Urun.SatinAl(HalUrunler, ManavUrunler);
                }
                else if (secim == "S")
                {
                    Urun.Listele(HalUrunler, secim);
                }
                else if (secim == "Q")
                {
                    Console.WriteLine("Yine Bekleriz...");
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı Tuşlama!!");
                }
            }

            while (true)
            {
                Console.WriteLine("****** MANAVA HOŞGELDİNİZ *******");
                Console.WriteLine("Meyve için M / Sebze için S / Çıkış Q\nSeçiminiz:");
                string secim = Console.ReadLine();

                if (secim == "M")
                {
                    Urun.Listele(ManavUrunler, secim);

                    Urun.SatinAl(ManavUrunler, MusteriUrunler);
                }
                else if (secim == "S")
                {
                    Urun.Listele(ManavUrunler, secim);

                    Urun.SatinAl(ManavUrunler, MusteriUrunler);
                }
                else if (secim == "Q")
                {
                    Console.WriteLine("Yine Bekleriz...");
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı Tuşlama!!");
                }
            }
        }
    }

    class Urun
    {
        public string Ad;
        public double Fiyat;
        public int Stok;
        public string Tur;

        public static void Listele(List<Urun> liste, string tur)
        {
            foreach (Urun urun in liste)
            {
                if (urun.Tur == tur.ToUpper())
                {
                    Console.WriteLine($"{urun.Ad}:{urun.Fiyat} - {urun.Stok} kilo");
                }
            }
        }
        public static void SatinAl(List<Urun> satilanListe, List<Urun> alinanListe)
        {
            Console.WriteLine("Satın alınacak ürün ad:");
            string urunAd = Console.ReadLine();

            Urun satinAlinan = new Urun();

            bool isProduct = false;

            foreach (Urun urun in satilanListe)
            {
                if(urun.Ad.ToLower() == urunAd.ToLower())
                {
                    isProduct = true;

                    //ürün alıcıda var mı?
                    foreach (Urun mevcutUrun in alinanListe)
                    {
                        if(mevcutUrun.Ad.ToLower() == urun.Ad.ToLower())
                        {
                            satinAlinan = mevcutUrun;

                            Console.WriteLine("Kaç kilo istersiniz?");
                            int kilo = Convert.ToInt32(Console.ReadLine());

                            if (urun.Stok >= kilo)
                            {
                                urun.Stok -= kilo;
                                satinAlinan.Stok += kilo;
                            }
                            else
                            {
                                Console.WriteLine($"Elimizde {urun.Stok} kilo {urun.Ad} var");
                            }

                            break;
                        }
                    }

                    if (satinAlinan.Stok == 0)
                    {
                        Console.WriteLine("Kaç kilo istersiniz?");
                        int kilo = Convert.ToInt32(Console.ReadLine());

                        if (urun.Stok >= kilo)
                        {
                            urun.Stok -= kilo;

                            satinAlinan.Stok += kilo;

                            satinAlinan.Ad = urun.Ad;
                            satinAlinan.Tur = urun.Tur;
                            satinAlinan.Fiyat = urun.Fiyat * 1.1;

                            alinanListe.Add(satinAlinan);
                        }
                        else
                        {
                            Console.WriteLine($"Elimizde {urun.Stok} kilo {urun.Ad} var");
                        }
                    }

                    break;
                }
            }

            if (isProduct == false)
            {
                Console.WriteLine($"{urunAd} bulunamadı.");
            }
        }
    }
}
