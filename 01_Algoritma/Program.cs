namespace _01_Algoritma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Solution: İçerisinde projeler barındıran en üst sekmedir.
            //Project: C# kodlarının geliştirildiği ana programdır.
            //Program.cs(cs=class): Proje kodlarının yazıldığı ve proje start edildiğinde ilk çalıştırılan dosyadır.


            //Metotlar konusuna kadar bütün kodları Main bloğunun içine yazacağız.

            //Tek satır açıklama yazmamızı sağlar.

            /*
             Çoklu
                Satır
                    Açıklama             
             */
            //Build: Yazılan her kelime bir C# kodu olarak tanınır. Bu sebeple kod olmayan bir metin girildiğinde Hata verir. Projenin sağlıklı bir şekilde ayağa kalkması(çalışması) build Success olmalıdır.

            //Visual Studio - Compiler(Derleyici) : Yazılım kodlarının syntax(yazım kuralı) kontrolü, ilişkili dosyaların birlikte çalıştırılması ve projenin çalışabilirliği kontrol edilir.


            // .Net Developer: Microsoft'un dotnet isminde bir framework'ü(kütüphane) vardır. Bunun en öenmli özelliği C# temelinde yazılmış birden fazla ve farklı platform projesini tek bir yapı altında geliştirmeyi sağlar.

            //C#: Nesne Yönelimli Programlama Dili - OOP Object Oriented Programming

            /*
             *********** ALGORİTMA ***********
             *Varolan bir problemi veya geliştirmeyi sonuca götüren mantıklı ve sıralı çözüm adımları.
             
             *1-Giriş ve Çıkış Belirli Olmalı
             *2-Sonluluk(Bütün olasılıklar bir sonuca varmalı)
             *3-Kesinlik(Yazılan her kelime anlaşılır olmalıdır)
             *4-Genellenebilirlik(Kod modüler ve genelenebilir olmalıdır)
             *5-Performans(Zaman ve Maliyetten tasarruf ve yüksek verimlilik)
            
            ÇAY DEMLEME
            1-Başla
            2-Mutfağa Git
            3-Çaydanlığa Su Koy
            4-Ocağı Yak
            5-Çaydanlığı Ocağa Koy
            6-Su Kaynadı Mı? T->8 F->7  T-True  F-False
            7-Bekle 3 dk ->6
            8-Demliğe Çay Koy
            9-Ocağa Koy
            10-Çay Demlendi Mi? T->12 F->11
            11-Bekle 3 dk ->10
            12-Servis Et
            13-Bitti

            **Çay Yok
            **Su Yok
            **Bakkal Kapalı
            
            1-Başla
            2-Mutfağa Git
            3-Su ve Çay Var Mı? T->10 F->4
            4-Evden Çık
            5-Bakkala Git
            6-Bakkal Açık Mı? T->8 F->7
            7-Başka Bakkala Git -> 6
            8-Eksikleri Al
            9-Eve Dön ->2
            10-Çaydanlığa Su Koy
            11-Ocağı Yak
            12-Çaydanlığı Ocağa Koy
            13-Su Kaynadı Mı? T->15 F->14  
            14-Bekle 3 dk ->13
            15-Demliğe Çay Koy
            16-Ocağa Koy
            17-Çay Demlendi Mi? T->19 F->18
            18-Bekle 3 dk ->17
            19-Servis Et
            20-Bitti
            
             
            Kullanıcıdan alınan iki sayının toplamını ekrana yazdırınız

            1-Başla
            2-sayi1 = Kullanıcıdan 1.sayı al
            3-sayi2 = Kullanıcıdan 2.sayı al
            4-toplam = sayi1+sayi2
            5-toplam ekrana yaz
            6-Bitti

             */

            //Console.WriteLine("1. sayıyı giriniz");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("2. sayıyı giriniz");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());

            //int toplam = sayi1 + sayi2;

            //Console.WriteLine(toplam);

            //EVDEN AKADEMİYE GELME ALGORİTMASI

            /*
            1-Başla
            2-Daireden Çık
            3-Asansör Mü? Merdiven Mi? A->4 M->11
            4-Asansör Katta Mı? T->6 F->5
            5-Asansörü Çağır -> 4
            6-Asansöre Bin
            7-İnilecek Kat Tuşuna Bas
            8-Asansör İnilecekKatta Mı? F->9 T->10
            9-Bekle ->8
            10-Asansörden İn ->13
            11-Bir Kat İn
            12-İnilecek Katta Mıyız? F->11 T->13
            13-Binadan Çık


            14-Akbil Dolu Mu? T->17 F->15
            15-Dolum İstasyonuna Git
            16-Akbil Doldur
            17-Durağa Git
            18-Toplu Taşıma Geldi Mi? T->20 F->19 
            19-Bekle ->18
            20-Toplu Taşımaya Bin
            21-Akbil Bas
            22-Boş Yer Var Mı? T->24 F->23
            23-Ayakta Git ->25
            24-Otur
            25-İnilecek Durağa Geldi Mi? F->26 T->27
            26-Bekle ->25
            27-Toplu Taşımadan İn
            29-Akademiye Yürü
            30-Binaya Gir
            31-Bitti

             */


        }

    }
}
