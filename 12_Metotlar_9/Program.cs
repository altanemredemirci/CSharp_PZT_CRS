namespace _12_Metotlar_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region DEFAULT DEĞER
            //Bİr metodun tanımında parametreye değer atanırsa, bu metot çağrılırken gönderilmezse o değeri alması içindir.
            //Topla(11, 12);

            //Topla(11);

            #endregion

            #region OUT KEYWORD
            //metot içerisinde gerçekleştirilen işlem sonucu out ile gönderilen değişkeni etkiler.
            //out komutu metot içerisinde değişkene mutlaka bir değer atanacağı anlamına geldiğinden başlangıç değeri tanımlanmak zorunda değiliz.
            //int sayi;
            //Degistir(out sayi);

            //Console.WriteLine(sayi);
            #endregion


            #region REF KEYWORD
            //metot içerisinde gerçekleştirilen işlem sonucu out ile gönderilen değişkeni etkiler.
            //ref komutu metot içerisinde değişkene mutlaka bir değer atanacağı anlamına gelmediği için başlangıç değeri tanımlanmak zorundayız
            int sayi=5;
            Arttir(ref sayi);

            Console.WriteLine(sayi);

            #endregion

        }

        static void Topla(int sayi1, int sayi2=10) //sayi2 gönderilmezse default 10 al
        {
            Console.WriteLine(sayi2+sayi1);
        }

        static void Degistir(out int s)
        {
            s = 10;           
        }


        static void Arttir(ref int s)
        {
            
        }

    }
}
