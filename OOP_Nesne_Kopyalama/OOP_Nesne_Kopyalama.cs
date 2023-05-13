using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Nesne_Kopyalama
{
    internal class OOP_Nesne_Kopyalama
    {
        static void Main(string[] args)
        {

            #region Değişken Kopyalama - Value Types

            int a = 5;
            int b;
            a = 89;
            b = a;
            Console.WriteLine(a);
            a = 10;
            Console.WriteLine(a);
            Console.WriteLine(b);

            #endregion

            #region Değişken Kopyalama - Referance Type için

            Urun x = new Urun();
            x.UrunAdi = "Iphone";
            x.KategoriAdi = "Telefon";
            x.Fiyat = 150;
            Console.WriteLine(x.UrunAdi);           // Iphone

            Urun y = new Urun();
            y.UrunAdi = "Samsung";
            Console.WriteLine(y.UrunAdi);           // Samsung

            y = x;

            // Y için bir nesne oluşturulmadı. Fakat X için oluşturulan nesnenin referansı bu atama ile Y değişkenine kaydedilmiş oldu. Sonuç olarak yukarıda X için oluşturulan nesneye hem X üzerinden hem de Y üzerinden ulaşabilir hale geldik.
            // Nesneler kopyalanmıyor. Nesnenin referansı  kopyalanıyor. Bu durumda X'i de kullansam Y'yi de kullansam aynı nesneye ulaşmış oluyorum.

            Console.WriteLine(y.UrunAdi);           // y = x sayesinde y.UrunAdi = x.UrunAdi yani Iphone olmuş oldu

            //y.UrunAdi = "Samsung";
            //Console.WriteLine(x.UrunAdi);           // Iphone
            
            // KENDİ NOTUM :::  referance type için kopyalama yaparken referans adresini kopyalarız, verinin kendisini değil. Bu yüzden bu referans adresinde bir değişiklik yaptığımızda orjinali de değişir ve x.UrunAdi değişmiş olur.


            Urun z = new Urun();

            y.UrunAdi = "ABC";

            z = x.NesneKopyala();

            z.UrunAdi = "Nokia";
            Console.WriteLine("\n*****************\n");
            Console.WriteLine(x.UrunAdi);
            Console.WriteLine(y.UrunAdi);
            Console.WriteLine(z.UrunAdi);


            #endregion

            Console.ReadLine();
        }
    }


    public class Urun
    {

        public string UrunAdi { get; set; }

        public string KategoriAdi { get; set; }

        public int Fiyat { get; set; }

        public Urun NesneKopyala()
        {

            return (Urun)this.MemberwiseClone(); // Nesneleri kopyalamak istediğimizde bu şekilde kopyalayabiliriz.

        }

    }
}
