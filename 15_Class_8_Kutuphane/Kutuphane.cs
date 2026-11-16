using System;
using System.Collections.Generic;
using System.Text;

namespace _15_Class_8_Kutuphane
{
    internal class Kutuphane
    {
        internal static List<Uye> Uyeler = new List<Uye>();
        internal static List<Kitap> Kitaplar = new List<Kitap>();

        internal static void OduncAl()
        {
            Kitap.Listele(Kitaplar);

            Console.WriteLine("ISBN:");
            string ISBN = Console.ReadLine();

            Kitap oduncVerilecekKitap = Kitaplar.FirstOrDefault(i => i.ISBN == ISBN && i.Durum==true);

            if (oduncVerilecekKitap != null)
            {
                Console.WriteLine("Üye Numarası:");
                int no = Convert.ToInt32(Console.ReadLine());

                Uye uye = Uyeler.FirstOrDefault(i => i.UyeNo == no);

                if (uye != null)
                {
                    oduncVerilecekKitap.Durum = false;
                    uye.AldigiKitaplar.Add(oduncVerilecekKitap);
                }
                else
                {
                    Console.WriteLine("Üye Bulunamadı.");
                }
            }
            else
            {
                Console.WriteLine("Kitap Bulunamadı.");
            }
        } 

        internal static void OduncListele()
        {
            foreach (Kitap kitap in Kitaplar)
            {
                if (kitap.Durum == false)
                {
                    Console.WriteLine("ISBN:" + kitap.ISBN);
                    Console.WriteLine("Kitap Adı:" + kitap.Ad);
                    Console.WriteLine("Yazar Adı:" + kitap.Yazar);
                }
            }
        }
    }
}
