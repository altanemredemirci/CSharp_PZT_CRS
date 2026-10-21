namespace _09_Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* ****** ARRAYS ******
              Aynı veri tipinde birden fazla değeri bir başlık altında tutmaya yarar.
             Dizi adına INDEX denilen 0'dan başlayarak 1'er 1'er artan numaralandırma işlemi ile değerleri tutarlar.
             */

            //int sayi = 12;

            //Dolu bir dizi tanımı
            //int[] sayilar = { 11, 12, 13 };

            //Console.WriteLine(sayilar[0]);
            //Console.WriteLine(sayilar[1]);
            //Console.WriteLine(sayilar[2]);
            //Console.WriteLine(sayilar[3]); //Olamayan bir index numarası çağrılırsa IndexOutOfRangeException hatasını verir.


            //for(int i=0; i<sayilar.Length; i++)
            //{
            //    Console.WriteLine(sayilar[i]);
            //}

            //int indx = 0;

            //while (indx < sayilar.Length)
            //{
            //    Console.WriteLine(sayilar[indx]);
            //    indx++;
            //}




            //Boş dizi tanımı
            //int[] sayilar = new int[3];

            //Diziye değer ekleme
            //sayilar[0] = 22;
            //sayilar[1] = 23;
            //sayilar[2] = 24;
            //sayilar[3] = 25;


            //Kullanıcıdan alınan 4 sayıyı bir diziye ekleyiniz.

            //int[] sayilar = new int[4];

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.WriteLine("Sayı:");
            //    sayilar[i] = Convert.ToInt32(Console.ReadLine());
            //}

            #region Kullanıcıdan kaç personeli olduğu bilgisini isteyiniz. Daha sonra personel isimlerini kullanıcıdan alarak diziye ekleyin ve işlem bittiğinde ekrana yazdırınız

            //Console.WriteLine("Personel sayısı: ");
            //int personelSayisi = Convert.ToInt32(Console.ReadLine());

            //string[] personeller = new string[personelSayisi];

            //for (int i = 0; i < personelSayisi; i++)
            //{
            //    Console.WriteLine("Personel adı:");
            //    personeller[i] = Console.ReadLine();
            //}

            //Console.WriteLine("PERSONEL LİSTESİ: ");

            //for (int i = 0; i < personelSayisi; i++)
            //{
            //    Console.WriteLine(personeller[i]);
            //}


            #endregion

            #region ARRAY SINIFI METOTLARI

            #region CLEAR()

            //int[] sayilar = { 11, 22, 33, 44 };

            ////Array.Clear(sayilar); //Bütün dizi elemanlarını siler.

            //Array.Clear(sayilar, 1, 2); //1.indexten başlayarak 2 değer siler

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.WriteLine(sayilar[i]);
            //}

            #endregion

            #region COPY()

            //int[] sayilar = { 11, 22, 33, 44 };

            //int[] sayilar2 = new int[10];


            ////Array.Copy(sayilar, sayilar2, 2); //Kaynak dizi, hedef dizi, kopyalanacak değer sayısı

            //Array.Copy(sayilar, 2, sayilar2, 4, 2);


            //for (int i = 0; i < sayilar2.Length; i++)
            //{
            //    Console.WriteLine(sayilar2[i]);
            //}

            #endregion

            #region INDEXOF()

            //string[] isimler = { "Altan", "Emre", "Altan", "Mehmet", "Efe", "Altan", "Erdinç", "Doğukan", "Altan", "Miraç" };

            //int index = Array.IndexOf(isimler, "Altan"); //ilk Altan değerinin index numarasını getirir.

            //int index = Array.IndexOf(isimler, "Altan",1); 

            //Console.WriteLine("Altan index numarası:"+index);

            #region Yukarıdaki bütün Altan değerlerinin index numaralarını ekrana yazdıran döngüyü yazınız.

            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    if (isimler[i] == "Altan")
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            //int i = -1;

            //while (i < isimler.Length)
            //{
            //    i = Array.IndexOf(isimler, "Altan", i + 1);

            //    if (i == -1)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(i);
            //}


            #endregion
            #endregion

            #region LASTINDEX()
            //string[] isimler = { "Altan", "Emre", "Altan", "Mehmet", "Efe", "Altan", "Erdinç", "Doğukan", "Altan", "Miraç" };

            //Console.WriteLine(Array.LastIndexOf(isimler,"Altan"));

            #endregion

            #region SORT()

            //string[] sehirler = { "Yozgat", "Adana", "Balıkesir", "Zonguldak", "İstanbul", "Çanakkale" };

            //Array.Sort(sehirler);

            //for (int i = 0; i < sehirler.Length; i++)
            //{
            //    Console.WriteLine(sehirler[i]);
            //}

            #endregion

            #region REVERSE()

            //string[] sehirler = { "Yozgat", "Adana", "Balıkesir", "Zonguldak", "İstanbul", "Çanakkale" };

            //Array.Reverse(sehirler);

            //for (int i = 0; i < sehirler.Length; i++)
            //{
            //    Console.WriteLine(sehirler[i]);
            //}


            #endregion

            #region RESIZE

            //int[] sayilar = new int[3];

            //sayilar[0] = 11;
            //sayilar[1] = 22;
            //sayilar[2] = 33;

            //Array.Resize(ref sayilar, 5); //sayilar dizisinin boyutunu 5'e çıkardık.

            //sayilar[3] = 44;

            #endregion

            #endregion

            #region Bir dizinin eleman sayısı 10 ile 20 arasında rastgele atansın.
            //Bu dizinin elemanlarını sistem 0-100 aralığında rastgele otomatik doldursun
            //Aynı sayı tekrar diziye eklenmesin
            //Dizinin en büyük ve en küçük değerlerini ekran yazdırınız.

            //Random r = new Random();

            //int boyut = r.Next(10, 20);

            //int[] sayilar = new int[boyut];
            //Console.WriteLine("Boyut:"+boyut);

            //int i = 0;
            //while(i<boyut)
            //{
            //    int sayi = r.Next(1, 25);

            //    if(sayilar.Contains(sayi) == false)
            //    {
            //        sayilar[i] = sayi;
            //        i++;
            //    }                
            //}

            //int enBuyuk = sayilar[0];
            //int enKucuk = sayilar[0];

            //for (int j = 0; j < boyut; j++)
            //{
            //    if (sayilar[j] > enBuyuk)
            //    {
            //        enBuyuk = sayilar[j];
            //    }
            //    if (sayilar[j] < enKucuk)
            //    {
            //        enKucuk = sayilar[j];
            //    }
            //}

            //Console.WriteLine("En büyük:"+enBuyuk);
            //Console.WriteLine("En küçük:"+enKucuk);

            //for (int k = 0; k < sayilar.Length; k++)
            //{
            //    Console.WriteLine(sayilar[k]);
            //}


            #endregion



            #region FOREACH
            //Koleksiyonları ekrana yazdırmak için kullanılır.
            
            //int[] sayilar = { 11, 22, 33, 44 };

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.WriteLine(sayilar[i]);
            //}

            //foreach (int sayi in sayilar)
            //{
            //    Console.WriteLine(sayi);
            //}




            #endregion



           

        }
    }
}
