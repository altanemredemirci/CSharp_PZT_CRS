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
            // her öğrencinin ad ve yas bilgileri kayıt edilecek

            //Instance - Örneklem
            //Ogrenci ogrenci = new Ogrenci();

            //ogrenci.ad = "Ahmet";
            //ogrenci.yas = 13;

            //Ogrenci ogrenci2 = new Ogrenci();

            //ogrenci2.ad = "Meltem";
            //ogrenci2.yas = 13;

            //Ogrenci ogrenci3 = new Ogrenci();

            //ogrenci3.ad = "Beyza";
            //ogrenci3.yas = 13;


            //List<Ogrenci> ogrenciler = new List<Ogrenci>();

            //ogrenciler.Add(ogrenci);
            //ogrenciler.Add(ogrenci2);
            //ogrenciler.Add(ogrenci3);


            #endregion


            //Bir Üyelik sisteminde kullanıcı adı, şifre ve ad soyad tutulacak.
            //Kullanıcı giriş yapmak istediğinde kullanıcı adı ve şifre ile giriş yapılacak;

            List<Uye> uyeler = new List<Uye>();

            for (int i = 0; i < 3; i++)
            {
                Uye uye = new Uye(); // uye bir nesnedir ve tanımlı olduğu sınıfın özelliklerini taşır

                Console.WriteLine("Username:");
                uye.Username = Console.ReadLine();

                Console.WriteLine("Password:");
                uye.Password = Console.ReadLine();

                Console.WriteLine("NameSurname:");
                uye.NameSurname = Console.ReadLine();

                uyeler.Add(uye);
            }

            Console.WriteLine("Kullanıcı adınız:");
            string kullaniciadi = Console.ReadLine();

            Console.WriteLine("Şifreniz:");
            string sifre = Console.ReadLine();

            foreach (Uye uye in uyeler)
            {
                if(uye.Username==kullaniciadi && uye.Password == sifre)
                {
                    Console.WriteLine(uye.NameSurname);
                }
            }


        }
    }
}
