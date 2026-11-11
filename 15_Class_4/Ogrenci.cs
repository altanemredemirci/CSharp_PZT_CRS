using System;
using System.Collections.Generic;
using System.Text;

namespace _15_Class_4
{
    internal class Ogrenci
    {
        public int No;
        public string Ad;
        public string Soyad;

        public static void Kaydet(List<Ogrenci> liste)
        {
            Ogrenci ogrenci = new Ogrenci();

            Console.WriteLine("No:");
            ogrenci.No = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Ad:");
            ogrenci.Ad = Console.ReadLine();

            Console.WriteLine("Soyad:");
            ogrenci.Soyad = Console.ReadLine();

            liste.Add(ogrenci);
        }

        public void Kaydet2()
        {
            //this metodun çağrıldığı nesneyi işaret eder.
            Console.WriteLine("No:");
            this.No = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ad:");
            this.Ad = Console.ReadLine();

            Console.WriteLine("Soyad:");
            this.Soyad = Console.ReadLine();
        }

    }
}
