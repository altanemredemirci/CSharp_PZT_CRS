using System.Collections;

namespace _11_ManavOtomasyonu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            ﻿﻿******** MANAV OTOMASYONU *********
           1.Toptancı,Manav ve Müşteri alanlarımız olacak
           2.Manav toptancıdan isteğine göre meyve,sebze alacak ve müşteri de manavın toptancıdan aldığı   ürünleri alabilecek.
           3.Toptancı için meyve ve sebze programın başında tanımlanacak.(Dolu liste yapılacak)
           4.Manav için meyve sebze listeleri boş olarak tanımlanacak
           5.Müşteri için tek liste yeterli boş olarak
           6.Program başladığında HALE HOŞGELDİNİZ Meyve için M Sebze için S ye basınız.
           7.M tuşuna basıldıysa Toptancının meyve listesi S tuşuna basıldıysa Toptancının sebze listesi   ekrana yazdırıp manavın bir ürün alması istenecek
           8.Mesela Elma istediyse manavın meyveler listesine elma değeri eklenecek ve kaç kilo diye   sorularak kilo alınacak
           9.Başka bir arzunu var mı? Evet E veya Hayır H
           10.Evet dendiyse Tekrar 6. adıma gidilecek ve işlemler tekrar edilecek
           11.Hayır dendiyse MANAVA HOŞGELDİNİZ Meyve için M Sebze için S ye basınız.
           12.Manav Bölümünde müşteri M bastı diyelim 
           13.Manavın toptancıdan aldığı meyveler listelenecek ve müşterinin bir meyve girmesi beklenecek
           14.Mesela Elma istediyse kaç kilo diye sorularak kilo alınacak
           15.Müşterinin istediği kilo ile manavın toptancıdan aldığı elmanın kilosu karşılaştırılacak 
           16.Eğer manavın elinde yeterli miktarda elma varsa müşterinin listesine elma değeri eklenecek
           17.Başka bir arzunu var mı? Evet E veya Hayır H
           18.Evet dendiyse Tekrar 11. adıma gidilecek ve işlemler tekrar edilecek
           19.Hayır dendiyse Müşteri listesi ekrana yazdırılsın.

            */

            ArrayList halMeyve = new ArrayList() { "ELMA", "ARMUT", "KİRAZ" };
            ArrayList halSebze = new ArrayList() { "PATLICAN", "PATATES", "SOĞAN" };

            ArrayList manavMeyve = new ArrayList();
            ArrayList manavSebze = new ArrayList();

            ArrayList manavMeyveKilo = new ArrayList();
            ArrayList manavSebzeKilo = new ArrayList();

            ArrayList musteri = new ArrayList();

            while (true)
            {
                Console.WriteLine("****** HALE HOŞGELDİNİZ ******");
                Console.WriteLine("Meyve M - Sebze S - Çıkış Q - Seçiminiz:");
                string secim = Console.ReadLine().ToUpper();

                if (secim == "M") 
                {
                    for (int i = 0; i < halMeyve.Count; i++)
                    {
                        Console.WriteLine($"{i}-{halMeyve[i]}");
                    }

                    Console.Write("Satın alınacak ürün numarası:");
                    int urunNo = Convert.ToInt32(Console.ReadLine());

                    if(urunNo>=0 && urunNo < halMeyve.Count)
                    {
                        string urun = (string)halMeyve[urunNo]; //Boxing:gelecek tipin string olduğunu belirttik.

                        Console.WriteLine($"Kaç kilo {urun} istersiniz?");
                        int kilo = Convert.ToInt32(Console.ReadLine());

                        if (!manavMeyve.Contains(urun))
                        {
                            manavMeyve.Add(urun);
                            manavMeyveKilo.Add(kilo);
                        }
                        else
                        {
                            int index = manavMeyve.IndexOf(urun);

                            manavMeyveKilo[index] = (int)manavMeyveKilo[index] + kilo;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Hatalı Ürün Seçimi!");
                    }
                }
                else if (secim == "S") 
                {
                    for (int i = 0; i < halSebze.Count; i++)
                    {
                        Console.WriteLine($"{i}-{halSebze[i]}");
                    }

                    Console.Write("Satın alınacak ürün numarası:");
                    int urunNo = Convert.ToInt32(Console.ReadLine());

                    if (urunNo >= 0 && urunNo < halSebze.Count)
                    {
                        string urun = (string)halSebze[urunNo]; //Boxing:gelecek tipin string olduğunu belirttik.

                        Console.WriteLine($"Kaç kilo {urun} istersiniz?");
                        int kilo = Convert.ToInt32(Console.ReadLine());

                        if (!manavSebze.Contains(urun))
                        {
                            manavSebze.Add(urun);
                            manavSebzeKilo.Add(kilo);
                        }
                        else
                        {
                            int index = manavSebze.IndexOf(urun);

                            manavSebzeKilo[index] = (int)manavSebzeKilo[index] + kilo;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Hatalı Ürün Seçimi!");
                    }
                }
                else if (secim == "Q")
                {
                    Console.WriteLine("Yine Bekleriz...");
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı Seçim!!");
                }

                Console.WriteLine("Başka bir arzunuz var mı?(E/H)");
                string cevap = Console.ReadLine().ToUpper();
                if (cevap == "E")
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Yine Bekleriz...");
                    break;
                }
            }

            while (true)
            {
                Console.WriteLine("****** MANAV HOŞGELDİNİZ ******");
                Console.WriteLine("Meyve M - Sebze S - Çıkış Q - Seçiminiz:");
                string secim = Console.ReadLine().ToUpper();

                if (secim == "M") 
                {
                    if (manavMeyve.Count == 0)
                    {
                        Console.WriteLine("Meyveler Tükenmiştir :(");
                        continue;
                    }

                    for (int i = 0; i < manavMeyve.Count; i++)
                    {
                        Console.WriteLine($"{i}-{manavMeyve[i]}");
                    }

                    Console.Write("Satın alınacak ürün numarası:");
                    int urunNo = Convert.ToInt32(Console.ReadLine());

                    if(urunNo>=0 && urunNo < manavMeyve.Count)
                    {
                        string urun = (string)manavMeyve[urunNo];
                        int mevcutKilo = (int)manavMeyveKilo[urunNo];

                        Console.WriteLine($"Kaç kilo {urun} istersiniz?");
                        int kilo = Convert.ToInt32(Console.ReadLine());

                        if (mevcutKilo >= kilo)
                        {
                            Console.WriteLine("Afiyet Olsun.");

                            musteri.Add(urun);
                            int yeniKilo = mevcutKilo - kilo;

                            if (yeniKilo == 0)
                            {
                                manavMeyve.RemoveAt(urunNo);
                                manavMeyveKilo.RemoveAt(urunNo);
                            }
                            else
                            {
                                manavMeyveKilo[urunNo] = yeniKilo;
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Yetersiz Kilo! Elimizde {mevcutKilo} kilo {urun} var");
                        }


                    }
                    else
                    {
                        Console.WriteLine("Hatalı Ürün Seçimi!!");
                    }
                }
                else if (secim == "S") 
                {
                    if (manavSebze.Count == 0)
                    {
                        Console.WriteLine("Sebzeler Tükenmiştir :(");
                        continue;
                    }

                    for (int i = 0; i < manavSebze.Count; i++)
                    {
                        Console.WriteLine($"{i}-{manavSebze[i]}");
                    }

                    Console.Write("Satın alınacak ürün numarası:");
                    int urunNo = Convert.ToInt32(Console.ReadLine());

                    if (urunNo >= 0 && urunNo < manavSebze.Count)
                    {
                        string urun = (string)manavSebze[urunNo];
                        int mevcutKilo = (int)manavSebzeKilo[urunNo];

                        Console.WriteLine($"Kaç kilo {urun} istersiniz?");
                        int kilo = Convert.ToInt32(Console.ReadLine());

                        if (mevcutKilo >= kilo)
                        {
                            Console.WriteLine("Afiyet Olsun.");

                            musteri.Add(urun);
                            int yeniKilo = mevcutKilo - kilo;

                            if (yeniKilo == 0)
                            {
                                manavSebze.RemoveAt(urunNo);
                                manavSebzeKilo.RemoveAt(urunNo);
                            }
                            else
                            {
                                manavSebzeKilo[urunNo] = yeniKilo;
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Yetersiz Kilo! Elimizde {mevcutKilo} kilo {urun} var");
                        }


                    }
                    else
                    {
                        Console.WriteLine("Hatalı Ürün Seçimi!!");
                    }
                }
                else if (secim == "Q") { }
                else 
                {
                    Console.WriteLine("Hatalı Seçim!!");
                }

                Console.WriteLine("Başka bir arzunuz var mı?(E/H)");
                string cevap = Console.ReadLine().ToUpper();
                if (cevap == "E")
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Yine Bekleriz...");
                    break;
                }
            }

            foreach (string item in musteri)
            {
                Console.WriteLine(item);
            }
        }
    }
}
