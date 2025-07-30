namespace _10_OtomatMakinesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] products = {"Kola","Fanta","Bisküvi","Kraker","Su"};

            double[] prices = { 40, 40, 15.5, 25, 30 };

            double balance = 0;

            while (true)
            {
                Console.WriteLine("Otomat Makinesine Hoşgeldiniz!");

                for (int i = 0; i < products.Length; i++)
                {
                    if (products[i] != null)
                    {
                        Console.WriteLine($"{i}-{products[i]}:{prices[i]}");
                    }
                    
                }

                Console.Write("Ürün Numarası Giriniz:");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number >= 0 && number < products.Length)
                {
                    do
                    {
                        Console.Write("Para Giriniz:");
                        balance += Convert.ToInt32(Console.ReadLine());

                        if (prices[number] <= balance)
                        {
                            balance -= prices[number];

                            Console.WriteLine($"{products[number]} ürünü aldınız. Afiyet Olsun. Para üstü:{balance}");
                            balance = 0;
                            Thread.Sleep(2000);
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Yetersiz!! 1-Para Ekle 2-Para İade");
                            int choose = Convert.ToInt32(Console.ReadLine());
                            
                            if(choose!=1)
                            {
                                Console.WriteLine("Paranız iade edildi:" + balance);
                                balance = 0;
                                Console.Clear();
                                break;
                            }
                        }
                    } while (true);
                }

                else if (number == 101)
                {
                    Console.Clear();
                    Console.WriteLine("Yönetici Paneli Giriş Ekranı");
                    Console.WriteLine("Şifre:");
                    string sifre = Console.ReadLine();

                    if (sifre == "ab18")
                    {
                        Console.WriteLine("1-Ürün Ekle\n2-Ürün Sil\n3-Ürün Güncelle");
                        int choose = Convert.ToInt32(Console.ReadLine());

                        if (choose == 1) 
                        {
                            Console.Write("Ürün Adı:");
                            string productName = Console.ReadLine();

                            Console.WriteLine("Ürün Fiyatı:");
                            double price = Convert.ToDouble(Console.ReadLine());

                            bool Added = false;

                            for (int i = 0; i < products.Length; i++)
                            {
                                if (products[i] == null)
                                {
                                    products[i] = productName;
                                    prices[i] = price;
                                    Added = true;
                                    break;
                                }
                            }

                            if (!Added) //Added==false
                            {
                                int length = products.Length;

                                Array.Resize(ref products, length + 1);
                                products[products.Length - 1] = productName;

                                Array.Resize(ref prices, length + 1);
                                prices[prices.Length - 1] = price;
                            }

                            Console.WriteLine("Ürün Eklendi.");
                        }
                        else if (choose == 2) 
                        {
                            for (int i = 0; i < products.Length; i++)
                            {
                                Console.WriteLine($"{i}-{products[i]}:{prices[i]}");
                            }

                            Console.Write("Silinecek Ürün Numarası:");
                            int deleted = Convert.ToInt32(Console.ReadLine());

                            if(deleted>=0 && deleted < products.Length)
                            {
                                Array.Clear(products, deleted, 1);
                                Array.Clear(prices, deleted, 1);
                                Console.WriteLine("Ürün Silindi.");
                            }
                            else
                            {
                                Console.WriteLine("Hatalı Seçim!!");
                            }
                        }
                        else if (choose == 3) 
                        {
                            for (int i = 0; i < products.Length; i++)
                            {
                                Console.WriteLine($"{i}-{products[i]}:{prices[i]}");
                            }

                            Console.Write("Güncellenecek Ürün Numarası:");
                            int updated = Convert.ToInt32(Console.ReadLine());

                            if (updated >= 0 && updated < products.Length)
                            {
                                Console.WriteLine("Yeni fiyat giriniz:");
                                double price = Convert.ToDouble(Console.ReadLine());

                                prices[updated] = price;

                                Console.WriteLine("Fiyat Güncellendi.");
                            }
                            else
                            {
                                Console.WriteLine("Hatalı Seçim!!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Hatalı Seçim!!");
                        }

                        Thread.Sleep(2000);
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Hatalı Giriş!!");
                        Thread.Sleep(2000);
                        Console.Clear();
                        continue;
                    }
                }

                else
                {
                    Console.WriteLine("Hatalı Ürün Seçimi!!");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
            }
           
        }
    }
}
