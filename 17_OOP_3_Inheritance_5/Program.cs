namespace _17_OOP_3_Inheritance_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    class Ogrenci
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public Ogrenci(string ad, string soyad)
        {
            Ad = ad;
            Soyad = soyad;
        }
    }

    class IlkOkul : Ogrenci
    {
        public int Not { get; set; }
        public IlkOkul(string isim,string soyisim, int not):base(isim,soyisim)
        {
            Not = not;
        }
    }

    class IlkOgretim : IlkOkul
    {
        public string Bolum { get; set; }

        public IlkOgretim(string ad,string soyad,int not,string bolum):base(ad,soyad,not)
        {
            Bolum = bolum;
        }
    }
}
