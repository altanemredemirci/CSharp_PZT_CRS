using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Class_Object_Method_2
{
    internal class Musteri
    {
        public int Id;
        public string Name;
        public long HesapNo;
        public double Bakiye;
        public string Sifre;

        public static Musteri Giris(List<Musteri> musteriler)
        {

            Console.WriteLine("Hesap No:");
            long hesapNo = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Şifre:");
            string pass = Console.ReadLine();

            foreach (Musteri item in musteriler)
            {
                if (item.Sifre == pass && item.HesapNo==hesapNo)
                {
                    return item;
                }
            }

            return null;
        }

        public static void Havale(List<Musteri> musteris,Musteri musteri)
        {
            Console.WriteLine("Havale yapılacak hesap numarası:");
            long hesapNo = Convert.ToInt64(Console.ReadLine());

            foreach (Musteri item in musteris)
            {
                if (item.HesapNo == hesapNo)
                {
                    Console.WriteLine("Havale miktarı:");
                    double miktar = Convert.ToDouble(Console.ReadLine());

                    if (musteri.Bakiye >= miktar)
                    {
                        musteri.Bakiye -= miktar;
                        item.Bakiye += miktar;
                        Console.WriteLine("Havale yapıldı.");
                    }
                    else
                    {
                        Console.WriteLine("Yetersiz Bakiye");
                    }
                }
            }
        }
    }
}
