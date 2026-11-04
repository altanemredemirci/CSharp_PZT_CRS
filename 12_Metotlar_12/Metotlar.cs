using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _12_Metotlar_12
{
    internal class Metotlar
    {
        internal static void HalUrunAl(ArrayList halListesi,ArrayList manavListesi, ArrayList manavKiloListesi)
        {
            for (int i = 0; i < halListesi.Count; i++)
            {
                Console.WriteLine($"{i}-{halListesi[i]}");
            }

            Console.WriteLine("Satın alınacak ürün numarası:");
            int urunNo = Convert.ToInt32(Console.ReadLine());

            if(urunNo>=0 && urunNo < halListesi.Count)
            {
                string urun = (string)halListesi[urunNo];

                Console.WriteLine($"Kaç kilo {urun} istersiniz?");
                int kilo = Convert.ToInt32(Console.ReadLine());

                if (!manavListesi.Contains(urun))
                {
                    manavKiloListesi.Add(kilo);
                    manavListesi.Add(urun);
                }
                else
                {
                    int index = manavListesi.IndexOf(urun);

                    manavKiloListesi[index] = (int)manavKiloListesi[index] + kilo;
                }
            }
            else
            {
                Console.WriteLine("Hatalı Ürün Seçimi!!");
            }
        }

        internal static void ManavUrunAl(ArrayList manavListesi, ArrayList musteriListesi, ArrayList manavKiloListesi)
        {
            for (int i = 0; i < manavListesi.Count; i++)
            {
                Console.WriteLine($"{i}-{manavListesi[i]}");
            }

            Console.WriteLine("Satın alınacak ürün numarası:");
            int urunNo = Convert.ToInt32(Console.ReadLine());

            if (urunNo >= 0 && urunNo < manavListesi.Count)
            {
                string urun = (string)manavListesi[urunNo];

                int mevcutKilo = (int)manavKiloListesi[urunNo];

                Console.WriteLine($"Kaç kilo {urun} istersiniz?");
                int kilo = Convert.ToInt32(Console.ReadLine());

                if (mevcutKilo >= kilo)
                {
                    Console.WriteLine("Afiyet Olsun.");

                    musteriListesi.Add(urun);

                    int yeniKilo = mevcutKilo - kilo;

                    if (yeniKilo == 0)
                    {
                        manavKiloListesi.RemoveAt(urunNo);
                        manavListesi.RemoveAt(urunNo);
                    }
                    else
                    {
                        manavKiloListesi[urunNo] = yeniKilo;
                    }

                }
                else
                {
                    Console.WriteLine("Yetersiz Stok!!");
                }
                
            }
            else
            {
                Console.WriteLine("Hatalı Ürün Seçimi!!");
            }
        }
    }
}
