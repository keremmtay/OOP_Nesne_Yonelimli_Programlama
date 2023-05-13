using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence_MirasAlma_Konusu
{
    internal class Inheritence_MirasAlma_Konusu
    {
        static void Main(string[] args)
        {

            #region Inheritance / Miras Alma

            // OOP'de ortak alanlar bir üst sınıfta tanımlanır.
            // Inherite edilen Class'ın bütün elemanları miras verilen Class'ın elemanı gibi çalışır.
            // Bir Class birden fazla Class'a inherit edilebilir.
            // Parent / Child ilişkisi vardır. (Ebeveyn/Çocuk) bunlara Base Class ve Derived Class denir.
            // Bir Class sadece bir Class'ı miras alabilir.
            // Y isimli class, X isimli Class'tan miras aldıysa ve Z isimli Class Y isimli Class'ı miras aldıysa; Z isimli Class, hem X'in hem de Y'nin bütün metot ve property'lerine sahip olacaktır.

            Dede dede = new Dede();
            dede.Id = 1;
            dede.MetotDede();

            Baba baba = new Baba();
            baba.BabaId = 5;
            baba.MetotBaba();
            baba.Id = 1;
            baba.MetotDede();

            Cocuk cocuk = new Cocuk();
            cocuk.BabaId = 1;
            cocuk.MetotBaba();
            cocuk.CocukId = 1;
            cocuk.MetotCocuk();
            cocuk.MetotDede();
            cocuk.Id = 1;

            // Object sınıfı: Class'ların Atası

            // Oluşturulan bütün class'lar Object sınıfını miras alır. Object sınıfı içindeki metotlara diğer sınıflar da sahiptir. Dede sınıfında ToString() isimli bir metot tanımlamamamıza rağmen dede nesnesinin içinde bu metodu göreceğiz.

            Object obj = new Object();
            dede.ToString();
            

            #endregion

            Console.ReadLine();
        }
    }

    class Dede
    {
        public int Id { get; set; }

        public void MetotDede()
        {


        }
    }

    // Bir sınıf başka bir sınıfı miras alacaksa syntax'ı aşağıdaki gibi olmalıdır. 
    // class MirasAlanSınıf : MirasVerenSınıf
    // {}

    class Baba : Dede
    {

        public int BabaId { get; set; }

        public void MetotBaba()
        {


        }


    }

    class Anne
    {


    }

    class Cocuk : Baba //, Anne          //      Birden fazla class'ı miras alamıyor
    {
        public int CocukId { get; set; }

        public void MetotCocuk()
        {


        }
    }

}
