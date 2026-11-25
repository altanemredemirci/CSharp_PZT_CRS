namespace _17_OOP_5_Abstract_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              Telefon  : decimal AlisFiyati, decimal KarYuzdesi, decimal LisansUcreti - FiyatHesapla()
              Buzdolabi: decimal AlisFiyati, decimal KarYuzdesi - FiyatHesapla()
            */

            Telefon telefon = new Telefon();
            telefon.AlisFiyati = 45000;
            telefon.KarYuzdesi = 1.2m;

            decimal deger = telefon.FiyatHesapla();

            Console.WriteLine("Ödeme:"+deger);
        }
    }

    abstract class ElektronikEsya 
    {
        public decimal AlisFiyati { get; set; }
        public decimal KarYuzdesi { get; set; }

        public abstract decimal FiyatHesapla();
    }

    class Telefon : ElektronikEsya
    {
        public decimal LisansUcreti { get; set; }

        public override decimal FiyatHesapla()
        {
            return (AlisFiyati * KarYuzdesi) + LisansUcreti;
        }
    }

    class Buzdolabi : ElektronikEsya
    {
        public override decimal FiyatHesapla()
        {
            return AlisFiyati * KarYuzdesi;
        }
    }
}
