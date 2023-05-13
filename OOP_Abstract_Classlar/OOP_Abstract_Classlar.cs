using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Abstract_Classlar
{
    internal class OOP_Abstract_Classlar
    {
        static void Main(string[] args)
        {

            #region Abstract Metotlar/Classlar


            // Abstract classlar soyut sınıflardır. Yani bir nesnesi ya da örneği alınamaz. Yani class olmalarına rağmen new'lenemezler. 
            // Abstract Classlar kendisi miras alacak sınıflara bir takım metotlar ya da property'ler sağlamak amacı ile oluşturulur.
            // Bir Class'ı abstract yapabilmek için abstract anahtar sözcüğü kullanılır.

            // Abstract olarak işaretlenen metotların gövdesi/scope olmaz.
            // Bir sınıf içerisinde abstract olarak işaretlenen metot ve property'leri, bu sınıftan kalıtım alan her sınıf kendi içerisinde uygulamak/implement etmek zorundadır.
            // Abstract elemanlar private olarak işaretlenemezler.
            // Eğer bir Class, abstract bir elemana sahipse o Class da abstract olarak işaretlenmelidir.
            // Abstract sınıfların nesnesi oluşturulamaz. Fakat referans noktası oluşturulabilir.



            // MyBaseClass myBaseClass = new MyBaseClass();

            MyClass myClass = new MyClass();
            myClass.MyMethod1();
            myClass.MyMethod2();

            MyClass2 myClass2 = new MyClass2();
            myClass2.MyMethod2();
            myClass2.MyMethod1();

            #endregion

          

            Console.ReadLine();
        }
    }

    abstract class MyBaseClass
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public abstract void MyMethod1();

        //public void MyMethod1()
        //{

        //    Console.WriteLine("Burası MyBaseClass içindeki MyMethod1 metodu");

        //

        public void MyMethod2()
        {

            // abstract Classlar içerisinde gövdesi olan metotlar da tanımlanabilir
            Console.WriteLine("MyBaseClass içindeki MyMethod2()");



        }
    }

    class MyClass : MyBaseClass
    {

        public override void MyMethod1()
        {
            Console.WriteLine("Burası MyClass içindeki MyMethod1 metodu");
        }

    }

    class MyClass2 : MyBaseClass
    {

        public override void MyMethod1()
        {
            Console.WriteLine("Burası MyClass2 içindeki MyMethod1 metodu");
        }


    }
}
