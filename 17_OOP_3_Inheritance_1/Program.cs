namespace _17_OOP_3_Inheritance_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //KALITIM - MİRAS ALMA - INHERINTANCE
            /*
             
            Ortak özellikleri bulunan birden fazla sınıfın için base bir class oluşturarak ortak özellikleri her classta tekrar yazmak yerine base class'a ekleriz ve diğer classlar base class'ı miras alarak bu özellikleri kendilerine çekebilirler.
             
            Kural-1: Her sınıf bir tane miras alabilir.
            Kural-2: Miras alınan temel sınıfta private tanımlı özellikler kalıtımla aktarılamaz.
             */

            InsanKaynaklari ik = new InsanKaynaklari();
            ik.T

        }
    }


    class Personel
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Maas { get; set; }
        public int CocukSayisi { get; set; }
        protected string Telefon { get; set; } //Sadece kendi classı ve miras alma işlemi ile türeyen class da erişilebilir.
    }

    class InsanKaynaklari:Personel
    {      
        public int PersonelSayisi { get; set; }

        public void Yaz()
        {
            this.
        }
    }

    class BilgiIslem:Personel
    {
        public int ProgramSayisi { get; set; }
    }

    class Muhasebe:Personel
    {
        public int HesapSayisi { get; set; }
    }
}
