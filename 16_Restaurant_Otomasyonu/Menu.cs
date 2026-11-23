using System;
using System.Collections.Generic;
using System.Text;

namespace _16_Restaurant_Otomasyonu
{
    internal class Menu
    {
        public int No { get; set; }
        public string Ad { get; set; }
        public List<Yemek> Yemekler { get; set; }

        internal static Menu MenuSec(List<Menu> liste)
        {
            foreach (Menu item in liste)
            {
                Console.WriteLine(item.No+"-"+item.Ad);
            }

            Console.WriteLine("Menü No:");
            int menuNo = Convert.ToInt32(Console.ReadLine());

            return liste.FirstOrDefault(i => i.No == menuNo);
        }
    }
}
