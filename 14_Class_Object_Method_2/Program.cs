namespace _14_Class_Object_Method_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BANKA SİSTEMİ
            /*
             Müşteri:Id,NameSurname,HesapNo,Bakiye,Şifre
             
             Müşteriler sisteme giriş yapacak ve birt başka müşterinin hesabına hesap numarası üzerinden max bakiyesi kadar para transferi yapacak.
             
                
             */





            List<Musteri> musteris = new List<Musteri>()
            {
                new Musteri(){Id=1,Name="Altan Emre",Bakiye=10000,HesapNo=1001,Sifre="1"},
                new Musteri(){Id=2,Name="Eray",Bakiye=10000,HesapNo=1002,Sifre="1"}
            };


            Musteri musteri = Musteri.Giris(musteris);

            if (musteri == null)
            {
                Console.WriteLine("Giriş Başarısız!!");
            }
            else
            {
                Musteri.Havale(musteris, musteri);
            }

        }
    }   
}
