namespace _19_Generic_Mimari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Urun> urunler = new List<Urun>();

            Urun urun = new Urun();
            urun.Ad = "Gömlek";
            urun.Fiyat = 1000;


            Islemler<Urun> islemler = new Islemler<Urun>();

            islemler.Kaydet(urun,urunler);


            Kategori kategori = new Kategori();
            kategori.Ad = "Giyim";
            kategori.Aciklama = "Erkek Giyim";


            //------------------------

            Product<double> product = new Product<double>(1000.0,20.0);



        }
    }

    class Product<T>
    {
        public T Fiyat { get; set; }
        public T KDV { get; set; }

        public Product(T fiyat, T kdv)
        {
            Fiyat = fiyat;
            KDV = kdv;
        }
    }



    class Urun
    {
        public string Ad { get; set; }
        public int Fiyat { get; set; }
    }

    class Kategori
    {
        public string Ad { get; set; }
        public string Aciklama { get; set; }
    }

    class Islemler<T>
    {
        public void Kaydet(T u,List<T> liste)
        {
            liste.Add(u);
        }        
    }


    
}
