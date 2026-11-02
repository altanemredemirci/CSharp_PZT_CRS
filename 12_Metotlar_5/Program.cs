namespace _12_Metotlar_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Static: Bir field 'ın direk class ismi üzerinden erişilebilir hale getirir.

            Matematik.Topla();

            //NonStatic: Class üzerinden değil, classtan oluşturulan nesne üzerinden erişilebilir.
            
            Matematik matematik = new Matematik();
            matematik.Topla2();

            Random random = new Random();
            random.Next();
        }

    }
    class Matematik
    {
        internal static void Topla()
        {
            Console.WriteLine("Toplama İşlemi");
        }

        internal void Topla2()
        {
            Console.WriteLine("Toplama İşlemi");
        }
    }
}
