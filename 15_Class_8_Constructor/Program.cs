namespace _15_Class_8_Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CONSTRUCTOR METHODU: Bir class'dan nesne türetildiğinde otomatik olarak çalışan methodtur. Nesne türetildiğinde yapılması gereken işlemler varsa constructor method içerisinde yapılır.
            //Constructor Metot: Class ile aynı isme sahiptir ve void veya int gibi dönüş tipi tanımı bulunmaz.


            Ogrenci ogrenci = new Ogrenci(); //Instance -Örneklem
           
            Ogrenci ogrenci2 = new Ogrenci(1,"Sercan","Kaya"); 


        }
    }

    class Ogrenci
    {
        public int Numara;
        public string Ad;
        public string Soyad;

        public Ogrenci()
        {
            //Class oluşturulurken default olarak arkaplanda bu metot oluşturulur.

            //Console.WriteLine("Constructor Metot Çalıştı.");

            Console.WriteLine("Numara:");
            Numara = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ad:");
            Ad = Console.ReadLine();

            Console.WriteLine("Soyad:");
            Soyad = Console.ReadLine();
        }

        public Ogrenci(int no,string ad, string soyad)
        {
            Numara = no;
            Ad = ad;
            Soyad = soyad;
        }
    }
}
