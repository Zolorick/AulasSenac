using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado_teste_2
{
    internal class Menus
    {
        string? nome;
        public int OpcaoValida, MenuOpcao, JogadaJogador,JogadaBot;
        bool TudoValido = false;

        public int Menu()
        {
            Limpeza.LimparNum(ref MenuOpcao);

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

        public string Name() 
        {
            Console.WriteLine("Contra quem estou jogando?");
            nome = Console.ReadLine();
            Console.WriteLine();
            return nome;  
        }
        public int Jogo(string nome, int PontosJogador, int PontosBot)
        {
            Limpeza.LimparNum(ref JogadaJogador);

            do
            {
                Console.WriteLine($"Esse é o nosso placar atual {nome}");
                Console.WriteLine($"{nome}: {PontosJogador}     x     Maquina: {PontosBot}");
                Console.WriteLine();
                Console.WriteLine(" Qual jogada gostaria de fazer?");
                Console.WriteLine();

                Console.WriteLine("1 - Pedra");
                Console.WriteLine("2 - Papel");
                Console.WriteLine("3 - Tesoura");
                Console.WriteLine();


                Checagem();

            } while (TudoValido == false);

            JogadaJogador = OpcaoValida;
            TudoValido = false;

            return JogadaJogador;
        }

        public int JogoBot() 
        {
            Random random = new Random();
            int OpcaoBot = random.Next(0, 2);
            switch (OpcaoBot) 
            {
                case 0:
                    JogadaBot = 1;
                break;

                case 1:
                    JogadaBot = 2;
                break;

                case 2:
                    JogadaBot = 3;
                break;
            }
            
            return JogadaBot;
        }

        public bool Checagem()
        {
            Limpeza.LimparNum(ref OpcaoValida);

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

    }
}
