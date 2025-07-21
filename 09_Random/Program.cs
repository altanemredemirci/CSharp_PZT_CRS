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
            //while (true)
            //{
            //    Console.WriteLine(r.Next(5));
            //    Thread.Sleep(1000);
            //}

            //Console.WriteLine(r.Next(1, 5));


            #region 1-20 arasında rastgele pc tarafın oluşturulan bir sayıyı kullanıcıya 5 hak vererek tahmin etmesini isteyiniz.
            //Tahmin sornası kullanıcıyı 'tahmininizi küçültünüz' veya 'tahmininizi büyültünüz' mesajları ile yönlendirelim
            //int hak = 5;
            //int random = r.Next(0, 21);
            //Console.WriteLine(random);
           
            //while (hak > 0)
            //{
            //    Console.Write("Tahmin Edilen Random Sayı: ");
            //    int tahmin = Convert.ToInt32(Console.ReadLine());
            //    if (tahmin == random)
            //    {
            //        Console.WriteLine("Tahmin Doğru");
            //        break;
            //    }

            //    else if (hak == 1)
            //    {
            //        Console.WriteLine("Hakkınız Tükendi");
            //        Console.WriteLine("Rastgele sayı:" + random);
            //    }

            //    else if (tahmin < random)
            //    {
            //        Console.WriteLine("Sayıyı Yükseltiniz");
            //    }
            //    else if (tahmin > random)
            //    {
            //        Console.WriteLine("Sayıyı Küçültünüz");
            //    }
            //    hak--;
            //}
           

            #endregion
        }
    }
}
