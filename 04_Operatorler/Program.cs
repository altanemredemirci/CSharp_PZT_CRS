namespace _04_Operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region MATEMATİKSEL OPERATORLER(+,-,*,/,%)

            //int sayi = 10;
            //double sayi2 = 4.0;

            //Console.WriteLine(sayi+sayi2);
            //Console.WriteLine(sayi-sayi2);
            //Console.WriteLine(sayi*sayi2);
            //Console.WriteLine(sayi/sayi2);

            //Mod Alma %
            //Kullanıcıdan bir sayı alınız tek ise ekrana TEK çift ise ekrana ÇİFT yazdırınız
            //Console.WriteLine("Sayı:");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //string sonuc = sayi % 2 == 0 ? "ÇİFT" : "TEK";
            //Console.WriteLine(sonuc);

            #endregion

            #region ATAMA OPERATORLER(=) İŞLEMLİ ATAMA

            //int sayi = 10;

            //sayi += 5;   //sayi = sayi + 5; 
            //sayi -= 5;   //sayi = sayi - 5; 
            //sayi *= 5;   //sayi = sayi * 5; 
            //sayi /= 5;   //sayi = sayi / 5; 

            #endregion

            #region BİR ARTTIRMA VE BİR AZALTMA OPERATORLERİ

            //int sayi = 5;

            //sayi++;
            //sayi--;
            //Console.WriteLine(sayi);

            //int a = 5;
            //int b = a++;
            //int c = ++b;

            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);



            #endregion

            #region KARŞILAŞTIRMA OPERATORLERİ

            //int a = 10;
            //int b = 15;

            //bool sonuc = a > b;
            //bool sonuc2 = a < b;
            //bool sonuc3 = a >= b;
            //bool sonuc4 = a <= b;
            //bool sonuc5 = a == b; //a ve b eşit mi?
            //bool sonuc6 = a != b; // a ve b eşit değil mi?

            //string username = "altanemre";

            //Console.WriteLine("Username:");
            //string kullaniciAdi = Console.ReadLine();

            //bool giris = username == kullaniciAdi;

            //Console.WriteLine("Giriş:"+giris);

            #endregion

            #region KIYAS OPERATORU(? :)

            //Bir karşılaştırma doğru(True) ve yanlış(False) durumlarında ne döneceğini belirleriz

            //int sayi = 5;

            //string sonuc = sayi > 4 ? "Büyük" : "Küçük";

            //int sonuc2 = sayi < 6 ? 1 : 0;


            #endregion

            #region ERİŞİM OPERATORU(.)

            //Console.WriteLine();

            //Convert.ToInt16();

            #endregion

            #region MANTIKSAL OPERATORLER

            #region AND &&

            //Birden fazla karşılaştırmanın yapıldığı ve sonucun geçerli olması için bütün karşılaştırmaların True olması gerekiyorsa kuıllanılır.

            //string username = "altanemre";
            //string password = "123";

            //Console.WriteLine("Kullanıcı Adı:");
            //string kullaniciAdi = Console.ReadLine();

            //Console.WriteLine("Şifre:");
            //string sifre = Console.ReadLine();
            /*
             1.durum    2.durum     sonuc
                F           F         F
                T           F         F
                F           T         F
                T           T         T  
             */


            //Kullanıcının başarılı giriş yapabilmesi için kullanıcı adı ve şifrenin eşleşmesi lazım

            //bool sonuc = username == kullaniciAdi && password==sifre;

            //Console.WriteLine(sonuc);




            #endregion

            #region OR ||

            //Birden fazla karşılaştırmanın yapıldığı ve sonucun geçerli olması için herhangi bir karşılaştırmanın True olması yeterliyse kuıllanılır.

            //string username = "altanemre";
            //string email = "altanemre@gmail.com";
            //string password = "123";


            //Console.WriteLine("Username/Email:");
            //string kullanici = Console.ReadLine();

            //Console.WriteLine("Password:");
            //string sifre = Console.ReadLine();


            //bool sonuc = (username == kullanici || email == kullanici) && password==sifre;

            //Console.WriteLine(sonuc);

            #endregion

            #region NOT !

            bool sonuc = 5 > 4;

            Console.WriteLine(!sonuc);

            #endregion

            #endregion
        }
    }
}
