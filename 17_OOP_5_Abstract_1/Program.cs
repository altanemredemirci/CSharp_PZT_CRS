namespace _17_OOP_5_Abstract_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* *** ABSTRACT - SOYUTLAMA ***
             * ABSTRACT NEDİR?
             * Abstract özelliği bir class'ın base class olarak tanımlanmasını ve Instance(Örneklem-nesne oluşturma) alınmasını engeller.
             * Abstract tanımlı property miras alınan sınıfta çağrılmak zorundadır.
             * C#'da bu fonksiyonaliteyi sağlamak için abstract anahtar sözcüğü kullanılır.
             * Abstract tanımlı bir metot sadece abstract tanımlı bir sınıfta olabilir.
             * Abstract tanımlı sınıflar abstract metotlar gibi normal tanımlı metotlarda barındırabilir.
             * Ad,Soyad gibi propertylerde abstract olabilirler.
             
             */

            //Personel personel = new Personel(); //abstract class'dan nesne oluşturulamaz.

            IK ik = new IK();
            ik.Yaz();
        }
    }

    abstract class Personel //IK,MUH,IT gibi class'ın ortak özelliklerini barındırma
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public abstract void Kaydet(); //bu methot miras alınan sınıflarda geliiştirilmek zorundadır.
        public abstract void Guncelle();
        public abstract void Sil();
        public abstract void Listele();

        public void Yaz()
        {
            Console.WriteLine("Yazdık.");
        }
       
    }

    class IK:Personel //Kaydet,Sil,Guncelle,Listele
    {
        public int PersonelSayisi { get; set; }

        public override void Guncelle()
        {
            throw new NotImplementedException();
        }

        public override void Kaydet()
        {
            throw new NotImplementedException();
        }

        public override void Listele()
        {
            throw new NotImplementedException();
        }

        public override void Sil()
        {
            throw new NotImplementedException();
        }
    }

    class MUH : Personel//Kaydet,Sil,Guncelle,Listele
    {
        public int HesapSayisi { get; set; }

        public override void Guncelle()
        {
            throw new NotImplementedException();
        }

        public override void Kaydet()
        {
            throw new NotImplementedException();
        }

        public override void Listele()
        {
            throw new NotImplementedException();
        }

        public override void Sil()
        {
            throw new NotImplementedException();
        }
    }

    class IT : Personel//Kaydet,Sil,Guncelle,Listele
    {
        public int ProgramSayisi { get; set; }

        public override void Guncelle()
        {
            throw new NotImplementedException();
        }

        public override void Kaydet()
        {
            throw new NotImplementedException();
        }

        public override void Listele()
        {
            throw new NotImplementedException();
        }

        public override void Sil()
        {
            throw new NotImplementedException();
        }
    }
}
