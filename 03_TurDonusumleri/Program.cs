using System.Runtime.ConstrainedExecution;

namespace _03_TurDonusumleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region TÜR DÖNÜŞÜMLERİ - TYPE CONVERSION

            //Console.WriteLine("Yaşınız:"); //Konsol ekranına yazar.
            //string yas = Console.ReadLine(); //Konsol ekranından aktif satırı okur.

            //Tür Dönüşümleri bilinçli ve bilinçsiz olmak üzere 2'ye ayrılır.
            //Bilinçli tür dönüşümü Convert veya Parse komutları kullanarak yazılan dönüşüm işlemleridir.


            //Console.WriteLine("Yaşınız:"); 
            //int yas = Convert.ToInt32(Console.ReadLine()); 


            //Console.WriteLine("Kardeşiniz Yaşı:");
            //int yas2 = Convert.ToInt32(Console.ReadLine());


            //Console.WriteLine(yas+yas2);


            //*** BİLİNÇSİZ TÜR DÖNÜŞÜMÜ

            //int sayi = 10;
            //double sayi2 = sayi; //Hata vermez çünkü double int tipini kapsayan bir veri tipidir.

            //double sayi = 10;
            //int sayi2 = (int)sayi; //BOXING


            //double sayi = 10456465465465;
            //int sayi2 = (int)sayi;

            //Console.WriteLine(sayi2);

            #endregion


            #region Kullanıcıdan vize ve final notlarını alınız. Girilen vize notunun %40 ve final notunun %60 nın toplamı ile ortalamayı ekrana yazdırınız

            Console.WriteLine("Vize:");
            int vize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Final:");
            int final = Convert.ToInt32(Console.ReadLine());

            double ortalama = vize * 0.4 + final * 0.6;

            Console.WriteLine(ortalama);
            Console.WriteLine("Ortalama:"+ortalama);
            Console.WriteLine($"Ortalama:{ortalama}");
            Console.WriteLine("Ortalama:{0}",ortalama);

           
            #endregion
        }
    }
}
