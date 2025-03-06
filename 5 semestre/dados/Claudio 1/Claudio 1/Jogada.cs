using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Claudio_1
{
    public class Jogada
    {
        public int jogador;
        string jogada;
        public Jogada proximaJogada = null;
        static Jogada PrimeiraJogada = null;
        static Jogada UltimaJogada = null;
        public static int jogadorAtual = 1;

        public Jogada() 
        {
            Console.WriteLine("escreva sua jogada");
            jogada = Console.ReadLine();
            this.jogador = jogadorAtual;

            if (PrimeiraJogada == null)
            {
                PrimeiraJogada = this;
                UltimaJogada = this;
            }
            else
            {
                UltimaJogada.proximaJogada = this;
                UltimaJogada = this;
            }
        }

        public void ProximaJogada(Jogada proximaJogada)
        {
            this.proximaJogada = proximaJogada;
        }



        public string ExecutarJogada()
        {
            return $"Executando jogada {jogada} por jogador {jogador}";
        }

        public static void ExecutarTodasJogadas()
        {
            Jogada atual = PrimeiraJogada;
            while (atual != null)
            {
                Console.WriteLine(atual.ExecutarJogada());
                atual = atual.proximaJogada;
            }

            LimparJogadas();
        }

        public static void LimparJogadas()
        {
            PrimeiraJogada = null;
            UltimaJogada = null;

            AlternarJogador();

        }

        public static void AlternarJogador()
        {
            jogadorAtual = (jogadorAtual == 1) ? 2 : 1;
        }
    }
}
