namespace _06_Bankamatik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region BANKAMATİK
            //            /*   
            //             *   25000 tl parası olacak 
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

            int bakiye = 25000;
            string sifre = "ab18";
            int hak = 3;

        KARTLI:
            Console.WriteLine("Kartlı İşlem\t1\nKartsız İşlem\t2\nSeçiminiz:");
            int kartli = Convert.ToInt32(Console.ReadLine());

            if (kartli == 1)
            {
                bool giris = false;
            SIFRE:
                if (hak > 0)
                {
                    Console.WriteLine("Şifreniz:");
                    string sfr = Console.ReadLine();

                    if (sifre == sfr)
                    {
                        giris = true;
                    }
                    else
                    {
                        Console.WriteLine("Şifreniz Hatalı!!");
                        hak--;
                        goto SIFRE;
                    }

                    if (giris) //if(giris==true)
                    {
                    ANAMENU:
                        Console.WriteLine("Para Çekme\t1\nPara Yatırma\t2\nPara Transferi\t3\nEğitim Ödemeleri\t4\nFatura Ödemeleri\t5\nBilgi Güncelleme\t6\nSeçiminiz:");

                        string anamenu = Console.ReadLine();

                        if (anamenu == "1")
                        {
                            #region PARA ÇEKME
                            Console.WriteLine("Çekilecek Miktar:");
                            int miktar = Convert.ToInt32(Console.ReadLine());

                            if (bakiye >= miktar)
                            {
                                bakiye -= miktar;
                                Console.WriteLine("Paranızı Alınız. Yeni Bakiye:" + bakiye);
                            }
                            else
                            {
                                Console.WriteLine("Yetersiz Bakiye");
                            }
                            #endregion

                        }
                        else if (anamenu == "2")
                        {
                            Console.WriteLine("Hesaba\t1\nKredi Kartına\t2\nSeçiminiz:");
                            string yatirma = Console.ReadLine();
                            if (yatirma == "1")
                            {
                                Console.WriteLine("Yatırılacak Miktar:");
                                int miktar = Convert.ToInt32(Console.ReadLine());

                                bakiye += miktar;

                                Console.WriteLine("Paranız Yatırıldı. Yeni Bakiye:" + bakiye);
                            }
                            else if (yatirma == "2")
                            {
                                Console.WriteLine("Kart Numarası:");
                                string kartNo = Console.ReadLine();

                                if (kartNo.Length == 11)
                                {
                                    if (long.TryParse(kartNo, out _))
                                    {
                                        Console.WriteLine("Yatırılacak Miktar:");
                                        int miktar = Convert.ToInt32(Console.ReadLine());

                                        if (bakiye >= miktar)
                                        {
                                            bakiye -= miktar;
                                            Console.WriteLine("Paranız Kredi Kartına Yatırıldı. Yeni Bakiye:" + bakiye);
                                        }
                                        else
                                        {
                                            Console.WriteLine("Yetersiz Bakiye");
                                        }

                                    }
                                    else
                                    {
                                        Console.WriteLine("Kart Numarası 11 rakamdan olmalıdır.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Kart Numarası 11 hane olmalıdır.");
                                }

                            }
                        }
                        else if (anamenu == "3")
                        {
                            Console.WriteLine("EFT\t1\nHavale\t2\nSeçiminiz:");
                            string transfer = Console.ReadLine();

                            if (transfer == "1")
                            {
                                Console.WriteLine("Başında tr olacak şekilde Iban giriniz:");
                                string iban = Console.ReadLine().ToUpper();
                                //ToUpper(): string metodu girilen değeri büyük harfe çevirir
                                //ToLower(): string metodu girilen değeri küçük harfe çevirir
                                //TR123123123

                                if (iban.StartsWith("TR"))
                                {
                                    string Iban = iban.Substring(2);

                                    if (Iban.Length == 12 && long.TryParse(Iban, out _))
                                    {
                                        Console.WriteLine("Transfer Edilecek Miktar:");
                                        int miktar = Convert.ToInt32(Console.ReadLine());

                                        if (bakiye >= miktar)
                                        {
                                            bakiye -= miktar;
                                            Console.WriteLine("Paranız Gönderildi. Yeni Bakiye:" + bakiye);
                                        }
                                        else
                                        {
                                            Console.WriteLine("Yetersiz Bakiye");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Iban numarası TR sonrası 12 haneli sayı dizisi olmalıdır");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Iban bilgisinin başında TR olmalıdır.");
                                }
                            }
                            else if (transfer == "2")
                            {
                                Console.WriteLine("Hesap Numarası:");
                                string hesap = Console.ReadLine();

                                if (hesap.Length == 12 && long.TryParse(hesap, out _))
                                {
                                    Console.WriteLine("Transfer Edilecek Miktar:");
                                    int miktar = Convert.ToInt32(Console.ReadLine());

                                    if (bakiye >= miktar)
                                    {
                                        bakiye -= miktar;
                                        Console.WriteLine("Paranız Gönderildi. Yeni Bakiye:" + bakiye);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Yetersiz Bakiye");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Hesap numarası 12 haneli sayı dizisi olmalıdır");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Hatalı Seçim!!");
                            }
                        }
                        else if (anamenu == "4")
                        {
                            Console.WriteLine("Eğitim Ödemeleri Alanı Arızalı");
                        }
                        else if (anamenu == "5")
                        {
                            Console.WriteLine("Elektrik Faturası       1\r\nTelefon Faturası        2\r\nİnternet faturası       3\r\nSu Faturası             4\r\nOGS Ödemeleri           5");
                            int fatura = Convert.ToInt32(Console.ReadLine());

                            if (fatura == 1)
                            {
                                Console.WriteLine("Fatura Tutarı:");
                                int tutar = Convert.ToInt32(Console.ReadLine());

                                if (bakiye >= tutar)
                                {
                                    bakiye -= tutar;
                                    Console.WriteLine("Faturanız Ödendi. Yeni Bakiye:" + bakiye);
                                }
                                else
                                {
                                    Console.WriteLine("Yetersiz Bakiye!");
                                }
                            }
                            else if (fatura == 2)
                            {
                                Console.WriteLine("Fatura Tutarı:");
                                int tutar = Convert.ToInt32(Console.ReadLine());

                                if (bakiye >= tutar)
                                {
                                    bakiye -= tutar;
                                    Console.WriteLine("Faturanız Ödendi. Yeni Bakiye:" + bakiye);
                                }
                                else
                                {
                                    Console.WriteLine("Yetersiz Bakiye!");
                                }
                            }
                            else if (fatura == 3)
                            {
                                Console.WriteLine("Fatura Tutarı:");
                                int tutar = Convert.ToInt32(Console.ReadLine());

                                if (bakiye >= tutar)
                                {
                                    bakiye -= tutar;
                                    Console.WriteLine("Faturanız Ödendi. Yeni Bakiye:" + bakiye);
                                }
                                else
                                {
                                    Console.WriteLine("Yetersiz Bakiye!");
                                }
                            }
                            else if (fatura == 4)
                            {
                                Console.WriteLine("Fatura Tutarı:");
                                int tutar = Convert.ToInt32(Console.ReadLine());

                                if (bakiye >= tutar)
                                {
                                    bakiye -= tutar;
                                    Console.WriteLine("Faturanız Ödendi. Yeni Bakiye:" + bakiye);
                                }
                                else
                                {
                                    Console.WriteLine("Yetersiz Bakiye!");
                                }
                            }
                            else if (fatura == 5)
                            {
                                Console.WriteLine("Fatura Tutarı:");
                                int tutar = Convert.ToInt32(Console.ReadLine());

                                if (bakiye >= tutar)
                                {
                                    bakiye -= tutar;
                                    Console.WriteLine("Faturanız Ödendi. Yeni Bakiye:" + bakiye);
                                }
                                else
                                {
                                    Console.WriteLine("Yetersiz Bakiye!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Hatalı İşlem!");
                            }

                        }
                        else if (anamenu == "6")
                        {
                            Console.WriteLine("Yeni Şifre:");
                            string yenisifre = Console.ReadLine();
                            Console.WriteLine("Tekrar Yeni Şifre:");
                            string yenisifre2 = Console.ReadLine();

                            if (yenisifre == yenisifre2)
                            {
                                sifre = yenisifre;
                                goto SIFRE;
                            }
                            else
                            {
                                Console.WriteLine("Şifreler uyuşmuyor!!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Hatalı Menü Seçimi!!");
                            goto ANAMENU;
                        }

                        Console.WriteLine("Anamenü\t9\nÇıkış\t0\nSeçiminiz:");
                        string donus = Console.ReadLine();

                        if (donus == "9")
                        {
                            goto ANAMENU;
                        }
                        else
                        {
                            Environment.Exit(0);
                        }
                    }


                }
                else
                {
                    Console.WriteLine("Hakkınız Bitti!!");
                }

            }
            else if (kartli == 2) { }
            else
            {
                Console.WriteLine("Hatalı Seçim!!");
                goto KARTLI;
            }
        }
    }
}
