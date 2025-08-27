using System.Collections;

namespace _13_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region List Tanımı
            //int[] sayilar = new int[10]; //Dizide veritipi ve kapasite tanımlanması zorunlu

            //ArrayList arrayList = new ArrayList(); //Dizide veritipi ve kapasite tanımlanmaz

            //List<string> isimler = new List<string>(); //Veri tipi tanımlı ama kapasite sınırlaması yok

            //isimler.Add("Altan");
            //isimler.Add("Emre");


            //List<string> adlar = new List<string>() { "Beyza", "Eray" };


            //adlar.AddRange(isimler);



            //foreach (var item in adlar)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion


            #region Ogrenci 

            // Bir ilkokul öğrenci kayıt sistemini yazınız.
            // her öğrencinin ad,soyad ve numara bilgileri kayıt edilecek

            List<Ogrenci> ogrenciler = new List<Ogrenci>();

            Ogrenci.Kayit1(ogrenciler);
                                       

            ogrenciler.Add(Ogrenci.Kayit2());
            #endregion


            #region Uye
            //Bir Üyelik sisteminde kullanıcı adı, şifre ve ad soyad tutulacak.
            //Kullanıcı giriş yapmak istediğinde kullanıcı adı ve şifre ile giriş yapılacak;

            List<Uye> uyeler = new List<Uye>();

            #region Eski Yol
            //for (int i = 0; i < 3; i++)
            //{
            //    Uye uye = new Uye(); // uye bir nesnedir ve tanımlı olduğu sınıfın özelliklerini taşır

            //    Console.WriteLine("Username:");
            //    uye.Username = Console.ReadLine();

            //    Console.WriteLine("Password:");
            //    uye.Password = Console.ReadLine();

            //    Console.WriteLine("NameSurname:");
            //    uye.NameSurname = Console.ReadLine();

            //    uyeler.Add(uye);
            //}






            //Console.WriteLine("Kullanıcı adınız:");
            //string kullaniciadi = Console.ReadLine();

            //Console.WriteLine("Şifreniz:");
            //string sifre = Console.ReadLine();

            //foreach (Uye uye in uyeler)
            //{
            //    if(uye.Username==kullaniciadi && uye.Password == sifre)
            //    {
            //        Console.WriteLine(uye.NameSurname);
            //    }
            //}
            #endregion

            //while (true)
            //{
            //    Console.WriteLine("1-Üye Ol\n2-Giriş Yap\n3-Liste\nSeçiminiz:");
            //    int secim = Convert.ToInt32(Console.ReadLine());


            //    if (secim == 1)
            //    {
            //        Uye.KayitOl(uyeler);
            //    }
            //    else if (secim == 2)
            //    {
            //        Uye girisYapanUye = Uye.GirisYap(uyeler);
            //        Console.WriteLine(girisYapanUye.NameSurname);

            //        Console.WriteLine(girisYapanUye.Username);
            //    }
            //    else if (secim == 3)
            //    {
            //        Uye.Listele(uyeler);
            //    }
            //}
            #endregion


        }
    }
}
