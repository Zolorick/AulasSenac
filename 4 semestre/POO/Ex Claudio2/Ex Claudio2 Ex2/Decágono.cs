using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Claudio2_Ex2
{
    public class Decágono : Formas
    {
        public override int NumPontas { get; set; }
        public Decágono() 
        { 
            NumPontas = 10;
        }

        public override void CalculaArea()
        {
            Console.WriteLine("Calculando area: Decágono");
        }
    }
}
