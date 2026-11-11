using System.Collections;

namespace _13_SortedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SortedList koleksiyonu key,value mantığı ile çalışır. Bir değer arandığı zaman key değeri üzerinden arama işlemi yapılır ve o key'e atanmış value değeri ekrana gelir.

            SortedList sozluk = new SortedList()
            {
                {"Bugün","Today"},
                {"Yarın","Tomorrow" },
                {"Hava","Weather" },
                {"Gökyüzü","Sky" },
                {"Karlı","Snowy" },
                {"Güneşli","Sunny" },
                {"Bulutlu","Cloudy" },
                {"Açık","Clear" },
                {"Kapalı","Cloudy" },
            };

            //Console.WriteLine(sozluk["Bugün"]);
            //Console.WriteLine(sozluk["Today"]);

            sozluk["Siyah"] = "Black";
            sozluk["Siyah"] = "DarkBlack";



            foreach (DictionaryEntry item in sozluk)
            {
                Console.WriteLine(item);
            }

            //foreach (string item in sozluk.Keys)
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (string item in sozluk.Values)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
