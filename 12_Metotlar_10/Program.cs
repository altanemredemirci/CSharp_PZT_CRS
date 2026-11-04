namespace _12_Metotlar_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden girilen değerler arasında rastgele sayı üreten ve bu sayıları bir diziye kaydeden SayiUret() isimli bir metot yazın.
            //Bu dizinin elemanlarını yazan DiziYazdir() metodunu yazın
            //Daha sonra bu dizinin içerisinde EnBuyukDeger() ve EnKucukDeger() bulan metotları yazın.
            //Aynı sayı birden fazla kez diziye eklenmesin.

            Console.WriteLine("Başlangıç Değeri:");
            int basla = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Bitiş Değeri:");
            int bitis = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Adet:");
            int adet = Convert.ToInt32(Console.ReadLine());


            int[] sayilar = new int[adet];

            SayiUret(sayilar, basla, bitis);

            DiziYazdir(sayilar);

            Console.WriteLine("En Büyük:"+EnBuyukDeger(sayilar));
            Console.WriteLine("En Küçük:"+EnKucukDeger(sayilar));

        }

        static void SayiUret(int[] dizi, int basla, int bitis)
        {
            Random r = new Random();

            int i = 0;
            while (dizi.Length > i)
            {
                int sayi = r.Next(basla, bitis);

                if (!dizi.Contains(sayi))
                {
                    dizi[i] = sayi;
                    i++;
                }
            }
        }

        static void DiziYazdir(int[] dizi)
        {
            foreach (int sayi in dizi)
            {
                Console.WriteLine(sayi);
            }
        }

        static int EnBuyukDeger(int[] dizi)
        {
            int enBuyuk = dizi[0];

            foreach (int item in dizi)
            {
                if (item > enBuyuk)
                {
                    enBuyuk = item;
                }
            }

            return enBuyuk;
        }
        static int EnKucukDeger(int[] dizi)
        {
            int enKucuk = dizi[0];

            foreach (int item in dizi)
            {
                if (item < enKucuk)
                {
                    enKucuk = item;
                }
            }

            return enKucuk;
        }
    }
}
