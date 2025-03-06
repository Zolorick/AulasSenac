using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Claudio_1
{
    public class Menu
    {
        public int MostarOpcoes() 
        {
            int escolha;
            Console.WriteLine();
            Console.WriteLine("Escolha uma opção");
            Console.WriteLine();
            Console.WriteLine("1 - adicionar jogada");
            Console.WriteLine("2 - encerrar turno");
            Console.WriteLine("3 - sair do jogo");
            Console.WriteLine();
            string esString = Console.ReadLine();

            if (!int.TryParse(esString, out escolha))
            {
                Console.WriteLine("Opção inválida");
                return MostarOpcoes();
            }
            else if (escolha < 1 || escolha > 3)
            {
                Console.WriteLine("Opção inválida");
                return MostarOpcoes();
            }
            else
            {
                return escolha;
            }
            
        }

        public void EncerrarTurno()
        {
            Console.WriteLine("Turno encerrado");
            Console.WriteLine();
            Console.WriteLine();

            Jogada.ExecutarTodasJogadas();
            //executar jogadas
              
            


            Console.WriteLine("Vez do jogador" + Jogada.jogadorAtual);
            
            MostarOpcoes();
        }

        public void encerrarJogo()
        {
            Console.WriteLine("Jogo encerrado!");
        }
    }
}
