namespace _05_Karar_Yapilari
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region  ************ IF ELSEIF ELSE ************

            /*
             
            Kod içerisinde ture veya false olarak cevaplanacak ve bu cevap kodun ne yapacağına karar verecek ise if,else if,else blokları kullanılır.
            Her zaman ilk koşul if deyimi ile kontrol edilir.
            If dışında kalan koşullar için else if deyimi kullanılır.
            If ve else if dışında kalan alternatif koşulların tümü içine else kullanılır.
             */

            //Kullanıcıdan alınan bir sayının pozitif, negatif veya 0 olduğunu ekrana yazdırınız.

            //Console.WriteLine("Sayı:");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //if (sayi > 0)
            //{
            //    Console.WriteLine("Pozitif");
            //}

            //else if (sayi < 0)
            //{
            //    Console.WriteLine("Negatif");
            //}
            //else
            //{
            //    Console.WriteLine("Sıfır");
            //}


            //Console.WriteLine("Sayı:");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //if(sayi>0 && sayi < 11)
            //{
            //    Console.WriteLine("1-10 aralığında");
            //}
            //else if(sayi>10 && sayi < 21)
            //{
            //    Console.WriteLine("11-20 aralığında");
            //}
            //else if (sayi > 20 && sayi < 31)
            //{
            //    Console.WriteLine("21-30 aralığında");
            //}
            //else if (sayi > 30 && sayi < 41)
            //{
            //    Console.WriteLine("31-40 aralığında");
            //}
            //else
            //{
            //    Console.WriteLine("Aralık Dışı");
            //}

            #region Haftanın kaçıncı gününde olduğumuzu rakam olarak kullanıcıdan alarak ekrana gün adını yazıdırınız.
            #region Feyzanur

            //Console.WriteLine("haftanın kaçıncı günü:");
            //int gun = Convert.ToInt32(Console.ReadLine());

            //if (gun == 1)
            //{
            //    Console.WriteLine("pazartesi");
            //}
            //else if (gun == 2)
            //{
            //    Console.WriteLine("salı");
            //}
            //else if (gun == 3)
            //{
            //    Console.WriteLine("çarşamba");
            //}
            //else if (gun == 4)
            //{
            //    Console.WriteLine("perşembe");
            //}
            //else if (gun == 5)
            //{
            //    Console.WriteLine("cuma");
            //}
            //else if (gun == 6)
            //{
            //    Console.WriteLine("cumartesi");
            //}
            //else if (gun == 7)
            //{
            //    Console.WriteLine("pazar");
            //}
            //else
            //{
            //    Console.WriteLine("aralık dışı 1 - 7 arası giriniz");
            //}

            #endregion

            //DON:
            //    Console.WriteLine("haftanın kaçıncı günü:");
            //    int gun = Convert.ToInt32(Console.ReadLine());

            //    if(gun<1 || gun > 7)
            //    {
            //        Console.WriteLine("Hafta 7 günden oluşur.");
            //        goto DON;

            //    }
            //    else //1-7
            //    {
            //        if (gun == 1)
            //        {
            //            Console.WriteLine("pazartesi");
            //        }
            //        else if (gun == 2)
            //        {
            //            Console.WriteLine("salı");
            //        }
            //        else if (gun == 3)
            //        {
            //            Console.WriteLine("çarşamba");
            //        }
            //        else if (gun == 4)
            //        {
            //            Console.WriteLine("perşembe");
            //        }
            //        else if (gun == 5)
            //        {
            //            Console.WriteLine("cuma");
            //        }
            //        else if (gun == 6)
            //        {
            //            Console.WriteLine("cumartesi");
            //        }
            //        else
            //        {
            //            Console.WriteLine("pazar");
            //        }
            //    }




            #endregion
            #region Kullanıcıdan 2 ürün fiyatı isteyin. Bu ürün fiyatlarının toplamı 2500 tl geçerse ucuz olan ürüne %25 indirim uygulayarak toplam ödeme miktarını ekrana yazdırınız

            #region Feyzanur

            //Console.WriteLine("1. ürün fiyatı:");
            //double urun1 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("2. ürün:");
            //double urun2 = Convert.ToDouble(Console.ReadLine());

            //double toplam = urun1 + urun2;

            //if (toplam > 2500)
            //{
            //    if (urun1 < urun2)
            //    {
            //        urun1 -= urun1 * 0.25; //urun = urun-(urun*.025)
            //    }
            //    else
            //    {
            //        urun2 -= urun2 * 0.25;
            //    }

            //    toplam = urun1 + urun2;
            //}

            //Console.WriteLine(toplam);

            #endregion

            #endregion
            #region Aylık Geliri 40000 üzerinde ise %12, aylık geliri 40000 ve altında ise %9 vergi kesintisi yapılarak yeni gelir ekrana yazdırılsın
            #region Feyzanur

            //Console.WriteLine("aylık gelir : ");
            //double aylikGelir = Convert.ToDouble(Console.ReadLine());

            //if (aylikGelir > 40000)
            //{
            //    aylikGelir -= aylikGelir * 0.12;

            //    //aylikGelir = aylikGelir * 0.88;
            // }
            //else
            //{
            //    aylikGelir -= aylikGelir * 0.09;
            // }
            //Console.WriteLine(aylikGelir);

            #endregion
            #endregion
            #region Kullanıcıdan alınan vize ve final notlarının ortalamasını vize%40 final%60 üzerinden hesaplayınız.Ortalamaya göre harf notunu ekrana yazdırınız
            /*
             0-24 FF
             25-44 DD
             45-54 CC
             55-69 CB
             70-84 BB
             85-100 AA
             */
            //VIZE:
            //    Console.WriteLine("vize notu: ");
            //    double vize = Convert.ToDouble(Console.ReadLine());


            //    if(vize<0 || vize>100)
            //    {
            //        Console.WriteLine("Vize Not Aralığı Hatalı");
            //        goto VIZE;
            //    }
            //    else
            //    {
            //    FINAL:
            //        Console.WriteLine("final notu: ");
            //        double final = Convert.ToDouble(Console.ReadLine());

            //        if (final < 0 || final > 100)
            //        {
            //            Console.WriteLine("Final Not Aralığı Hatalı");
            //            goto FINAL;
            //        }
            //        else
            //        {
            //            double ort = vize * 0.40 + final * 0.60;

            //            if (ort >= 0 && ort < 25)
            //            {
            //                Console.WriteLine("FF");
            //            }
            //            else if (ort >= 25 && ort < 45)
            //            {
            //                Console.WriteLine("DD");
            //            }
            //            else if (ort >= 45 && ort < 55)
            //            {
            //                Console.WriteLine("CC");
            //            }
            //            else if (ort >= 55 && ort < 70)
            //            {
            //                Console.WriteLine("CB");
            //            }
            //            else if (ort >= 70 && ort < 85)
            //            {
            //                Console.WriteLine("BB");
            //            }
            //            else
            //            {
            //                Console.WriteLine("AA");
            //            }
            //        }
            //    }




            #endregion
            #region Kullanıcıya 3 hak vererek kayıtlı username ve password girişi yapmasını isteyelim. Hatalı girişlerde mesaj vererek tekrara denemesini isteyelim

            string username = "admin";
            string password = "123";

            int hak = 3;

        BASLA:
            if (hak > 0)
            {
                Console.WriteLine("Kullanıcı Adı:");
                string kullaniciAdi = Console.ReadLine();
                Console.WriteLine("Şifre:");
                string sifre = Console.ReadLine();

                if (kullaniciAdi == username && sifre == password)
                {
                    Console.WriteLine("Giriş Başarılı");
                }
                else
                {
                    Console.WriteLine("Giriş Başarısız!!");
                    hak--;
                    goto BASLA;
                }
            }
            else
            {
                Console.WriteLine("Hakkınız Bitti");
            }



            #endregion
            #endregion

            #region ********** SWITCH CASE *************

            //int gun = 3;

            //switch (gun)
            //{
            //    case 1:
            //        Console.WriteLine("Pazartesi");
            //        break;

            //    case 2:
            //        Console.WriteLine("Salı");
            //        break;

            //    case 3:
            //        Console.WriteLine("Çarşamba");
            //        break;
            //    default:
            //        Console.WriteLine("Hatalı gün bilgisi");
            //        break;
            //}


            //Console.WriteLine("Cinsiyet:");
            //string cins = Console.ReadLine();

            //switch (cins)
            //{
            //    case "E":
            //        Console.WriteLine("Erkek");
            //        break;

            //    case "K":
            //        Console.WriteLine("Kadın");
            //        break;

            //    default:
            //        Console.WriteLine("Hata!!");
            //        break;
            //}


            #region SORU
            /*
             Kullanıcıdan alınan cinsiyet bilgisine göre
            ==> ERKEK ise
                yaşı 60 ve üstü ise maaşının 10 katı ikramiye alarak emekli olacak
                yaşı 60'ın altında ise çalıştığı prim günü sorulacak
                    eğer prim gün sayısı 6000 ve üstü ise maaşının 11 katı ikramiye alarak emekli olacak
                    6000 altında ise emekli edilmeyecek bilgisi kullanıcıya gösterilecek

              ==> KADIN ise
                yaşı 55 ve üstü ise maaşının 10 katı ikramiye alarak emekli olacak
                yaşı 55'ın altında ise çalıştığı prim günü sorulacak
                    eğer prim gün sayısı 4200 ve üstü ise maaşının 11 katı ikramiye alarak emekli olacak
                    4200 altında ise emekli edilmeyecek bilgisi kullanıcıya gösterilecek
             */

            Console.WriteLine("Cinsiyet(E/K):");
            string cins = Console.ReadLine().ToUpper();

            switch (cins)
            {
                case "E":
                    Console.WriteLine("Yaş:");
                    int yas = Convert.ToInt32(Console.ReadLine());

                    if (yas >= 60)
                    {
                        Console.WriteLine("Maaş:");
                        int maas = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("İkramiye:"+(maas*10));
                    }
                    else
                    {
                        Console.WriteLine("Prim Sayısı:");
                        int prim = Convert.ToInt32(Console.ReadLine());

                        if (prim >= 6000)
                        {
                            Console.WriteLine("Maaş:");
                            int maas = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("İkramiye:" + (maas * 11));
                        }
                        else
                        {
                            Console.WriteLine("Emeklilik Hayal.");
                        }
                    }

                    break;

                case "K":
                    Console.WriteLine("Yaş:");
                    int yas = Convert.ToInt32(Console.ReadLine());

                    if (yas >= 55)
                    {
                        Console.WriteLine("Maaş:");
                        int maas = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("İkramiye:" + (maas * 10));
                    }
                    else
                    {
                        Console.WriteLine("Prim Sayısı:");
                        int prim = Convert.ToInt32(Console.ReadLine());

                        if (prim >= 4200)
                        {
                            Console.WriteLine("Maaş:");
                            int maas = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("İkramiye:" + (maas * 11));
                        }
                        else
                        {
                            Console.WriteLine("Emeklilik Hayal.");
                        }
                    }

                    break;

                default:
                    Console.WriteLine("Cinsiyet Bilgisi Hatalı!");
                    break;
            }




            #endregion

            #endregion
        }
    }
}
