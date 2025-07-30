namespace _06_Try_Catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *** TRY - CATCH ***
             *hata kontrolü yapılması istenilen kod blokları TRY adı verilen blok içine yazılır.
             *try{} bloğunda bulunan kod çalışırken hata oluşması durumunda CATCH{} bloğunda yapılması gerekn işlem tanımlanır. 

             */

            //try
            //{
            //    Console.WriteLine("Sayı giriniz:");
            //    int sayi = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine(sayi / 0);
            //}

            //catch (FormatException)
            //{
            //    Console.WriteLine("Sayıyı RAKAM olarak giriniz");
            //}

            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Hiç bir sayı 0 a bölünemez");
            //}

            //catch //Kendinden önceki catchler dışında kalan hatalar için
            //{
            //    Console.WriteLine("Bilinmeyen Hata!!");
            //}






            //try
            //{
            //    Console.WriteLine("Sayı giriniz:");
            //    int sayi = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine(sayi / 0);
            //}

            //catch(Exception e){
            //    Console.WriteLine(e.ToString()+":"+e.Message);
            //}





            //try
            //{
            //    Console.WriteLine("Sayı giriniz:");
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Sayi:"+sayi);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("HATA!!!");
            //}
            //finally
            //{
            //    Console.WriteLine("TRY veya CATCH fark etmeksizin her durumda çalışır");
            //}


            #region Kullanıcıdan 2 sayı alınız ve toplamlarını ekrana yazınız.
            //Sayıları giriş formatlarını try-catch ile kontrol ediniz.
            //2.sayı hatalıysa 2.sayı tekrar istensin.
            //    int sayi1 = 0;
            //    int sayi2 = 0;

            //DON:
            //    try
            //    {
            //        Console.WriteLine("1.Sayı giriniz:");
            //        sayi1 = Convert.ToInt32(Console.ReadLine());

            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("HATA:");
            //        goto DON;
            //    }

            //DON2:
            //    try
            //    {
            //        Console.WriteLine("2.Sayı giriniz:");
            //        sayi2 = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine("Toplam:" + (sayi2 +sayi1));
            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("HATA:");
            //        goto DON2;
            //    }



        //DON:
        //    try
        //    {
        //        Console.WriteLine("1.Sayı giriniz:");
        //        int sayi1 = Convert.ToInt32(Console.ReadLine());
               
        //    DON2:
        //            try
        //            {
        //                Console.WriteLine("2.Sayı giriniz:");
        //                int sayi2 = Convert.ToInt32(Console.ReadLine());
        //                Console.WriteLine("Toplam:" + (sayi2 + sayi1));
        //            }
        //            catch (Exception)
        //            {
        //                Console.WriteLine("HATA:");
        //                goto DON2;
        //            }
        //    }
        //    catch (Exception)
        //    {
        //        Console.WriteLine("HATA:");
        //        goto DON;
        //    }






            #endregion



        }
    }
}
