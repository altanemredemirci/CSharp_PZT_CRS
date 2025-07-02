namespace _07_Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            **** LOOPS:  ****
            *While:
            *For:
            *DoWhile:
            *Foreach:
            
             Belirli bir kod satırının istenilen kadar tekrar etmesini sağlar. 
             
             */

            //1-10 a kadar olan sayıları alt alta ekrana yazdırınız

            //int sayi = 1;

            //while (sayi < 11)
            //{
            //    Console.WriteLine(sayi);
            //    sayi++;
            //}

            string sifre = "ab18";

            int hak = 3;

            while (hak>0)
            {
                Console.WriteLine("Şifre:");
                string pass = Console.ReadLine();

                if (pass == sifre)
                {
                    Console.WriteLine("Başarılı");
                    break;
                }

                hak--;
            }



        }
    }
}
