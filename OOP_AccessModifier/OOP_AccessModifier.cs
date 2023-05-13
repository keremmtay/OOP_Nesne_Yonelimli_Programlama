using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_AccessModifier
{
    internal class OOP_AccessModifier
    {
        static void Main(string[] args)
        {
            #region Access Modifiers / Erişim Belirleyiciler

            #region Public

            // Public ile tanımlanan alanlara farklı projeler dahil her yerden erişim sağlanır. Private olarak tanımlarsak ulaşamayız.

            Deneme deneme = new Deneme();
            deneme.Isim = "Mustafa";

            #endregion

            #region Internal

            // Internal olarak tanımladığımız bir değişken ya da sınıf aynı public'te olduğu gibi proje içinde ya da namespace alanı içerisinden erişebiliyoruz.
            // Public'ten farkı, diğer projelerden erişime izin vermemesidir.
            // Internal sınıflar için default olarak erişim belirleyicisidir. Belirtilmediği takdirde internal olarak atanır.

            #endregion

            #region Protected

            // Protected ile tanımlanan alanlara sadece tanımlandığı sınıftan ya da o sınıfı miras (inheritence) alan diğer sınıflardan da ulaşabiliyoruz.

            #endregion

            #region Protected Internal

            // Hem Protected hem de internalın özelliklerinin birleşimidir.
            // Aynı solution içerisinde fakat farklı proje ya da namespace içerisinde olan bir sınıf başka bir sınıfı miras almış ve ilgili alan protected Internal ile tanımlanmış ise bu alana ulaşılabilir.            

            #endregion

            #region Private

            // Private olarak tanımlanan alana sadece o sınıf içerisinden ulaşabiliyoruz. Erişim belirleyiciler arasında en çok sınırlayıcı olan Private'tır.
            // Değişkenlerde deafult olarak private değerini alır.

            int a;          // default olarak private

            #endregion

            #endregion

        }
    }

    class Deneme
    {
        public string Isim { get; set; }


    }
}
