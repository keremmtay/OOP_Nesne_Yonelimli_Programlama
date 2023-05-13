using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class OOP_HataYonetimi_3
    {
        static void Main(string[] args)
        {

            // Kendi özel exception sınıfımızı oluşturma

            try
            {
                Login("abc 123", "123456789");
            }
            catch (LoginException ex)
            {

                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }

        static void Login(string kullaniciAdi, string sifre)
        {
            if (kullaniciAdi.Contains(" "))
            {
                throw new LoginException("Kullanıcı adı boşluk karakterini içeremez.");
            }
            if (sifre.Length < 8)
            {
                throw new LoginException("Şifre 8 karakterden küçük olamaz...");
            }


        }
    }

    class LoginException:Exception
    {
        public LoginException(string mesaj):base(mesaj)
        {


        }


    }
}
