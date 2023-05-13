using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HataYonetimi_2
{
    internal class OOP_HataYonetimi_2
    {
        static void Main(string[] args)
        {

            // 

            string parola = "123456";

            try
            {
                sifreKontrolEt(parola);
                Console.WriteLine("Oluşturduğunuz parola geçerli");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }

            Console.WriteLine("Program try-catch'den sonra devam ediyor.");
            Console.ReadLine();
        }

        static void sifreKontrolEt(string sifre)
        {

            if (sifre.Length < 8 || sifre.Length > 15)
            {
                throw new Exception("Şifreniz 8 ile 15 karakter arasında olmalı");
            }

        }
    }
}
