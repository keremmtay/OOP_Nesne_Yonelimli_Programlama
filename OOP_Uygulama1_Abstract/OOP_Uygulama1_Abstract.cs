using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Uygulama1_Abstract
{
    internal class OOP_Uygulama1_Abstract
    {
        static void Main(string[] args)
        {

            #region Alan Hesaplama

            // Base Class'ımız olacak.(Sekil) içerisinde AlanHesapla isimli bir metodumuz olacak. Bunu abstract olarak tanımlayacağız.
            // Dikdörtgen, kare, üçgen isimli Classlarımız olacak.
            // Değişkenler Sekil isimli classın içinde tanımlanacak.

            Kare kare = new Kare(4);
            kare.AlanHesapla();
            kare.EkranaYaz();

            Dikdortgen dikdortgen = new Dikdortgen(3, 5);
            dikdortgen.AlanHesapla();
            dikdortgen.EkranaYaz();

            Ucgen ucgen = new Ucgen(2,5);
            ucgen.AlanHesapla();
            ucgen.EkranaYaz();

            #endregion

            // Polymorphism/Çok Biçimlili'ğe örnek olarak aşağıdaki örnekleri verebiliriz.


            // SekilBase'den türemiş olan diğer sınıfların nesnelerini oluşturduktan sonra SekilBase ile referanslarını tutabiliriz.
            // SekilBase ilk örnekte Kare referansını tuttuğu için Kare olarak çalışacaktır.
            // İkinci örnekte Ucgen class'ının referansını tuttuğu için Ucgen Nesnesi olarak çalışacaktır.
            // Sonuç olarak SekilBase sınıfının farklı türdeki Nesnelerinin referanslarını tutabildiği için çokbiçimli bir hal almış oluyor... Buna çok biçimlilik ya da Polymorphisim denir.

            Console.WriteLine("\n************************\n");

            SekilBase sekilKare = new Kare(9);
            sekilKare.AlanHesapla();
            sekilKare.EkranaYaz();

            SekilBase sekilUcgen = new Ucgen(5, 6);
            sekilUcgen.AlanHesapla();
            sekilUcgen.EkranaYaz();

            SekilBase sekilDikdortgen = new Dikdortgen(5, 4);
            sekilDikdortgen.AlanHesapla();
            sekilDikdortgen.EkranaYaz();

            // SekilBase sekilCember = new Cember(); // Bu şekilde yapamıyoruz çünkü Çember SekilBase'den türemiş olan bir class değil.

            Console.ReadLine();
        }
    }

    abstract class SekilBase
    {
        public int BirinciKenar { get; set; }
        public int İkinciKenar { get; set; }
        public int Taban { get; set; }
        public int Yukseklik { get; set; }
        public int Alan { get; set; }

        public abstract void AlanHesapla();

        // 2. yol olarak EkranaYaz metodu oluştururak kullanabiliriz.

        public void EkranaYaz()
        {

            Console.WriteLine("Hesaplanan alan ...: " + Alan);

        }

    }

    class Kare : SekilBase
    {

        public Kare(int kenarUzunlugu)
        {
            BirinciKenar = kenarUzunlugu;
        }

        public override void AlanHesapla()
        {
            Alan = BirinciKenar * BirinciKenar;
            //Console.WriteLine("Karenin alanı : " + Alan);
        }
    }

    class Dikdortgen : SekilBase
    {
        public Dikdortgen(int birinciKenar, int ikinciKenar)
        {
            BirinciKenar = birinciKenar;
            İkinciKenar = ikinciKenar;
        }

        public override void AlanHesapla()
        {
            Alan = BirinciKenar * İkinciKenar;
            //Console.WriteLine("Dikdörtgenin alanı : " + Alan);
        }


    }

    class Ucgen : SekilBase
    {
        public Ucgen(int taban, int yukseklik)
        {
            Taban = taban;
            Yukseklik = yukseklik;
        }

        public override void AlanHesapla()
        {
            Alan = Taban * Yukseklik / 2;
            //Console.WriteLine("Üçgenin alanı : " + Alan);
        }


    }

    //class Cember
    //{
    //    public void AlanHesapla()
    //    {

    //        Console.WriteLine("Çember alanı hesaplandı.");
    //    }
        
    //}

}
