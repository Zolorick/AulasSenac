using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Claudio2_EX1
{
    public class Bicicleta: Veiculo
    {
        public override void Mover() 
        {
            Console.WriteLine("Bicicleta se move");
        }

        public override void Acelerar()
        {
            Console.WriteLine("Bicicleta acelera");
        }
    }
}
