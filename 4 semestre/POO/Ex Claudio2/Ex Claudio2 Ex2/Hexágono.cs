using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Claudio2_Ex2
{
    public class Hexágono : Formas
    {
        public override int NumPontas { get; set; }
        public Hexágono() 
        { 
            NumPontas = 6;
        }

        public override void CalculaArea()
        {
            Console.WriteLine("Calculando area: Hexágono");
        }
    }
}
