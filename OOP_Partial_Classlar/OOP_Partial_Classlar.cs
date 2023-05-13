using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Partial_Classlar
{
    internal class OOP_Partial_Classlar
    {
        static void Main(string[] args)
        {

            #region Partial / Parçalı Class'lar

            // partial Class: Kelime anlamı parçalı sınıflardır.
            // Bir Class'ın birden fazla dosyadan oluşması anlamına gelir. Yani fiziksel olarak farklı dosyalarda rağmen aynı class ismine sahip oldukları için arka planda tek bir class olarak çalışırlar. Bunun için gerekli olan şart, class'ın partial olarak işaretlenmesi gerekiyor...
            // Bazı projelerde Class'ın içeriği çok fazla büyük olabiliyor. Bu da Class'ın yönetlmesini zorlaştırabiliyor. Bu gibi durumlarda partial class kullanılabilir.
            // Ya da bir projede genellikle birden fazla yazılımcı çalışır. Aymo Class'a farklı kişilerin ihtiyacı olabilir. Yine bu gibi durumlarda partial Class kullanılabilir.


            Ornek a = new Ornek();
            a.Id = 2;
            a.Name = "abc";
            a.Metot1();
            a.Metot2();
            a.Metot3();
            a.Metot4();



            #endregion

        }
    }

    partial class Ornek
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public void Metot3()
        {
            Console.WriteLine("Metot3");
        }

    }

    partial class Ornek
    {
        public void Metot1()
        {
            Console.WriteLine("Metot1");
        }
        public void Metot2()
        {
            Console.WriteLine("Metot2");
        }

    }

    partial class Ornek
    {
        public void Metot4()
        {
            Console.WriteLine("Metot4");
        }

    }

}
