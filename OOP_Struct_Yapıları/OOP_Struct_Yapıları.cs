using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Struct_Yapıları
{
    internal class OOP_Struct_Yapıları
    {
        static void Main(string[] args)
        {

            #region Struct

            // Birbiri ile ilişkili olan değişkenleri bir yapı altında toplamak için kullanılır. 
            // Class'lar Referance Type değişkenlerdir. Fakat Struct'lar value tiplidir.
            // Struct ilk yaratıldığında default değerleri otomatik olarak atanır.
            
            // Struct'ı ne zaman kullanırız?
            // - Class'lar kadar karmaşık yapılar kullanılmayacaksa struct'lar kullanılabilir.

            // Class'ları kopyalarken farklı tepki verirken, Struct'ları kopyaladığımızda farklı bir tepki verir. Bu da Value Type olmalarından kaynaklıdır.
            // Interfaceler ile kullanılabilir. Bu durumda structlar referance type gibi davranırlar.
            // Class'lar ilk yaratıldıklarında null olabilirler. Ama structlar null olamaz yani default olan değerler atanır.

            ArabaClass arabaClass = new ArabaClass();
            arabaClass.Id = 1;
            arabaClass.Renk = "Kırmızı";
            arabaClass.Model = "BMW";


            ArabaStruct arabaStruct = new ArabaStruct();
            arabaStruct.Id = 2;
            arabaStruct.Renk = "Beyaz";
            arabaStruct.Model = "Mercedes";

            ArabaStruct X = default; // default keyword'ü burada yeni bir instance/örnek yaratmış oluyor.

            // Structlarda Contructor tanımlanabilir, tıpkı classlar gibi, ama parametresiz olamazlar..

            // Bir class değişken olarak kendisini kabul edebilir. Fakat bir struct kendisini değişken olarak kabul etmez..Başka bir struct kabul edilir.
            #endregion

        }
    }

    public class ArabaClass
    {

        public int Id { get; set; }
        public string Renk { get; set; }
        public string Model { get; set; }
        public ArabaClass araba { get; set; }



        public ArabaClass()
        {

        }

    }

    public struct ArabaStruct
    {
        public int Id { get; set; }
        public string Renk { get; set; }
        public string Model { get; set; }
        // public ArabaStruct araba { get; set; }
        public ArabaStruct2 araba { get; set; }

        public ArabaStruct(int id, string renk, string model)
        {
            // Constructor tanımlanacaksa, mutlaka parametreleri olmalı ve bütün değişkenlere, parametreden gelen değerler atanmalı.
            Id = id;
            Renk = renk;
            Model = model;
        }

        public void Metot()
        {

            // structlar da metotlara sahip olabilirler.

        }
    }
    public struct ArabaStruct2
    {



    }
}
