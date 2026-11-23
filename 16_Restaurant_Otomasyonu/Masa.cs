using System;
using System.Collections.Generic;
using System.Text;

namespace _16_Restaurant_Otomasyonu
{
    internal class Masa
    {
        public int No { get; set; }
        public bool DoluMu { get; set; } = false;
        public double Hesap { get; set; }

        internal static Masa MasaDoldur(List<Masa> liste)
        {
            foreach (Masa item in liste)
            {
                if (item.DoluMu == false)
                {
                    item.DoluMu = true;
                    return item;
                }
            }

            return null;
        }

        internal static void MasaDurumu(List<Masa> liste)
        {
            foreach (Masa item in liste)
            {
                Console.WriteLine(item.No+"- Dolu Mu:"+(item.DoluMu==false ? "Boş" : "Dolu"));
            }
        }

        internal static int HesapOde(List<Siparis> siparisler, List<Masa> masalar, ref double kazanc)
        {
            Console.WriteLine("Masa No:");
            int masaNo = Convert.ToInt32(Console.ReadLine());

            foreach (Siparis item in siparisler)
            {
                if (item.MasaNo == masaNo)
                {
                    double hesap = item.Siparisler.Select(i => i.Fiyat).Sum();

                    Console.WriteLine("Hesap:"+hesap);
                    Console.WriteLine("Ödendi Mi?(E/H)");
                    string cevap = Console.ReadLine().ToUpper();
                    if (cevap == "E")
                    {
                        kazanc += hesap;
                        siparisler.Remove(item);

                        Masa masa = masalar.FirstOrDefault(i => i.No = masaNo);
                        masa.DoluMu = false;
                        return 1;
                    }

                    return -100;
                }
            }

            return -101;
        }
    }
}
