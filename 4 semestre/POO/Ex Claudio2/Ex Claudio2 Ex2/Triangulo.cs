using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Claudio2_Ex2
{
    public class Triangulo: Formas
    {
        public override int NumPontas { get; set; }
        public Triangulo() 
        { 
            NumPontas = 3;
        }

        public override void CalculaArea()
        {
            Console.WriteLine("Calculando area: Triangulo");
        }
    }
}
