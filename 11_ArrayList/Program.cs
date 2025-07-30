using System.Collections;

namespace _11_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array aksine veritipi sınırlaması olmayan ve eleman sayısı belirtilmeden tanımlanır.
            //ArrayList tanımlarken using System.Collections; kütüphanesi kullanılır.

            //ArrayList arrayList = new ArrayList();

            //Eleman ekleme
            //arrayList.Add(10);
            //arrayList.Add("Altan");
            //arrayList.Add('?');
            //arrayList.Add(10.5);
            //arrayList.Add(10.5m);
            //arrayList.Add(10.5f);

            //*** Eleman yazdırma ***
            //for (int i = 0; i < arrayList.Count; i++)
            //{
            //    Console.WriteLine(arrayList[i]);
            //}



            //int i = 0;

            //while (i < arrayList.Count)
            //{
            //    Console.WriteLine(arrayList[i]);
            //    i++;
            //}


            //foreach(var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}


            //var sayi = 10.5;
            //int sayi2 = 15;

            //Console.WriteLine(sayi+sayi2);


            ArrayList sayilar = new ArrayList() { 11, 22, 3, 4, 5, 6, 67, 8, 9 };

            //Console.WriteLine(sayilar.Count);
            //Console.WriteLine(sayilar.Capacity);

            //sayilar.Clear();

            //ArrayList kopyaSayilar = sayilar; //Ram Adresleri eşitlenir.

            //ArrayList kopyaSayilar =(ArrayList) sayilar.Clone();

            //sayilar.Add(100);

            //foreach (var item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("*****************");
            //foreach (var item in kopyaSayilar)
            //{
            //    Console.WriteLine(item);
            //}

            sayilar.AddRange(new ArrayList { 0, 12, 23, 4, 5, 566 });

            foreach (var item in sayilar)
            {
                Console.WriteLine(item);
            }

            #region  Kullanıcıdan aile bireylerinin isimlerini alıp bir ArrayListe atınız ve işlem bittiğimde ekrana yazdırınız

            ArrayList isimler = new ArrayList();

            Console.WriteLine("Aile kaç Kişi?");
            int sayi = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < sayi; i++)
            {
                Console.WriteLine("Aile Bireyinizin İsmini Giriniz: ");
                string isim = Console.ReadLine()!;
                isimler.Add(isim);
            }

            //foreach (var name in isimler)
            //{
            //    Console.WriteLine(name);
            //}

            for (int i = 0; i < sayi; i++)
            {
                Console.WriteLine(isimler[i]);
            }




            #region Tuğçe
            //ArrayList aileBireyleri = new ArrayList();
            //string isim;

            //while (true)
            //{
            //    Console.Write("İsim girin: ");
            //    isim = Console.ReadLine();
            //    aileBireyleri.Add(isim);

            //    Console.WriteLine("Başka eklenecek mi?(E/H)");
            //    string cevap = Console.ReadLine();
            //    if (cevap == "H")
            //    {
            //        break;
            //    }

            //}


            //Console.WriteLine("Girilen aile bireyleri:");
            //foreach (var birey in aileBireyleri)
            //{
            //    Console.WriteLine(birey);
            //}

            #endregion


            #endregion




        }
    }
}