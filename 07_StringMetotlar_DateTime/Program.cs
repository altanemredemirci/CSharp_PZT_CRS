namespace _07_StringMetotlar_DateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region DATETIME(Tarih Zaman)

            //DateTime dateTime = DateTime.Now;

            //Console.WriteLine(dateTime);

            //Console.WriteLine(dateTime.Date);
            //Console.WriteLine(dateTime.Day);
            //Console.WriteLine(dateTime.Year);
            //Console.WriteLine(dateTime.Month);
            //Console.WriteLine(dateTime.Hour);
            //Console.WriteLine(dateTime.Minute);
            //Console.WriteLine(dateTime.Second);
            //Console.WriteLine(dateTime.Millisecond);


            //Console.WriteLine(dateTime.DayOfYear);
            //Console.WriteLine(dateTime.DayOfWeek);

            //Console.WriteLine(dateTime.ToLongDateString());
            //Console.WriteLine(dateTime.ToShortDateString());
            //Console.WriteLine(dateTime.ToLongTimeString());
            //Console.WriteLine(dateTime.ToShortTimeString());

            #endregion

            #region STRING METOTLAR

            string ad = "Altan Emre Demirci";

            Console.WriteLine(ad.Length);

            //E harfinin index numarasını verir. Index numaraları 0'dan başlar.
            Console.WriteLine(ad.IndexOf("E"));

            //Başlangıç Kontrolü
            Console.WriteLine(ad.StartsWith("A"));


            //ToUpper
            //ToLower

            //Substring:Bir string datayı belirtilen Indexden belirtilen kadar pkarakter kesmemizi sağlar.

            string isim = ad.Substring(2, 4);

            Console.WriteLine(isim);


            //Trim

            string sehir = "     İSTANBUL     ";
            string semt = "Şişli";
            Console.WriteLine(sehir); 
            Console.WriteLine(sehir.Trim());
            Console.WriteLine(semt.Trim('Ş'));
            #endregion
        }
    }
}
