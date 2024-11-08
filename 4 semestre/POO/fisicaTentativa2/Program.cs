using System;
using fisicaTentativa2;

class Program
{
    static void Main(string[] args)
    {
        // Definição da matriz do caminho (0 = caminho, 1 = espaço não válido)
        int[,] caminho = {
                { 0, 0, 1, 0, 0 },
                { 0, 1, 1, 1, 0 },
                { 0, 0, 0, 1, 0 },
                { 1, 1, 0, 0, 0 },
                { 0, 0, 1, 1, 0 }
            };

        // Inicializa o robô na posição inicial
        Robo robo = new Robo(caminho);
        robo.Posicao = (0, 0); // Posição inicial do robô

        Console.WriteLine("Controle do Robô Seguidor de Linha");
        Console.WriteLine("Pressione 'a' para avançar ou 'q' para sair:");

        while (true)
        {
            robo.MostrarCaminho();
            char comando = Console.ReadKey(true).KeyChar;

            if (comando == 'a')
            {
                robo.Avancar();
            }
            else if (comando == 'q')
            {
                break;
            }
            else
            {
                Console.WriteLine("Comando inválido. Tente novamente.");
            }
        }
    }
}
   
