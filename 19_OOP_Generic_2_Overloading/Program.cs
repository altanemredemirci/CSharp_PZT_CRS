namespace _19_OOP_Generic_2_Overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Urun<int> urun = new Urun<int>(500,20);

            Urun<int, double> urun2 = new Urun<int, double>(1000, 15.5);
        }
    }
}
