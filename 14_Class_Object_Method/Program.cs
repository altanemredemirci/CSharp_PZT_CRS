namespace _14_Class_Object_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Ogrenci> ogrenciListesi = new List<Ogrenci>();

            //Ogrenci.Create(ogrenciListesi);


            //Ogrenci ogrenci = new Ogrenci();
            //ogrenci.Create(); //this
            //ogrenciListesi.Add(ogrenci);


            Ogrenci ogrenci = Ogrenci.Create();
            ogrenciListesi.Add(ogrenci);


            ogrenciListesi.Add(Ogrenci.Create());

        }
    }

    class Ogrenci
    {
        public int Numara;
        public string Ad;

        //Create(),Update(),Delete(),List()

        #region 1.Yol
        /// <summary>
        /// Sınıf üzerinden çağrılır.
        /// Bütün işlemleri(Nesne oluşturma,nesne özellikleri alma) kendisi yapar.
        /// </summary>
        //public static void Create(List<Ogrenci> ogrencis)
        //{
        //    Ogrenci ogr = new Ogrenci();
        //    Console.WriteLine("Numaranız:");
        //    ogr.Numara = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Adınız:");
        //    ogr.Ad = Console.ReadLine();

        //    ogrencis.Add(ogr);
        //}
        #endregion

        #region 2.Yol
        /// <summary>
        /// Nesne üzerinden çağrılır.
        /// Çağrıldığı nesneye ait properties doldurur.
        /// </summary>
        //public void Create()
        //{
        //    Console.WriteLine("Numaranız:");
        //    this.Numara = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Adınız:");
        //    this.Ad = Console.ReadLine();
        //}
        #endregion

        #region 3.Yol
        /// <summary>
        /// Sınıf üzerinden çağrılır.
        /// Bütün işlemleri(Nesne oluşturma,nesne özellikleri alma) kendisi yapar.
        /// Nesneyi Geri Döndürür
        /// </summary>
        /// <returns>Ogrenci</returns>


        public static Ogrenci Create()
        {
            Ogrenci ogr = new Ogrenci();
            Console.WriteLine("Numaranız:");
            ogr.Numara = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adınız:");
            ogr.Ad = Console.ReadLine();

            return ogr;
        }

        #endregion
    }
}
