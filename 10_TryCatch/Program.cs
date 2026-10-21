namespace _10_TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    Console.WriteLine("Sayı:");
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //}
            //catch
            //{
            //    Console.WriteLine("Lütfen sayıyı rakam olarak giriniz");
            //}


            //while (true)
            //{
            //    try
            //    {
            //        Console.WriteLine("Sayı:");
            //        int sayi = Convert.ToInt32(Console.ReadLine());
            //        break;
            //    }
            //    catch
            //    {
            //        Console.WriteLine("Lütfen sayıyı rakam olarak giriniz");
            //    }
            //}


            //while (true)
            //{
            //    try
            //    {
            //        Console.WriteLine("Sayı:");
            //        int sayi = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine(10/sayi);
            //    }
            //    catch(FormatException)
            //    {
            //        Console.WriteLine("Lütfen sayıyı rakam olarak giriniz");
            //    }
            //    catch (DivideByZeroException)
            //    {
            //        Console.WriteLine("Sayı 0'a bölünemez");
            //    }
            //}


            try
            {
                Console.WriteLine("Sayı:");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(10 / sayi);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
