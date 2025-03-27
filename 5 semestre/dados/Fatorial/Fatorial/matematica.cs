using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatorial
{
    public class matematica
    {
        public int Fibonacchi(int n)
        {
            if (n <= 1)
                return n;
            return Fibonacchi(n - 1) + Fibonacchi(n - 2);
        }

        public List<int> GerarSequenciaFibonacci(int interacoes)
        {
            List<int> sequencia = new List<int>();
            for (int i = 1; i <= interacoes; i++)
            {
                sequencia.Add(Fibonacchi(i));
            }
            return sequencia;
        }
        public int FatorialNaoRecursivo(int numero) 
        {
          
            int resultado = 1;

            while (numero > 0)
            {
                if (numero == 0)
                {
                    resultado *= 1;
                    break;
                }
                resultado *= numero;
                numero--;
            }

            return resultado;
        }

        public int FatorialRecursivo(int numero)
        {
            if (numero == 0)
            {
                return 1;
            }
            return numero * FatorialRecursivo(numero - 1);
        }

        public int FatorialComRepetição(int total, int grupo)
        {
            return FatorialNaoRecursivo(total) / (FatorialRecursivo(grupo) * FatorialRecursivo(total - grupo));

        }

    }
}
