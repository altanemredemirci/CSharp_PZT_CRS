namespace _09_Random
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Random: Rastgele sayı üretmek için kullanılan kütüphanedir.



            Random r = new Random(); //Instance - Örneklem

            #region 1.Yol
            //int sayi = r.Next();
            //Console.WriteLine(sayi);

            //Console.WriteLine(r.Next());
            #endregion

            //Console.WriteLine(r.Next(5));
            Console.WriteLine(r.Next(1,5));

        }
    }
}
