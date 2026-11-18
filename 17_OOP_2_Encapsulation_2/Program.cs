namespace _17_OOP_2_Encapsulation_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bir üniversite öğrencisinin vize ve final notlarını öğrenciden alalım. Encapsulation ile 0-100 aralığında int bir değer giriliğ girilmediği kontrol edelim ve ortalamasını(vize%40 + final%60) ekrana yazdıralım
        }
    }

    /*
     
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
     */
}
