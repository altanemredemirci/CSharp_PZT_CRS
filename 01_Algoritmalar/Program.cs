namespace _01_Algoritmalar
{
    internal class Program
    {
        static void Main(string[] args) //Metot:Proje içerisinde event tetikler.
        {
            /*
             Çoklu yorum satırı(comment /*)  
            
            DEBUG: Complier(Derleyici) geliştirirken kodun çalıştırılabilirliğini kontrol eder.
            1-Hataları tespit eder.
            2-Bu kod bloğunu çalıştırıldığı donanım yeterli mi?
            3-Proje içindeki her katman erişilebilir mi?
            4-Kod bloğu Makine koduna çevrilir.
            5-Çalıştırılır.
            6-Result
             
             */

            // Tek satır yorum - açıklama satırı: Compiler bu satırı kontrol(Debug) etmez.
            // Yazılım temelinde algoritma vardır.


            /*
             Çoklu 
                yorum-comment 
                    satırı 
             */

            /*
             DEBUG
            - Build Kod hatası veya Yazım hatası
            - Kodu çalıştıracak donanımsal yeterlilik kontrolü
            - Compile -> Kod Makine koduna dönüştürülür.
            - Execute 
            - Result
             
             */

            /*
              ALGORİTMA  
             * BAŞLANGIÇ - BİTİŞ 
             * SIRALI
             * SONLULUK
             * KESİNLİK
             * MODULER-GENELLEBİLİR
             
             Algoritma Yapılma Amacı 
             * Maliyet
             * Zaman tasarufu
             * Performans
            
            //Kullanıcıdan iki kardeşin yaşını alınız ve toplamını ekrana yazdırınız
            1- Başla
            2- yas1 = 1.yaşı giriniz
                2.1- Girilen değer rakamlardan mı oluşuyor? T->2.3 F->2.2
                2.2- Lütfen yaşı rakam olarak giriniz -> 2
                2.3- Eğer yas1>0 ve yas1<120 ise T-> 3 F->2.4
                2.4- 0 ile 100 aralığında yaş giriniz -> 2
            3- 2.yaşı giriniz
                3.1- Girilen değer rakamlardan mı oluşuyor? T->3.3 F->3.2
                3.2- Lütfen yaşı rakam olarak giriniz -> 3
                3.3- Eğer yas1>0 ve yas1<120 ise T-> 4 F->3.4
                3.4- 0 ile 100 aralığında yaş giriniz -> 3
            4- 1. ve 2. yaşı topla
            5- Toplam değerini ekrana yaz
            6- Bitti



            ÇAY DEMLEME ALGORİTMA
            1-Başla
            2-Mutfağa Git
            3-Çaydanlığa Su Koy
            4-Çaydanlığı Ocağa Koy
            5-Ocağı Yak
            6-Su Kaynadı Mı? T->8
            7-Bekle 1dk ->6
            8-Demliğe Çay Koy
            9-Çaydanlığa Su Koy
            10-Ocağa Koy
            11-Çay Demlendi Mi? T->13 F->12
            12-Bekle ->11
            13-Servis Yap
            14-Bitti


            *SU YOK
            *ÇAY YOK
            
            1-Başla
            2-Mutfağa Git
            3-Su ve Çay var mı? T->9 F->4
            4-Bakkala git
            5-Bakkal Açık mı? T->7 F->6
            6-Başka Bakkala Git -> 5
            7-Eksikleri Al
            8-Eve Dön ->2 
            9-Çaydanlığa Su Koy
            10-Çaydanlığı Ocağa Koy
            11-Ocağı Yak
            12-Su Kaynadı Mı? T->14
            13-Bekle 1dk ->12
            14-Demliğe Çay Koy
            15-Çaydanlığa Su Koy
            16-Ocağa Koy
            17-Çay Demlendi Mi? T->19 F->18
            18-Bekle ->17
            19-Servis Yap
            20-Bitti

            //Evden çıkıp Üçüncü Binyıl akademiye gelme algoritması


            1-Başla
            2-Daireden Çık
            3-Asansör mü? Merdiven mi? A->4 M->11
            4-Asansörü Çağır
            5-Asansör Geldi mi? T->7 F->6
            6-Bekle ->5 
            7-Gidilecek Kat tuşuna bas
            8-İstenilen Kata geldik mi? F->9 T->10
            9-Bekle -> 8
            10-Asansörden in ->13
            11-1. kat hareket et
            12-İstenilen katta mıyız? F->11 T->13
            13-Binadan Çık


            14-Akbil dolu mu? F->15 T->17
            15-Dolum cihazına git
            16-Doldur
            17-Toplu Taşıma Durağına Git
            18-istenilen Toplu Taşıma geldi Mi? F->19 T->20
            19-Bekle -> 18
            20-Toplu Taşıma Bin
            21-Akbil Bas
            22-Boş Yer Var mı? T->23 F->24
            23-Otur ->25
            24-Ayakta Bekle
            25-İstenilen Durağına Geldi Mi? T->27 F->26
            26-Bekle ->25
            27-Toplu Taşımadan in
            28-Akademiye Yürü
            29- Bitti


            //**** MODÜLER ALGORİTMA ****

            //Misafir Karşılama Algoritması
            
            1-Başla
            2-Daireden Çık
            3-Asansör mü? Merdiven mi? A->4 M->11
            4-Asansörü Çağır
            5-Asansör Geldi mi? T->7 F->6
            6-Bekle ->5 
            7-0 tuşuna bas
            8-0.kata geldik mi? F->9 T->10
            9-Bekle -> 8
            10-Asansörden in ->13
            11-1. kat in
            12-0.katta mıyız? F->11 T->13
            13-Binadan Çık


            //Çöp Atma Algoritması
            
            1-Başla
            2-Daireden Çık
            3-Asansör mü? Merdiven mi? A->4 M->11
            4-Asansörü Çağır
            5-Asansör Geldi mi? T->7 F->6
            6-Bekle ->5 
            7-0 tuşuna bas
            8-0.kata geldik mi? F->9 T->10
            9-Bekle -> 8
            10-Asansörden in ->13
            11-1. kat in
            12-0.katta mıyız? F->11 T->13
            13-Binadan Çık
                         
             
             //SOLID Prensipleri
             
            //Design Pattern - N Tier Mimari,MVC,CQRS,Repository,Abstract Of, Singleton, UnitOfWork, Onion Mimari,Clean Mimari
            *** Projenin Çok Büyük Olması
            
             Product
                - Price
                - Name
                - Image
                - Stock
                - Discount
                - Likes
                - Comments
             
             */


            //string ad = "altan";
            //int yas = 34;

            //Console.WriteLine("Yaş:"+yas);
            //Console.WriteLine($"Yaş:{yas} Ad:{ad}");
            //Console.WriteLine("Yaş:{0} Ad:{1}",yas,ad);

            //Sabit Değişken
            //const int pi = 3;
            //pi = 5;
            //Console.WriteLine(pi);
        }
    }
}
