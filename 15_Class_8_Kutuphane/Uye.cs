using System;
using System.Collections.Generic;
using System.Text;

namespace _15_Class_8_Kutuphane
{
    internal class Uye
    {
        internal int UyeNo;
        internal string AdSoyad;
        internal List<Kitap> AldigiKitaplar;

        public Uye()
        {
            AldigiKitaplar = new List<Kitap>();
        }

        internal static void Ekle(List<Uye> liste)
        {
            Uye uye = new Uye();

            Console.WriteLine("Üye No:");
            uye.UyeNo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ad Soyad:");
            uye.AdSoyad = Console.ReadLine();

            liste.Add(uye);
        }

        internal static void Listele(List<Uye> liste)
        {
            foreach (Uye item in liste)
            {
                Console.WriteLine("Üye No:"+item.UyeNo);
                Console.WriteLine("Ad Soyad:"+item.AdSoyad);

                if (item.AldigiKitaplar.Count > 0)
                {
                    foreach (Kitap kitap in item.AldigiKitaplar)
                    {
                        Console.WriteLine("ISBN:" + kitap.ISBN);
                        Console.WriteLine("Kitap Adı:" + kitap.Ad);
                        Console.WriteLine("Yazar Adı:" + kitap.Yazar);
                    }
                }
            }
        }

    }
}
