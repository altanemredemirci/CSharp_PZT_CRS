using System;
using System.Collections.Generic;
using System.Text;

namespace _17_OOP_4_Polymorphism_1
{
    internal class Ogrenci
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public virtual void Kaydet() //virtual: tanımı sanallaştırır istenilen yerde yeniden biçimlendirilebilir.
        {
            Console.WriteLine("Ad:");
            Ad = Console.ReadLine();

            Console.WriteLine("Soyad:");
            Soyad = Console.ReadLine();
        }
    }

    class IlkOkul
    {

    }

    class OrtaOkul : Ogrenci
    {
        public int Not { get; set; }

        //Ogrenci classında tanımlı olan Kaydet metodunu yok ederek burada yeniden tanımlamalıyım.

        public override void Kaydet()//override: ezmek
        {
            base.Kaydet();

            Console.WriteLine("Not:");
            Not = Convert.ToInt32(Console.ReadLine());
        }
    }

    class Lise:OrtaOkul
    {
        public string Bolum { get; set; }

        public override void Kaydet()
        {
            base.Kaydet();

            Console.WriteLine("Bölüm:");
            Bolum = Console.ReadLine();
        }
    }
}
