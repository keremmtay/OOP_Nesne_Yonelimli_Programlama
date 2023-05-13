using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Sealed_Classlar
{
    internal class OOP_Sealed_Classlar
    {
        static void Main(string[] args)
        {

            // sealed anahtar kelimesi: Inheritance konusunu ilgilendiren bir keyword'tür. 
            // Bir tane Class'ımız olduğunu düşünelim. Bu Class'ı herhangi bir Class'ın inherite etmesini istemiyorsak o Class'ta sealed keyword'ünü kullanmalıyız. 

        }
    }

    sealed class Dede
    {

        // sealed classını kullandığımızda başka sınıflar bu classı miras olarak alamıyor.

    }

    class Baba : Dede
    {



    }

    class Cocuk : Baba
    {



    }


}
