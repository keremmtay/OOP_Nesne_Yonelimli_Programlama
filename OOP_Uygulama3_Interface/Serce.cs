﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Uygulama3_Interface
{
    internal class Serce : Arac, IBoyanabilir
    {
        public override string ToString()
        {
            Console.ForegroundColor = Renk;
            return "Serçe";
        }
    }
}
