using System.Collections;

namespace _11_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] sayilar = new int[10]; //Aynı veri tipinde belirtilen boyut kadar değer eklenebilir.

            //ArrayList arrayList = new ArrayList(); //Boyut ve veritipi tanımı yok

            //ArrayList içerisine birden fazla farklı tipte veri eklenebilir.

            //arrayList.Add(11);
            //arrayList.Add(11.5);
            //arrayList.Add(11.5f);
            //arrayList.Add(11.5m);
            //arrayList.Add("Altan");
            //arrayList.Add('K');

            //for (int i = 0; i < arrayList.Count; i++)
            //{
            //    Console.WriteLine(arrayList[i]);
            //}

            //foreach (var item in arrayList) //variable:veri tipi olmayan
            //{
            //    Console.WriteLine(item);
            //}


            //Dolu ArrayList Tanımı
            //ArrayList sayilar = new ArrayList() { 11, 22, 33, 44, 55 };

            //Console.WriteLine(sayilar[2]);
            //Console.WriteLine(sayilar[8]); //Aralık dışı hatası verir.

            //sayilar.Add(66);
            //sayilar[4] = 77; //Varolan indexdeki değer güncellenebilir.

            //İki index arasında değer ekleme
            //sayilar.Insert(2, 23);

            //COUNT VE CAPACITY ÖZELLİKLERİ
            //ArrayList sayilar = new ArrayList() { 1, 2, 3,4,5 };

            //Console.WriteLine("COUNT:"+sayilar.Count);
            //Console.WriteLine("CAPACITY:"+sayilar.Capacity);

            //CLEAR()
            //sayilar.Clear();

            //Console.WriteLine("COUNT:" + sayilar.Count);
            //Console.WriteLine("CAPACITY:" + sayilar.Capacity);

            //REMOVE():Verilen değeri siler.
            //sayilar.Remove(2);

            //REMOVEAT(): Verilen index değerini siler
            //sayilar.RemoveAt(2);

            //ADDRANGE()
            //ArrayList sayilar2 = new ArrayList() { 5, 8, 9 };

            //sayilar.AddRange(sayilar2);


            //REMOVERANGE()
            //sayilar.RemoveRange(1, 2); //1.indexden başla 2 değer sil.


            //foreach (var item in sayilar2)
            //{
            //    if (!sayilar.Contains(item))
            //    {
            //        sayilar.Add(item);
            //    }
            //}


            #region Kullanıcıdan aile birey isimlerini isteyerek bir arrayliste ekleyiniz.

            //ArrayList aile = new ArrayList();

            //Console.WriteLine("Aile kaç kişi?");
            //int kisiSayisi = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < kisiSayisi; i++)
            //{
            //    Console.WriteLine("İsim:");
            //    aile.Add(Console.ReadLine());
            //}


            //foreach (string item in aile)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            //CLONE()
            //ArrayList sehirler = new ArrayList() { "İstanbul","Ankara","İzmir"};

            //ArrayList sehirler2 = (ArrayList)sehirler.Clone();

            //sehirler.Add("Kars");

            //foreach (string item in sehirler)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("-------------------");
            //foreach (string item in sehirler2)
            //{
            //    Console.WriteLine(item);
            //}


            #region Kullanıcıdan sayı girmesini isteyelim. Sayı yerine çık yazana kadar girilen sayıları bir arrayliste ekleyelim. sayı yerine çık ifadesini yazarsa arraylist içindeki sayıların toplamını ekrana yazdıralım.

            ArrayList sayilar = new ArrayList();
            int toplam = 0;

            while (true)
            {
                Console.WriteLine("Sayı:");
                string sayi = Console.ReadLine();

                if (sayi == "çık" || sayi=="cik")
                    break;

                int deger = Convert.ToInt32(sayi);

                sayilar.Add(deger);
                toplam += deger;
            }

            Console.WriteLine(toplam);



            #endregion
        }
    }
}
