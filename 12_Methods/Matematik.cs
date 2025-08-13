using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Methods
{
    internal class Matematik
    {
        internal void Toplama()
        {
            Console.WriteLine("1.Sayıyı giriniz:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Sayıyı giriniz:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            int sonuc = sayi1 + sayi2;

            Console.WriteLine("Sonuç:"+sonuc);
        }

        internal void Cikarma()
        {
            Console.WriteLine("1.Sayıyı giriniz:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Sayıyı giriniz:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            int sonuc = sayi1 - sayi2;

            Console.WriteLine("Sonuç:" + sonuc);
        }

        internal static void Carpma()
        {
            Console.WriteLine("1.Sayıyı giriniz:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Sayıyı giriniz:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            int sonuc = sayi1 * sayi2;

            Console.WriteLine("Sonuç:" + sonuc);
        }

        internal static void Bolme(int s1,int s2)
        {
            int sonuc = s1 / s2;

            Console.WriteLine("Sonuç:" + sonuc);
        }
    }
}
