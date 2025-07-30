using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;

namespace _08_Bankamatik
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region BANKAMATİK
            //            /*   
            //             *   2500 tl parası olacak 
            //            Bir bankamatik düşünülerek tasarlanacak bir program  için 
            //            Kartlı işlem    1
            //            Kartsız işlem   2
            //            //********Kartlı işlem bölümü
            //            Şifre istenecek=> Şifre:ab18
            //            ==> şifrenin 3 defa yanlış olması halinde sistemden atılacak,değilse Ana Menü
            //            //*******************Ana Menü 
            //            Para Çekmek için    1
            //            Para yatırmak için  2
            //            Para Transferleri   3
            //            Eğitim Ödemeleri    4
            //            Ödemeler            5
            //            Bilgi Güncelleme    6
            //            //*********************Seçim 1************
            //            Bakiye yeterli ise para çekilecek,değilse yetersiz bakiye
            //            Ana meüye dönmek için   9
            //            Çıkmak için             0
            //            //******************Seçim 2***********************
            //            Kredi Kartına   1
            //            Kendi Hesabınıza yatırmak için  2
            //            Ana Menü        9
            //            Çıkmak için     0
            //            //------------------------------------
            //            //----1
            //            Kredi kardı için en az 12 haneli kart numarasını girsin
            //            bakiye yeterli ise hesaptan kredi kartına para yatırılaca
            //            Ana Menü        9
            //            Çıkmak için     0
            //            //--------------------------
            //            //---2
            //            hesaba yatırılacak para değeri istenir veişlem gerçekleştirilir
            //            Ana Menü        9
            //            Çıkmak için     0
            //            //*****************************Seçim 3
            //            Başka Hesaba EFT    1
            //            Başka Hesaba Havale 2
            //            //---------------------------------
            //            //--1
            //            EFT numarası istenecek ve başında tr olmalı ve sonrasında 12 haneli sayı işlemleri doğru ise
            //            yatılacak para istenir ,hesap uygun ise işlem gerçekleşir değilse
            //            Ana Menü        9
            //            Çıkmak için     0
            //            //-----------------------------
            //            //---2
            //            hesap için 11 haneli hesap numarası işlemler doğru ise
            //            gönderilecek para miktarı, hesap uygun ise transfer olacak ,değilse
            //            Ana Menü        9
            //            Çıkmak için     0
            //            //****************Seçim 4
            //            Eğitim Ödemeleri sayfası arızalı
            //            Ana Menü        9
            //            Çıkmak için     0
            //            //****************************Seçim 5
            //            Elektrik Faturası       1
            //            Telefon Faturası        2
            //            İnternet faturası       3
            //            Su Faturası             4
            //            OGS Ödemeleri           5
            //            //-----------------------------------------
            //            //---1 => bütün faturala için aşağıdaki şart yeterli
            //            fatura tutarı istenir, hesap uygun ise yatırılır değilse
            //            Ana Menü        9
            //            Çıkmak için     0
            //            //-----------------------------------
            //            //***************Seçim 6
            //            Şifre değiştirmek için 1
            //            Şifre değiştirme işlemi gerçekleştirilir
            //            Ana Menü        9
            //            Çıkmak için     0



            //            //********Kartsız işlem bölümü

            //            //*******************Ana Menü 
            //            CepBank Para Çekmek 1
            //             Para yatırmak için  2
            //             Kredi Kartı Ödeme   3
            //             Eğitim Ödemeleri    4
            //             Ödemeler            5

            //             //*********************Seçim 1************
            //             TC kimlik no ve cep telefonu numarasını girsin doğruysa kişiye 1000 ödeme
            //             Yapın yanlış ise 3 kere daha denetin Hakkı bittiğinde 1 saat kilitleyin.
            //Ana menüye dönmek için   9
            //             Çıkmak için              0
            //             //******************Seçim 2***********************
            //             Nakit ödeme     1
            //             Hesaptan ödeme  2
            //             Ana Menü        9
            //             Çıkmak için     0
            //             //------------------------------------
            //             //----1
            //          Kredi kartı için en az 12 haneli kart numarasını girsin

            //          Tc kimlik numarasını girsin. 11 hane olup olmadığını kontrol edin.
            //             Nakit olarak ödeme gerçekleştirin.
            //             Ana Menü        9
            //             Çıkmak için     0
            //             //--------------------------
            //             //---2
            //             Kredi kartı için en az 12 haneli kart numarasını girsin
            // Hesap numarasını girsin

            //             Ana Menü        9
            //             Çıkmak için     0
            //             //*****************************Seçim 3
            //             Başka Hesaba EFT    1
            //             Başka Hesaba Havale 2
            //             //---------------------------------
            //             //--1
            //             EFT numarası istenecek ve başında tr olmalı ve sonrasında 12 haneli sayı işlemleri doğru ise
            //             yatılacak para istenir, hesap uygun ise işlem gerçekleşir değilse
            //             Ana Menü        9
            //             Çıkmak için     0
            //             //-----------------------------
            //             //---2
            //             hesap için 11 haneli hesap numarası işlemler doğru ise
            //             gönderilecek para miktarı, hesap uygun ise transfer olacak ,değilse
            //             Ana Menü        9
            //             Çıkmak için     0
            //             //****************Seçim 4
            //             Eğitim Ödemeleri sayfası arızalı
            //             Ana Menü        9
            //             Çıkmak için     0
            //             //****************************Seçim 5
            //             Elektrik Faturası       1
            //             Telefon Faturası        2
            //             İnternet faturası       3
            //             Su Faturası             4
            //             OGS Ödemeleri           5
            //             //-----------------------------------------
            //             //---1 => bütün faturala için aşağıdaki şart yeterli
            //             fatura tutarı istenir, hesap uygun ise yatırılır değilse
            //            */
            #endregion

            double bakiye = 2500;

            while (true)
            {
                Console.WriteLine("**** BANKAMATİK ****");
                Console.WriteLine("1-Kartlı İşlem\n2-Kartsız İşlem\n3-Çıkış\nSeçiminiz:");
                string kartSecim = Console.ReadLine();

                if (kartSecim == "1") 
                {
                    string sifre = "ab18";
                    int hak = 3;
                
                    while (hak > 0)
                    {
                        Console.WriteLine("Şifreniz:");
                        string pass = Console.ReadLine();

                        if (pass == sifre) 
                        {
                            while (true)
                            {
                                Console.WriteLine("*** ANA MENÜ ***");
                                Console.WriteLine("1-Para Çekme\n2-Para Yatırma\n3-para Transferi\n4-Eğitim Ödemeleri\n5-Fatura Ödemeleri\n6-Şifre Güncelle\nSeçiminiz:");

                                string anaSecim = Console.ReadLine();

                                if (anaSecim == "1")
                                {
                                    Console.WriteLine("Çekilecek Miktar:");
                                    int miktar = Convert.ToInt32(Console.ReadLine());

                                    if (bakiye >= miktar)
                                    {
                                        bakiye -= miktar;
                                        Console.WriteLine("Paranızı alınız:" + miktar + " Yeni bakiye:" + bakiye);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Yetersiz bakiye!!");
                                    }

                                }
                                else if (anaSecim == "2") 
                                {
                                    Console.WriteLine("1-Kredi Kartı\n2-Hesap\nSeçiniz:");
                                    string yatirmaSecim = Console.ReadLine();

                                    if (yatirmaSecim == "1")
                                    {
                                        Console.WriteLine("Kredi Kartı Numarası(16 haneli):");
                                        string kartNo = Console.ReadLine();

                                        long kartNumarasi;

                                        if(kartNo.Length==16 && long.TryParse(kartNo,out kartNumarasi))
                                        {
                                            Console.WriteLine("Yatırılacak miktar:");
                                            int miktar = Convert.ToInt32(Console.ReadLine());

                                            if (bakiye >= miktar)
                                            {
                                                bakiye -= miktar;
                                                Console.WriteLine("Paranız yatırıldı. Yeni bakiye:" + bakiye);
                                            }
                                            else
                                            {
                                                Console.WriteLine("Yetersiz bakiye!!");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Kredi kart numaranız 16 haneli rakamlardan oluşmalıdır!!");
                                        }



                                    }
                                    else if (yatirmaSecim == "2")
                                    {
                                        Console.WriteLine("Yatırılacak miktar:");
                                        int miktar = Convert.ToInt32(Console.ReadLine());

                                        bakiye += miktar;

                                        Console.WriteLine("Yeni bakiyeniz:"+bakiye);
                                    }
                                    else 
                                    {
                                        Console.WriteLine("Hatalı Seçim!!");
                                    }

                                     

                                    

                                }
                                else if (anaSecim == "3") 
                                {
                                    Console.WriteLine("1-EFT\n2-Havale\nSeçiminiz:");
                                    string transferSecim = Console.ReadLine();

                                    if (transferSecim == "1") 
                                    {
                                        Console.WriteLine("EFT işlemi için başında TR olacak şekilde 12 haneli Iban giriniz");
                                        string iban = Console.ReadLine();

                                        string tr = iban[0].ToString() + iban[1].ToString();
                                        string IBAN = iban.Substring(2);
                                        long ibanNumara;

                                        if (tr.ToUpper() == "TR")
                                        {
                                            if(long.TryParse(IBAN,out ibanNumara) && IBAN.Length == 12)
                                            {
                                                Console.WriteLine("EFT Yapılacak Miktar:");
                                                int miktar = Convert.ToInt32(Console.ReadLine());

                                                if (bakiye >= miktar)
                                                {
                                                    bakiye -= miktar;
                                                    Console.WriteLine("Transfer gerçekleştirildi. Yeni bakiye:" + bakiye);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Yetersiz bakiye!!");
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("Ibanda TR sonrasında 12 haneli rakama dizisi olmalıdır!!");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Iban başında TR olacak şekilde giriniz!!");
                                        }
                                    
                                    }
                                    else if (transferSecim == "2") 
                                    {
                                        Console.WriteLine("Hesap Numarası 11 haneli");
                                        string hesapNo = Console.ReadLine();

                                        if (hesapNo.Length == 11 && long.TryParse(hesapNo, out long hesapNumarasi))
                                        {
                                            Console.WriteLine("Havale Yapılacak Miktar:");
                                            int miktar = Convert.ToInt32(Console.ReadLine());
                                            if (bakiye >= miktar)
                                            {
                                                bakiye -= miktar;
                                                Console.WriteLine("Transfer gerçekleştirildi. Yeni bakiye:" + bakiye);
                                            }
                                            else
                                            {
                                                Console.WriteLine("Yetersiz bakiye!!");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Hesap numarası 11 haneli rakamlardan oluşmalıdır!!");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Hatalı transfer seçimi!!");
                                    }



                                
                                }
                                else if (anaSecim == "4") {
                                    Console.WriteLine("Eğitim ödemeleri bölümü arızalı!!");
                                }
                                else if (anaSecim == "5") 
                                {
                                    Console.Clear();
                                    Console.WriteLine("═══════════════════════════════");
                                    Console.WriteLine("          ÖDEMELER");
                                    Console.WriteLine("═══════════════════════════════");
                                    Console.WriteLine("Elektrik Faturası     [1]");
                                    Console.WriteLine("Telefon Faturası      [2]");
                                    Console.WriteLine("İnternet Faturası     [3]");
                                    Console.WriteLine("Su Faturası           [4]");
                                    Console.WriteLine("OGS Ödemeleri         [5]");                              
                                    Console.WriteLine("═══════════════════════════════");
                                    Console.Write("Seçiminiz: ");

                                    string faturaSecim = Console.ReadLine();

                                    if (faturaSecim == "1")
                                    {
                                        Console.WriteLine("Fatura tutarınız:");
                                        double faturaTutar = Convert.ToDouble(Console.ReadLine());

                                        if(bakiye >= faturaTutar)
                                        {
                                            bakiye -= faturaTutar;
                                            Console.WriteLine("Elektrik faturanız ödendi. Yeni bakiye: " + bakiye);
                                        }
                                        else
                                        {
                                            Console.WriteLine("Yetersiz bakiye!!");
                                        }
                                    }
                                    else if (faturaSecim == "2")
                                    {
                                        Console.WriteLine("Fatura tutarınız:");
                                        double faturaTutar = Convert.ToDouble(Console.ReadLine());
                                        if (bakiye >= faturaTutar)
                                        {
                                            bakiye -= faturaTutar;
                                            Console.WriteLine("Telefon faturanız ödendi. Yeni bakiye: " + bakiye);
                                        }
                                        else
                                        {
                                            Console.WriteLine("Yetersiz bakiye!!");
                                        }
                                    }
                                    else if (faturaSecim == "3")
                                    {
                                        Console.WriteLine("Fatura tutarınız:");
                                        double faturaTutar = Convert.ToDouble(Console.ReadLine());
                                        if (bakiye >= faturaTutar)
                                        {
                                            bakiye -= faturaTutar;
                                            Console.WriteLine("İnternet faturanız ödendi. Yeni bakiye: " + bakiye);
                                        }
                                        else
                                        {
                                            Console.WriteLine("Yetersiz bakiye!!");
                                        }
                                    }
                                    else if (faturaSecim == "4")
                                    {
                                        Console.WriteLine("Fatura tutarınız:");
                                        double faturaTutar = Convert.ToDouble(Console.ReadLine());
                                        if (bakiye >= faturaTutar)
                                        {
                                            bakiye -= faturaTutar;
                                            Console.WriteLine("Su faturanız ödendi. Yeni bakiye: " + bakiye);
                                        }
                                        else
                                        {
                                            Console.WriteLine("Yetersiz bakiye!!");
                                        }
                                    }
                                    else if (faturaSecim == "5")
                                    {
                                        Console.WriteLine("OGS ödemesi arızalı!!");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Hatalı Fatura Seçimi!!");
                                    }

                                }
                                else if (anaSecim == "6") 
                                {
                                    Console.WriteLine("Eski Şifreniz:");
                                    string eskiSifre = Console.ReadLine();

                                    if(eskiSifre == sifre)
                                    {
                                        Console.WriteLine("Yeni şifreniz:");
                                        string yeniSifre = Console.ReadLine();

                                        Console.WriteLine("Tekrar Yeni Şifre:");
                                        string tekrarSifre = Console.ReadLine();

                                        if(yeniSifre == tekrarSifre && yeniSifre.Length >= 4)
                                        {
                                            sifre = yeniSifre;
                                            Console.WriteLine("Şifreniz başarıyla güncellendi!!");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Şifreler eşleşmiyor veya 4 karakterden az!!");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Şifreniz hatalı!!");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Hatalı Menü Seçimi!!");
                                }

                                Console.WriteLine("Anamenü-9\nÇıkış-0\nSeçiminiz:");
                                string donus = Console.ReadLine();

                                if (donus == "9")
                                {
                                    Console.Clear();
                                    continue;
                                }
                                else
                                {
                                    Environment.Exit(0); //çalışan projeyi sonlandır.
                                }
                            }
                           

                        }
                        else 
                        { 
                            Console.WriteLine("Şifre Hatalı!!");
                            hak--;
                            Console.WriteLine("Kalan hakkınız:"+hak);
                        }

                        if (hak == 0)
                        {
                            Console.WriteLine("Sistem 5 saniye kitlendi");
                            Thread.Sleep(5000); //Milisaniye cinsinden bekleme süresi tanımlanır
                            Console.Clear();
                            hak = 3;
                        }
                    }

              











                }
                else if (kartSecim == "2") { }
                else if (kartSecim == "3") 
                {
                    Console.WriteLine("Yine Bekleriz..");
                    break; //Kendi döngüsünü bitirir.
                    //Environment.Exit(0); //Çalışmayı durdurur.
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Hatalı Kart İşlem Seçimi!!");
                }
            }
           


        }



    }



}
