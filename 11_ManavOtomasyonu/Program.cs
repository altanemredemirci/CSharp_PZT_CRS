using System.Collections;

namespace _11_ManavOtomasyonu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList halMeyve = new ArrayList() { "ELMA", "ARMUT", "MUZ" };
            ArrayList halSebze = new ArrayList() { "PATATES", "PATLICAN", "MARUL" };
            ArrayList manavMeyve = new ArrayList();
            ArrayList manavMeyveKilo = new ArrayList();
            ArrayList manavSebze = new ArrayList();
            ArrayList manavSebzeKilo = new ArrayList();

            ArrayList musteri = new ArrayList();

            while (true)
            {
                Console.WriteLine("HALE HOŞGELDİNİZ");
                Console.WriteLine("Meyve için M Sebze için S Çıkış için Ç seçiniz:");
                string halSecim = Console.ReadLine().ToUpper();

                if (halSecim == "M")
                {
                    #region Uzun Hali
                    //for (int index = 0; index < halMeyve.Count; index++)
                    //{
                    //    Console.WriteLine(index + 1 + "-" + halMeyve[index]);
                    //    //Console.WriteLine($"{index}-{halMeyve[index]}");
                    //}

                    //Console.WriteLine("Ürün Numarası:");
                    //int meyveSecim = Convert.ToInt32(Console.ReadLine()) - 1;

                    //if (meyveSecim >= 0 && meyveSecim < halMeyve.Count)
                    //{
                    //    string urun = halMeyve[meyveSecim].ToString();
                    //    Console.WriteLine("Kaç Kilo İstersiniz?");
                    //    int kilo = Convert.ToInt32(Console.ReadLine());

                    //    if (manavMeyve.Contains(urun) == false)
                    //    {
                    //        manavMeyve.Add(halMeyve[meyveSecim]);
                    //        manavMeyveKilo.Add(kilo);
                    //    }
                    //    else
                    //    {
                    //        int urunIndex = manavMeyve.IndexOf(urun);
                    //        int toplamKilo = (int)manavMeyveKilo[urunIndex] + kilo;

                    //        manavMeyveKilo[urunIndex] = toplamKilo;
                    //    }

                    //}
                    //else
                    //{
                    //    Console.WriteLine("Hatalı Ürün Seçimi!!");
                    //}
                    #endregion

                    HalUrunSec(halMeyve, manavMeyve, manavMeyveKilo);
                }
                else if (halSecim == "S") 
                {
                    #region UzunHali
                    //for (int index = 0; index < halSebze.Count; index++)
                    //{
                    //    Console.WriteLine(index + 1 + "-" + halSebze[index]);
                    //    //Console.WriteLine($"{index}-{halMeyve[index]}");
                    //}

                    //Console.WriteLine("Ürün Numarası:");
                    //int sebzeSecim = Convert.ToInt32(Console.ReadLine()) - 1;

                    //if (sebzeSecim >= 0 && sebzeSecim < halSebze.Count)
                    //{
                    //    string urun = halSebze[sebzeSecim].ToString();
                    //    Console.WriteLine("Kaç Kilo İstersiniz?");
                    //    int kilo = Convert.ToInt32(Console.ReadLine());

                    //    if (manavSebze.Contains(urun) == false)
                    //    {
                    //        manavSebze.Add(halMeyve[sebzeSecim]);
                    //        manavSebzeKilo.Add(kilo);
                    //    }
                    //    else
                    //    {
                    //        int urunIndex = manavSebze.IndexOf(urun);
                    //        int toplamKilo = (int)manavSebzeKilo[urunIndex] + kilo;

                    //        manavSebzeKilo[urunIndex] = toplamKilo;
                    //    }

                    //}
                    //else
                    //{
                    //    Console.WriteLine("Hatalı Ürün Seçimi!!");
                    //}                  
                    #endregion
                    HalUrunSec(halSebze, manavSebze, manavSebzeKilo);

                }
                else if (halSecim == "Ç")
                {
                    Console.WriteLine("Yine Bekleriz..");
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı Seçim!!");
                }

                Console.WriteLine("Başka Arzunuz Var Mı? E/H");
                string cevap = Console.ReadLine().ToUpper();

                if (cevap != "E")
                {
                    break;
                }
            }
        }

        static void HalUrunSec(ArrayList halListe,ArrayList manavListe, ArrayList manavKilo)
        {
            for (int index = 0; index < halListe.Count; index++)
            {
                Console.WriteLine(index + 1 + "-" + halListe[index]);
                //Console.WriteLine($"{index}-{halMeyve[index]}");
            }

            Console.WriteLine("Ürün Numarası:");
            int meyveSecim = Convert.ToInt32(Console.ReadLine()) - 1;

            if (meyveSecim >= 0 && meyveSecim < halListe.Count)
            {
                string urun = halListe[meyveSecim].ToString();
                Console.WriteLine("Kaç Kilo İstersiniz?");
                int kilo = Convert.ToInt32(Console.ReadLine());

                if (manavListe.Contains(urun) == false)
                {
                    manavListe.Add(halListe[meyveSecim]);
                    manavKilo.Add(kilo);
                }
                else
                {
                    int urunIndex = manavListe.IndexOf(urun);
                    int toplamKilo = (int)manavKilo[urunIndex] + kilo;

                    manavKilo[urunIndex] = toplamKilo;
                }
            }
            else
            {
                Console.WriteLine("Hatalı Ürün Seçimi!!");
            }
        }
    }
}

//URSSOFT TEKNOLOJİ A.Ş.
//IK,IT,MUH,SAT,PAZ,DEPO,30, 120, 35 = 900*35

// personel kayit,   (180*6)+ 35*6
// Personel Güncelle,
// personel Sil,
// personel listele,
// personel Bul     