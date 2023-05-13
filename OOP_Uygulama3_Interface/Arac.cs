using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OOP_Uygulama3_Interface
{
    abstract class Arac
    {
        public ConsoleColor Renk { get; set; }

        public Arac()
        {
            Random rnd = new Random();
            Thread.Sleep(500);      // milisecond türünden verdiğimiz değer kadar beklemeye alıyor...

            Renk =(ConsoleColor) rnd.Next(0,15);
        }
    }
}
