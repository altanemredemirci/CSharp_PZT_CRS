using System;
using System.Collections.Generic;
using System.Text;

namespace _16_Restaurant_Otomasyonu
{
    internal class Siparis
    {
        public int MasaNo { get; set; }
        public List<Yemek> Siparisler { get; set; }

        public Siparis()
        {
            Siparisler = new List<Yemek>();
        }

        internal static Yemek YemekSec(Menu secilenMenu)
        {
            foreach (Yemek item in secilenMenu.Yemekler)
            {
                Console.WriteLine(item.No+"-"+item.Ad+":"+item.Fiyat);
            }

            Console.WriteLine("Yemek No:");
            int yemekNo = Convert.ToInt32(Console.ReadLine());

            return secilenMenu.Yemekler.FirstOrDefault(i => i.No == yemekNo);
        }
    }
}
