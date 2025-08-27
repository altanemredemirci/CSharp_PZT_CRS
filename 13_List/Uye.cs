using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_List
{
    internal class Uye
    {
        public string Username;
        public string Password;
        public string NameSurname;

        public static void KayitOl(List<Uye> liste)
        {
            Uye uye = new Uye(); // uye bir nesnedir ve tanımlı olduğu sınıfın özelliklerini taşır

            Console.WriteLine("Username:");
            uye.Username = Console.ReadLine();

            Console.WriteLine("Password:");
            uye.Password = Console.ReadLine();

            Console.WriteLine("NameSurname:");
            uye.NameSurname = Console.ReadLine();

            liste.Add(uye);
        }

        public static Uye GirisYap(List<Uye> liste)
        {
            Console.WriteLine("Username:");
            string username = Console.ReadLine();
            Console.WriteLine("Password:");
            string password = Console.ReadLine();

            foreach (Uye uye in liste)
            {
                if(uye.Password==password && uye.Username == username)
                {
                    Console.WriteLine("Giriş Başarılı");
                    return uye;
                }
            }

            return null;

        }

        public static void Listele(List<Uye> liste)
        {
            foreach (Uye item in liste)
            {
                Console.WriteLine($"{item.NameSurname}-{item.Username}");
            }
        }

    }
}
