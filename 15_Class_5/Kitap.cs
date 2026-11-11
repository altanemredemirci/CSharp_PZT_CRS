using System;
using System.Collections.Generic;
using System.Text;

namespace _15_Class_5
{
    internal class Kitap
    {
        public int Barkod;
        public string YazarAdi;
        public string KitapAdi;

        public static void Kaydet(List<Kitap> liste)
        {
            Kitap kitap = new Kitap();

            Console.WriteLine("Barkod No:");
            kitap.Barkod = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kitap Adı:");
            kitap.KitapAdi = Console.ReadLine();

            Console.WriteLine("Yazar Adı:");
            kitap.YazarAdi = Console.ReadLine();

            liste.Add(kitap);
        }

        public static void Listele(List<Kitap> liste)
        {
            foreach (Kitap kitap in liste)
            {
                Console.WriteLine(kitap.Barkod);
                Console.WriteLine(kitap.KitapAdi);
                Console.WriteLine(kitap.YazarAdi);
            }
        }
    }
}
