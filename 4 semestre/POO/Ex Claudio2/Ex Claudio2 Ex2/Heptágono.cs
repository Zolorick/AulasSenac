﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Claudio2_Ex2
{
    public class Heptágono : Formas
    {
        public override int NumPontas { get; set; }
        public Heptágono() 
        { 
            NumPontas = 7;
        }

        public override void CalculaArea()
        {
            Console.WriteLine("Calculando area: Heptágono");
        }
    }
}
