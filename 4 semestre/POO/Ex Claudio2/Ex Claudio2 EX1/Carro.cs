using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Claudio2_EX1
{
    public class Carro: Veiculo
    {
        public override void Mover() 
        {
            Console.WriteLine("Carro se move");
        }

        public override void Acelerar() 
        { 
            Console.WriteLine("Carro acelera");
        }
    }
}
