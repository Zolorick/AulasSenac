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

        public void Lancamento()
        {

            Console.Write("Qual a velocidade inicial do lancamento? (m/s): ");
            velocidadeInicial = Convert.ToDouble(Console.ReadLine());

            Console.Write("Qual o ângulo de lançamento? (graus): ");
            anguloLancamento = Convert.ToDouble(Console.ReadLine());

        }

        public void Linha()
        {

            Console.WriteLine();

            for (int i = 0; i < 50; i++)
            {
                Console.Write("*");
            }

            Console.WriteLine();

        }

        public void OutraLinha()
        {

            Console.WriteLine();

            for (int i = 0; i < 20; i++)
            {
                Console.Write("°_° ");
            }

            Console.WriteLine();
            Console.WriteLine();

        }

    }

}
