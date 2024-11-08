using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fisicaTentativa2
{
    public class Robo
    {
        public (int x, int y) Posicao { get; set; }
        private int[,] caminho;
        private (int x, int y) posicaoAnterior;

        public Robo(int[,] caminho)
        {
            this.caminho = caminho;
            this.posicaoAnterior = (0, 0); // Inicia na posição inicial
        }

        public void Avancar()
        {
            posicaoAnterior = Posicao; // Armazena a posição atual antes de tentar avançar

            // Tenta mover para a direita
            if (Posicao.y + 1 < caminho.GetLength(1) && caminho[Posicao.x, Posicao.y + 1] == 0)
            {
                Posicao = (Posicao.x, Posicao.y + 1);
                Console.WriteLine($"O robô avançou para a posição: ({Posicao.x}, {Posicao.y})");
            }
            // Tenta mover para baixo
            else if (Posicao.x + 1 < caminho.GetLength(0) && caminho[Posicao.x + 1, Posicao.y] == 0)
            {
                Posicao = (Posicao.x + 1, Posicao.y);
                Console.WriteLine($"O robô avançou para a posição: ({Posicao.x}, {Posicao.y})");
            }
            // Se ambos os movimentos são inválidos
            else
            {
                Console.WriteLine("O robô encontrou um espaço não válido. Voltando à posição anterior.");
                Posicao = posicaoAnterior; // Retorna à posição anterior
                Console.WriteLine($"O robô voltou para a posição: ({Posicao.x}, {Posicao.y})");

                // Tenta novamente na próxima iteração
                return;
            }

            // Se o robô avançou com sucesso e encontrou um espaço não válido após o movimento
            if (!PodeAvancar())
            {
                Console.WriteLine("O robô encontrou um espaço não válido após avançar. Voltando à posição anterior.");
                Posicao = posicaoAnterior; // Retorna à posição anterior
                Console.WriteLine($"O robô voltou para a posição: ({Posicao.x}, {Posicao.y})");
            }
        }

        private bool PodeAvancar()
        {
            // Verifica se o próximo espaço à direita ou abaixo é válido
            return (Posicao.y + 1 < caminho.GetLength(1) && caminho[Posicao.x, Posicao.y + 1] == 0) ||
                   (Posicao.x + 1 < caminho.GetLength(0) && caminho[Posicao.x + 1, Posicao.y] == 0);
        }

        public void MostrarCaminho()
        {
            Console.Clear(); // Limpa a tela apenas uma vez por iteração
            Console.WriteLine("Matriz do Caminho:");

            for (int i = 0; i < caminho.GetLength(0); i++)
            {
                for (int j = 0; j < caminho.GetLength(1); j++)
                {
                    if ((i, j) == Posicao)
                    {
                        Console.Write("R "); // R representa o robô
                    }
                    else
                    {
                        Console.Write(caminho[i, j] + " ");
                    }
                }
                Console.WriteLine();
            }
        }

    }
}
