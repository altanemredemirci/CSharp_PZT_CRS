namespace _15_Class_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kitap: BarkodNo,YazarAdı,KitapAdi

            List<Kitap> kitaplar = new List<Kitap>();

            Kitap.Kaydet(kitaplar);

            Kitap.Listele(kitaplar);
        }
    }
}
