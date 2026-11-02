namespace _12_Metotlar_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* ***** METOTLAR *****
             * Metot () parantezleri ile tanımlanan ve belirli bir görevi gerçekleştirmek için yazılan kod blokuna denir.

            * Belirli bir işin kodunu bir metot ismi altında tanımlayarak o işe ihtiyaç duyduğumuz her zaman metodun adını yazarak çalıştırabiliriz.
            
            * Metotlar iç içe tanımlanmazlar.
            * Metotlar tanımlandıktan sonra çağrılmadıkça çalışmazlar.
            
            * Metotlar Tanımlanma Yapılarına Göre 2'ye ayrılırlar.
                * Değer Döndürmeyen Metotlar(paramatreli/parametresiz)
                * Değer Döndüren Metotlar(paramatreli/parametresiz)

             */

            //Yaz();

            //Console.WriteLine("-----------");

            //Yaz();

            //Topla();

            //Topla2(11,22);

            Console.WriteLine("1.Sayı:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Sayı:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Topla2(sayi1, sayi2); //Parametre isimleri metot tanımlarken verilen isimlerle aynı olmak zorunda değildir. Önemli olan kaç tane ve hangi veri tipinde tanımlanmış olduğudur.

        }

        static void Yaz()
        {
            Console.WriteLine("İsim:");
            string isim = Console.ReadLine();

            Console.WriteLine(isim);
        }

        static void Topla() //Parametresiz Değer Döndürmeyen Metot
        {
            Console.WriteLine("1.Sayı:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Sayı:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Toplam:{sayi1+sayi2}");
        }

        static void Topla2(int s1,int s2) //Parametreli Değer Döndürmeyen Metot
        {
            Console.WriteLine(s1+s2);
        }
    }
}
