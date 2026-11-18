namespace _17_OOP_2_Encapsulation_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();

            Console.WriteLine("Ad:");
            user.Ad = Console.ReadLine();

            Console.WriteLine("Soyad:");
            user.Soyad = Console.ReadLine();

            Console.WriteLine("TC:");
            user._TC = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Ad:"+user.Ad);
            Console.WriteLine("Soyad:"+user.Soyad);
            Console.WriteLine("TC:"+user._TC);
        }
    }

    class User
    {
        //Data Access Modifier:public,private,internal,protected

        //ENCAPSULATION: 
        //Belirli bir property gizli tanımlanarak kullanıcının erişimine kapatılır. Gizli property proje için önemli bir bilgi barıdıracağı için SET metot ile kontrollü atama işlemi yapılır. GET metot ile private tanımlı değer okunabilir.

        //Mesela TC kimlik numarası 11 haneli rakamlar dizisinden oluşmalıdır.

        public string Ad;
        public string Soyad;
        private long TC;



        public long _TC 
        {
            get //private tanımlı değişkenin okunmasını sağlar.
            {
                return TC;
            } 
            
            set//private tanımlı değişkene değer girmemizi sağlar.
            {
                if (value.ToString().Length == 11)
                {
                    TC = value;
                }
                else
                {
                    Console.WriteLine("TC hatalı!! 0 atandı.");
                    TC = 0;
                }
            }
        }
    }
}
