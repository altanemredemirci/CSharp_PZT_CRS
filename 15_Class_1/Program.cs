namespace _15_Class_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  ÖĞRENCİ KAYIT SİSTEMİ*/
            //Ad,Soyad,Numara,Sinif

            //List<string> ogrenciler = new List<string>();
            //ogrenciler.Add("Altan");
            //ogrenciler.Add("Demirci");
            //ogrenciler.Add("154");
            //ogrenciler.Add("10-F");

            //ogrenciler.Add("Uras");
            //ogrenciler.Add("Demirci");
            //ogrenciler.Add("155");
            //ogrenciler.Add("1-A");


            //NESNE OLUŞTURMA - INSTANCE
            Ogrenci ogrenci = new Ogrenci(); //nesne:ogrenci
            ogrenci.Ad = "Altan Emre";
            ogrenci.Soyad = "Demirci";
            ogrenci.Numara = 154;
            ogrenci.Sinif = "10-C";

            Ogrenci ogrenci2 = new Ogrenci(); //nesne:ogrenci2
            ogrenci2.Ad = "Ömer";
            ogrenci2.Soyad = "Demirci";
            ogrenci2.Numara = 155;
            ogrenci2.Sinif = "1-C";


            List<Ogrenci> ogrenciler = new List<Ogrenci>();
            ogrenciler.Add(ogrenci);
            ogrenciler.Add(ogrenci2);
        }
    }

    class Ogrenci
    {
        //property
        public string Ad;
        public string Soyad;
        public int Numara;       
        public string Sinif;
    }  
}
