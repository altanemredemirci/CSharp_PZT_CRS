using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_List
{
    internal class Ogrenci
    {
        //Data Access Modifier - Erişim belirteci
        //public:Bütün Solution içinde erişilebilir.
        //internal:Sadece kendi Projesi içinde erişilebilir.
        //private:Sadece kendi tanımlı olduğu class içinde erişilebilir.
        
        //Default olarak private tanımlıdır
        public string Ad;
        public string Soyad;
        public int Numara;


        //Parametreli Değer Döndürmeyen Metot
        public static void Kayit1(List<Ogrenci> liste)
        {

            Ogrenci ogr = new Ogrenci();

            Console.WriteLine("Öğrenci Numarası:");
            ogr.Numara = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Öğrenci Adı:");
            ogr.Ad = Console.ReadLine();

            Console.WriteLine("Öğrenci Soyadı:");
            ogr.Soyad = Console.ReadLine();

            liste.Add(ogr);

        }

        //Parametresiz Değer Döndüren Metot
        public static Ogrenci Kayit2()
        {

            Ogrenci ogr = new Ogrenci();

            Console.WriteLine("Öğrenci Numarası:");
            ogr.Numara = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Öğrenci Adı:");
            ogr.Ad = Console.ReadLine();

            Console.WriteLine("Öğrenci Soyadı:");
            ogr.Soyad = Console.ReadLine();

            return ogr;

        }

    }
}
