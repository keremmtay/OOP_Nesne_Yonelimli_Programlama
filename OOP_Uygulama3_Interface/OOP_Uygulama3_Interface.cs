using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Uygulama3_Interface
{
    internal class OOP_Uygulama3_Interface
    {
        static void Main(string[] args)
        {

            // Araçları boyayan bi boyahane uygulaması yazılacak. 
            // Ferrari, Serce, BMX(Boyanmamalı)
            
            Ferrari ferrari = new Ferrari();
            Serce serce = new Serce();
            BMX bmx = new BMX();

            Console.WriteLine(ferrari);
            Console.WriteLine(serce);
            Console.WriteLine(bmx);

            Boyahane boyahane = new Boyahane();

            Console.ReadLine();

            boyahane.Boya(ferrari, ConsoleColor.Red);
            Console.WriteLine(ferrari);

            Console.ReadLine();

            boyahane.Boya(serce, ConsoleColor.Blue);
            Console.WriteLine(serce);
            
            //boyahane.Boya(bmx, ConsoleColor.White);
            //Console.WriteLine(bmx);

            Console.ReadLine();

        }
    }       
}
