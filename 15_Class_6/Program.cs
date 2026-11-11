namespace _15_Class_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Listeye Üye Ekleme 1. Yol
            //List<User> userList = new List<User>();

            //#region 1.Yol
            //User user = new User();
            //user.Username = "altanemre";
            //user.Email = "altanemre@gmail.com";
            //user.Password = "123";

            //userList.Add(user);
            //#endregion

            //#region 2.Yol
            //User user2 = new User()
            //{
            //    Username = "sercan",
            //    Email = "sercan@gmail.com",
            //    Password = "123"
            //};

            //userList.Add(user2);
            //#endregion
            #endregion


            List<User> userList = new List<User>()
            {
                new User(){Username="altanemre",Email="altanemre@gmail.com",Password="1"},
                new User(){Username="uras",Email="uras@gmail.com",Password="1"},
                new User(){Username="kivanc",Email="kivanc@gmail.com",Password="1"}
            };

            //List<int> sayilar = new List<int>() { 11, 22, 33, 44 };

            while (true)
            {
                Console.WriteLine("1-Üye Ekle\n2-Üye Sil\n3-Listele\n4-Güncelle\nSeçiminiz:");
                int secim = Convert.ToInt32(Console.ReadLine());

                if (secim == 1) { }
                else if (secim == 2) 
                {
                    User.Sil(userList);                
                }
                else if (secim == 3)
                {
                    User.Listele(userList);
                }
                else if (secim == 4)
                {
                    User.Guncelle(userList);
                }
            }
        }
    }

    class User 
    {
        public string Username;
        public string Password;
        public string Email;

        public static void Kaydet(List<User> liste)
        {
            User user = new User();

            Console.WriteLine("Username:");
            user.Username = Console.ReadLine();

            Console.WriteLine("Email:");
            user.Email = Console.ReadLine();

            Console.WriteLine("Password:");
            user.Password = Console.ReadLine();

            liste.Add(user);
        }

        public static void Sil(List<User> liste)
        {
            foreach (User user in liste)
            {
                Console.WriteLine(user.Username+":"+user.Email);
            }

            Console.WriteLine("Silinecek üyenin kullanıcı adı:");
            string kullaniciAdi = Console.ReadLine();

            //foreach (User user in liste)
            //{
            //    if (user.Username == kullaniciAdi)
            //    {
            //        liste.Remove(user);
            //        Console.WriteLine("Kayıt silindi.");
            //        return;
            //    }
            //}

            //Console.WriteLine("Kayıt Silinemedi.");

            User silinecekKullanici = liste.FirstOrDefault(i => i.Username == kullaniciAdi);

            if(silinecekKullanici != null) //kullanıcı bulunamaz ise null(boş) döner.
            {
                liste.Remove(silinecekKullanici);
                Console.WriteLine("Kayıt Silindi.");
            }
            else
            {
                Console.WriteLine("Kayıt Silinemedi.");
            }
        }

        public static void Listele(List<User> liste)
        {
            foreach (User user in liste)
            {
                Console.WriteLine(user.Username + ":" + user.Email);
            }
        }

        public static void Guncelle(List<User> liste)
        {
            Listele(liste);

            Console.WriteLine("Güncellenecek kullanıcı adı:");
            string kullaniciAdi = Console.ReadLine();

            User guncelKullanici = liste.FirstOrDefault(i => i.Username == kullaniciAdi);

            if (guncelKullanici != null)
            {
                Console.WriteLine("Güncel Username:");
                guncelKullanici.Username = Console.ReadLine();

                Console.WriteLine("Güncel Email:");
                guncelKullanici.Email = Console.ReadLine();

                Console.WriteLine("Kayıt Güncellendi.");
            }
            else
            {
                Console.WriteLine("Kayıt Güncellenemedi.");
            }
        }
    }
}
