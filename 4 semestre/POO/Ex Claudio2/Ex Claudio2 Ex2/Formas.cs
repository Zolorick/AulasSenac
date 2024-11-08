using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Claudio2_Ex2
{
    public abstract class Formas: IForma
    {
        public void CriarForma(int NumPontas) 
        {
            Console.WriteLine($"Desenhando forma de {NumPontas} pontas");
        }
        public abstract void CalculaArea();

        public abstract int NumPontas { get; set; }
    }
}
