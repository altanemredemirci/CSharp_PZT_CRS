using System;
using System.Collections.Generic;
using System.Text;

namespace _12_Metotlar_3
{
    public class Matematik
    {
        internal static void Hesapla() 
        {
            Console.WriteLine("1.Sayı:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Sayı:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İşlem Giriniz:(+,-,*,/)");
            string islem = Console.ReadLine();

            if (islem == "+") { Console.WriteLine(sayi1 + sayi2); }
            else if (islem == "-") { Console.WriteLine(sayi1 - sayi2); }
            else if (islem == "*") { Console.WriteLine(sayi1 * sayi2); }
            else if (islem == "/") { Console.WriteLine(sayi1 / sayi2); }
            else
            {
                Console.WriteLine("Hatalı İşlem Seçimi!!");
            }
        }
    }
}
