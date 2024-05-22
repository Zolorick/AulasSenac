using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO
{
    public class Classe1
    {
       public int OpcaoValida, MenuOpcao;
       bool TudoValido = false;

        public int Menu() 
        {
            LimparValor(ref MenuOpcao);

            do
            {
                Console.WriteLine();
                Console.WriteLine("Bem-vindo, vamos jogar Pedra, papel e tesoura?");
                Console.WriteLine(" O que gostaria de fazer?");
                Console.WriteLine();

                Console.WriteLine("1 - iniciar jogo");
                Console.WriteLine("2 - Exibir resumo");
                Console.WriteLine("3 - Sair");
                Console.WriteLine();

                Checagem();

            } while (TudoValido == false);

            MenuOpcao = OpcaoValida;
            TudoValido = false;

            return MenuOpcao;
        }

        private bool Checagem()
        {
            LimparValor(ref OpcaoValida);

            string? Opcao = Console.ReadLine();
            if (int.TryParse(Opcao, out OpcaoValida))
            {
                if (OpcaoValida > 0 && OpcaoValida < 4)
                { TudoValido = true; }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Sua resposta deve ser um valor entre 1 e 3, vamos tentar de novo");
                    Console.WriteLine();
                }
            }
            else 
            {
                Console.WriteLine();
                Console.WriteLine("Sua resposta deve ser um valor inteiro, vamos tentar de novo");
                Console.WriteLine();
            }
            return TudoValido;
        }

        private void LimparValor(ref int _var)
        {
            _var = 0;
        }
    }
}
