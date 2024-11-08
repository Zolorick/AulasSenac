using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Claudio2_Ex2
{
    public class Quadrilátero : Formas
    {
        public override int NumPontas { get; set; }
        public Quadrilátero() 
        { 
            NumPontas = 4;
        }

        public override void CalculaArea()
        {
            Console.WriteLine("Calculando area: Quadrilátero");
        }
    }

}
