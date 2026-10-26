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


            //try
            //{
            //    Console.WriteLine("Sayı:");
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine(10 / sayi);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}


            #region Kullanıcıdan 2 sayı alınız. Girilen her değeri kontrol ederek doğru girilmesi halinde toplayınız. 1. sayı doğru 2. sayı yanlış girilirse sayıyı tekrar isteyiniz.

            int sayi1, sayi2;

            while (true)
            {
                try
                {
                    Console.WriteLine("1.Sayı:");
                    sayi1 = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Sayıyı rakam olarak giriniz");
                }
            }

            while (true)
            {
                try
                {
                    Console.WriteLine("2.Sayı:");
                    sayi2 = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Sayıyı rakam olarak giriniz");
                }
            }

            Console.WriteLine("Toplam:"+(sayi1+sayi2));

            #endregion


        }
    }
}
