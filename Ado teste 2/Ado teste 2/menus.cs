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

            }


            return convertida;
        }

        public string ResultadoRodada(int JogadaJogador, int JogadaBot, string ConvertidaJogador, string ConvertidaBot, string nome)
        {
            //referente ao jogador
            switch (JogadaJogador, JogadaBot)
            {
                case (1, 2):
                    break;

                default:
                  Resultado = "empate";
                    break;
            }

            //precisa estar assim pro if de pontos funfar
           // $"vitória {nome}"


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
