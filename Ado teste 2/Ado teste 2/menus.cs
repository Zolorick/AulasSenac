using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado_teste_2
{
    internal class Menus
    {
        string? nome, convertida, Resultado;
        public int OpcaoValida, MenuOpcao, JogadaJogador, JogadaBot;
        bool TudoValido = false;

        public int Menu()
        {
            Limpeza.LimparNum(ref MenuOpcao);

            do
            {
                Console.WriteLine();
                Console.WriteLine("Vamos jogar Pedra, papel e tesoura?");
                Console.WriteLine("O que gostaria de fazer?");
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
            Console.WriteLine();
            Console.WriteLine("Olá, com quem vou jogar hoje?");
            nome = Console.ReadLine();
            Console.WriteLine();
            return nome;
        }
        public int Jogo(string nome, int PontosJogador, int PontosBot)
        {
            Limpeza.LimparNum(ref JogadaJogador);

            do
            {
                Console.WriteLine();
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
            JogadaBot = random.Next(1, 3);

            return JogadaBot;
        }

        public string ConversaoJogada(int jogada)
        {
            switch (jogada)
            {
                case 1:
                    convertida = "Pedra";
                    break;

                case 2:
                    convertida = "Papel";
                    break;

                case 3:
                    convertida = "Tesoura";
                    break;

                default:
                    Console.WriteLine("erro na conversao das jogada");
                    break;
            }


            return convertida;
        }

        public string ResultadoRodada(int JogadaJogador, int JogadaBot, string nome)
        {
            if (JogadaJogador == JogadaBot)
            {
                Resultado = "empate";
            }
            else if ((JogadaJogador == 1 && JogadaBot == 3) ||
                     (JogadaJogador == 2 && JogadaBot == 1) ||
                     (JogadaJogador == 3 && JogadaBot == 2))
            {
                Resultado = $"vitória {nome}";
            }
            else
            {
                Resultado = "vitória máquina";
            }
            return Resultado;
        }

        public void QuerSalvar()
        {
            Console.WriteLine();
            Console.WriteLine("Você gostaria de salvar? (s/n)");
            Console.WriteLine("Esteja ciente que inserir uma resposta invalida resultará no fechamento do programa sem salvar");
            Console.WriteLine();
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
