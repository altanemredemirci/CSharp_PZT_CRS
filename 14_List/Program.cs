using System.Collections;

namespace _14_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] sayilar = new int[10];//Avantajı belirli bir veri tipinde datalar tutar.
                                        //Dezavantajı sabit bir boyut tanımlaması olması.

            //ArrayList arrayList = new ArrayList(); //Avantajı belirli bir boyut sınırı olmaması
                                                   //Dezavantajı karışık veri tipinde data tutar.

            List<int> sayilar = new List<int>();

            sayilar.Add(11);
            sayilar.Add(12);

            //Console.WriteLine(sayilar[1]);

            //foreach (int item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}

            //for (int i = 0; i < sayilar.Count; i++)
            //{
            //    Console.WriteLine(sayilar[i]);
            //}


            //Dolu Liste Tanımı
            List<string> isimler = new List<string>() { "Altan","Emre","Uras","Kerem","Kıvanç"};


            //Kullanıcından aile birey sayısını alarak aile bireylerinin isimlerini bir listeye ekleyiniz. 

            Console.WriteLine("Aile birey sayısı:");
            int bireySayisi = Convert.ToInt32(Console.ReadLine());

            List<string> aile = new List<string>();

            for (int i = 0; i < bireySayisi; i++)
            {
                Console.WriteLine("Ad:");
                aile.Add(Console.ReadLine());
            }

            foreach (string isim in aile) 
            {
                Console.WriteLine(isim);
            }  

        }
    }
}
