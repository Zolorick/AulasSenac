using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Claudio2_Ex2
{
    public class Octógono : Formas
    {
        public override int NumPontas { get; set; }
        public Octógono() 
        { 
            NumPontas = 8;
        }

        public override void CalculaArea()
        {
            Console.WriteLine("Calculando area: Octógono");
        }
    }
}
