namespace _03_TurDonusumleri_Operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Kullanıcıdan bir data almak için Console.ReadLine() komutu kullanılır.
             Kullanıcıya bilgi vermek(konsole mesaj yazmak) için Console.WriteLine() komutu kullanılır.
             
             */
            //int yas1 = 35;
            //int yas2 = 15;
            //int toplam = yas1 + yas2;

            //Console.WriteLine(yas1);
            //Console.WriteLine(yas2);
            //Console.WriteLine(yas1+yas2);
            //Console.WriteLine(toplam);

            #region Kullanıcıdan adı ve soyadını alınız. Ekrana Ad ve Soyadı yazdırınız.

            //Console.WriteLine("Adınız:"); //Kullanıcıya mesaj verdik.
            //string ad = Console.ReadLine();

            //Console.WriteLine("Soyad:");
            //string soyad = Console.ReadLine();

            //Console.WriteLine(ad + " " + soyad);

            #endregion

            #region İki kardeşim yaşları toplamı
            /*
            1-Başla
            2-yas1=birinci kardeşin yaşı
            3-yas2=ikinci kardeşin yaşı
            4-toplam=yas1+yas2
            5-Ekrana Yaz(toplam)


            1-başla
            2-"1.kardeşin yaşı:"
            3-string yas1 = console oku
            4-yas1 int çevir            
                          
            */

            //Console.WriteLine("1.Kardeşin Yaşı:");
            //int yas1 =Convert.ToInt32(Console.ReadLine());

            ////int y1 = Convert.ToInt32(yas1); //yas1 değişkenindeki değeri sayısal veri tipine çevirmek


            //Console.WriteLine("2.Kardeşin Yaşı:");
            //int yas2 =Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(yas1 + yas2);

            #endregion

            #region Kullanıcıdan alınan vize ve final notları üzerinden ortalamayı hesaplayarak ekrana yazdırınız.

            //Console.WriteLine("Vize notunuzu giriniz: ");
            //double vize = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Final notunuzu giriniz: ");
            //double final = Convert.ToDouble(Console.ReadLine());

            //double ortalama = (vize * 0.4) + (final * 0.6);
            //Console.WriteLine("Ortalama: " + ortalama);

            #endregion


            #region Tür Dönüşümü

            //string sayi = "566734676378463";
            //int s1 = Convert.ToInt32(sayi);
            //int sayi1 = int.Parse(sayi); // Convert komutunun alternatifi

            #endregion

            // *************** TÜR DÖNÜŞÜMLERİ - VERİ TİPİ DÖNÜŞÜMÜ ***************

            #region Bilinçli Tür Dönüşümü

            //*Sözel-Sayısal tipe dönüşüm
            //Console.WriteLine("Yaş:");
            //int yas = Convert.ToInt32(Console.ReadLine());

            //*Sayısal-Sözel tipe dönüşümü
            //int sayi = 12312;
            //string sayi2 = Convert.ToString(sayi);
            //string sayi3 = sayi.ToString(); //*** bu format çok popülerdir.

            #endregion


            #region Bilinçsiz Tür Dönüşümü

            //Küçük veri tipini Büyük veri tipine atama
            //int sayi = 10;
            //double sayi2 = sayi;

            //** BOXING()
            //Büyük veri tipini Küçük veri tipine atama
            //double sayi = 5;
            //int sayi2 = (int)sayi;


            //double sayi = 573654273654736;
            //long sayi2 = (long)sayi;

            //Console.WriteLine(sayi2);

            #endregion


            #region SCOPE
            //her tanım kendi {} içerisinde erişilebilir.
            //string tv = "LG";

            //{
            //    int sayi = 5;
            //    Console.WriteLine(tv);
            //}

            //{
            //    Console.WriteLine(sayi); //sayi tanımı farklı bir scope bulunduğu için erişilmezdir. 
            //    Console.WriteLine(tv);
            //}

            #endregion


            #region CONSTANT
            //const: sabit değişken

            //int sayi = 5;
            //int sayi = 15; //Hata: Aynı sisimde bir tanımlama yapıldı.

            //sayi = 15; //sayi değişkenin değeri revize edildi.

            //int sayi2 = 10; // Farklı bir değeri tutmak için değişken tanımlandı.


            //const int sayi = 10;
            //sayi = 15;
            #endregion

            Console.WriteLine("Hello World");

            Console.WriteLine("klsmdmadsmdsd");
        }

       

    }

    
}
