using System.Text;

namespace _13_ManavOtomasyonu
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            List<Urun> Meyveler = new List<Urun>();


            ////Instance - Object oluşturma 
            //Urun urun = new Urun();
            //urun.Name = "Elma";
            //urun.Stock = 1000;
            //urun.Price = 25.50;
            //urun.Type = "meyve";

            //Meyveler.Add(urun);

            Urun urun1 = new Urun() { Name = "Armut", Price = 100, Stock = 1000, Type = "meyve" };
            Meyveler.Add(urun1);

            List<Urun> Sebzeler = new List<Urun>()
            {
                new Urun(){Name="Patlıcan",Price=85,Stock=1000,Type="sebze" },
                new Urun(){Name="Domates",Price=75,Stock=1000,Type="sebze" },
                new Urun(){Name="Biber",Price=65,Stock=1000,Type="sebze" },
                new Urun(){Name="Soğan",Price=55,Stock=1000,Type="sebze" },
            };

            List<Urun> ManavMeyveler = new List<Urun>();
            List<Urun> ManavSebzeler = new List<Urun>();


            while (true)
            {
                Console.WriteLine("HALE HOŞGELDİNİZ");
                Console.WriteLine("Meyve için M Sebze için S Çıkış için Ç seçiniz:");
                string halSecim = Console.ReadLine().ToUpper();

                if (halSecim == "M")
                {
                    Urun.UrunSatis(Meyveler, ManavMeyveler);

                }
                else if (halSecim == "S")
                {
                    Urun.UrunSatis(Sebzeler, ManavSebzeler);
                }
                else if (halSecim == "A11")
                {
                    Console.WriteLine("1-Ekle\n2-Güncelle\n3-Sil\nSeçiminiz:");
                    int secim = Convert.ToInt32(Console.ReadLine());

                    if (secim == 1)
                    {
                        //Static Method
                        Urun.UrunEkle(Meyveler);

                        ////NonStatic
                        //Urun urun2 = new Urun();
                        //urun2.UrunEkle2();

                        //Meyveler.Add(urun2);

                        
                    }

                }
                else
                {
                    Console.WriteLine("Hatalı Seçim!!");
                }

                Console.WriteLine("Başka bir arzunuz var mı?(E/H)");
                string cevap = Console.ReadLine().ToUpper();

                if (cevap == "E")
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Yine Bekleriz!!");
                    break;
                }
            }

            Console.WriteLine("");
        }
    }

    //Default internal olarak tanımlanır.
    class Urun
    {
        //Default private olarak tanımlanır.
        internal string Name;
        internal double Price;
        internal short Stock;
        internal string Type;

        public static void UrunSatis(List<Urun> uruns, List<Urun> manavList)
        {
            foreach (Urun meyve in uruns)
            {
                Console.WriteLine($"{meyve.Name}:{meyve.Price}");
            }
            Console.WriteLine("Ürün seçiniz:");
            string urunSecim = Console.ReadLine();

            foreach (var item in uruns)
            {
                if (item.Name == urunSecim)
                {
                    manavList.Add(item);
                }
            }
        }

        public static void UrunEkle(List<Urun> uruns) 
        {
            Urun urun = new Urun();

            Console.WriteLine("Ürün Adı:");
            urun.Name = Console.ReadLine();
            
            Console.WriteLine("Stok:");
            urun.Stock = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Fiyat:");
            urun.Price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ürün Tipi:");
            urun.Type = Console.ReadLine();

            uruns.Add(urun);
        }

        public void UrunEkle2() //urun2 => this
        {
            Console.WriteLine("Ürün Adı:");
            this.Name = Console.ReadLine();

            Console.WriteLine("Stok:");
            this.Stock = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Fiyat:");
            this.Price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ürün Tipi:");
            this.Type = Console.ReadLine();

        }

    }
}
