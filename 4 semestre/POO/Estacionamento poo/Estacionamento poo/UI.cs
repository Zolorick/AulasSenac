using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento_poo
{
    public class UI
    {
        public void Opcoes() 
        {
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Estacionar novo carro");
            Console.WriteLine("2 - Sair com um carro");
            Console.WriteLine("3 - Ver carros estacionados");
            Console.WriteLine("4 - Encerrar o dia");
        }
        public void Linha() 
        {
            Console.WriteLine();
            for (int i = 0; i < 15; i++) 
            {
                Console.Write("*_* ");
            }
            Console.WriteLine();
        }

        public void LinhaSimples()
        {
            Console.WriteLine();
            for (int i = 0; i < 40; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }

    }

}
