using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Enum
{
    internal class OOP_Enum
    {
        static void Main(string[] args)
        {

            string gun = "";

            if (HaftaninGunleri.Pazartesi.ToString() == gun)
            {
                Console.WriteLine("İf bloğunun içine girildi");
            }

            string farkliGun = HaftaninGunleri.Carsamba.ToString();
            Console.WriteLine(farkliGun);
            Console.WriteLine((int)(HaftaninGunleri.Cuma));

            Console.ReadLine();
        }
    }

    public enum HaftaninGunleri
    {

        Pazartesi = 1, Sali, Carsamba, Persembe, Cuma, Cumartesi, Pazar

    }

    public enum Plakalar
    {

        Adana, Afyon

    }

    public enum TelefonKodlari
    {



    }

    public enum Aylar
    {

        Ocak = 1, Subat, Mart

    }
}
