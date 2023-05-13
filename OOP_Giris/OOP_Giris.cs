using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Giris
{
    internal class OOP_Giris
    {
        static void Main(string[] args)
        {
            #region Classlar

            Ornek ornek;
            ornek = new Ornek();

            new Ornek(); // Kodu bu şekilde yazdığımızda Ornek sınıfından bir nesne oluşturmuş olyoruz.

            ornek.isim = "Ali";
            ornek.soyisim = "Kaya";
            ornek.yas = 15;
            //ornek.cinsiyet = 'E';

            //Console.WriteLine(ornek.isim + " " + ornek.soyisim + " " + ornek.yas + " " + ornek.cinsiyet);

            ornek.Metot();

            Ornek o1 = new Ornek();
            Ornek o2 = new Ornek();
            Ornek o3 = new Ornek();
            o1.isim = "Mustafa";

            #endregion

            Console.ReadLine();
        }

        // Class Nasıl oluşturulur?

        ///[erişim belirleyicisi] class [Classİsmi]
        ///{
        ///
        /// 
        /// }
        /// 

        // Class oluşturmak istiyorsak mutlaka bu namespace içerisinde oluşturabiliriz. Genel kabul görmüş kurallar gereği namespace'in içerisinde oluştururuz.
        // Classları aynı dosya içinde oluşturabildiğimiz gibi farklı dosyalarda da oluşturabiliriz.
        // Bir Class'ı diğer bir Class'ın içinde tanımlayabiliyoruz. Buna Nested Class'lar denir.

        // İsimlendirme kurallarına baktığımızda aynı yerde, yani aynı namespace altında, aynı isimli birden fazla class tanımlayamayız.

        // Sınıf modellemesi

        // Eğer veriler üzerinde bir işlem yapacak isem o zaman sınıf içerisinde değişken dediğimiz field'ları ya da property'ler tanımlayarak modelleme yaparız. 

        // Eğer operasyonel/eylemsel işlemler yapılıcaksa o zaman ağırlıklı olarak metotlardan oluşan bir class modellemesi yapılır.

        // Bir Class'tan sonsuz sayıda nesne/object üretilebilir. Örneğin 2 tane nesne ürettik. Her iki nesne içerisinde class içerisinde tanımladığım alanlara/fieldlara ulaşabiliyorum. Fakat bu nesnelerin içinde tutulan veriler birbirinden farklıdır.
        

    }

    class Ornek
    {

        // Field : Özelliklerini, field dediğimiz yapılarda yani değişkenlerde tutuyoruz.

        public string isim;
        public string soyisim;
        public int yas;
        public char cinsiyet;

        public void Metot()
        {
            // 

        }

        public void Metot2()
        {



        }
    }

    // Eğer biz özelliği tutacağımız değişkeni tanımladığımız yer Class seviyesindeyse buna field/alan denir.
    // Eğer metod içinde tanımlandıysa buna da değişken denmektedir.


    class DenemeProperty
    {

        // Property : Özünde birer metotdur ama parametre almayan metodlardır. Ve bizim verilerimizi tutarlar. 
        // İçerisinde set ve get isimli bloklar barındırır..
        // Aşağıda Sehir isimli bir property tanımladık.
        string sehir;



        public string Sehir
        {
            get
            {
                // property içindeki değeri kullanmak istediğimizde get bloğunu kullanıyoruz. Aslında değeri alırken burası otomatik olarak tetikleniyor.
                sehir = "Marmara Bölgesi";
                return sehir;

            }
            set
            {
                // Property'e bir veri atandığında bunu set bloğunda yakalıyoruz. Burası normalde bir veri ataması yapıldığında otomatik olarak tetikleniyor. Eğer ki set bloğu tanımlanmaz ise readonly bir property tanımlamış oluyoruz.
                sehir = value;
            }

        }

        string cardNumber;
        
        public string CardNumber
        {
            get
            {
                // 1234 4566 7899 1234
                cardNumber = cardNumber.Remove(0, 11);
                //                1234 şeklinde yazılır
                return cardNumber;

            }
            set
            {
                cardNumber = value;
                
            }

        }

        int yas;

        public int Yas
        {

            get
            {

                return yas+5;
            }
            set
            {
                yas = value;

            }
        }


        // Propertyleri kullanma amacımız:
        /// Field'lara direkt erişimi engellemek için kullanılır.
        /// Dışarıya verdiğimiz veriyi kontrollü bir şekilde verebiliyoruz.
        /// Yani data manipülasyonu yaparak gerçek veriyi gizlemeye ya da istediğimiz veriyi karşı tarafa göstermeye yardımcı olan yapıdır.
        /// Yani field'ın almış olduğu veriyi get bloğu içerisine manipüle ederek bu veriye ulaşmak isteyen kişilere istediğim veriyim gösterebiliyorum..
        /// Bu yapı da aslında Encapsulation/Kapsülleme deniyor.

        // Property tanımlamak için 2. yol

        public string Name { get; set; } = "Ahmet";

        // prop yazıp 2 defa TAB bastığımızda da property oluşturabiliriz

        public int Yas1 { get; set; }



    }
}
