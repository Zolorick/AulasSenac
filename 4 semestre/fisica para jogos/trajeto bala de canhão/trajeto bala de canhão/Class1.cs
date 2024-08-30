using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trajeto_bala_de_canhão
{
    public class Entradas
    {

        public double velocidadeInicial { get; set; }
        public double anguloLancamento { get; set; }

        public void entrada()
        {

            Console.Write("Digite a velocidade inicial (m/s): ");
            velocidadeInicial = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o ângulo de lançamento (graus): ");
            anguloLancamento = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine();
        }

        public void linha()
        {

            Console.WriteLine();

            for (int i = 0; i < 50; i++)
            {
                Console.Write("-");
            }

            Console.WriteLine();

        }

        public void linhaIgual()
        {

            Console.WriteLine();

            for (int i = 0; i < 50; i++)
            {
                Console.Write("=");
            }

            Console.WriteLine();

        }

    }

}
