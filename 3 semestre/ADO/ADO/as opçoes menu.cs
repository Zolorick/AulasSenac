using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace ADO
{
     public class as_opçoes_menu : Classe1 
    {
        Arq arq = new Arq();
        public int IniciarJogo() 
        {
            Console.WriteLine("Vamos jogar, o primeiro a fazer tres pontos vence");
            Console.WriteLine("Contra quem estou jogando?");

            string nome = Console.ReadLine();

            JogadaJogador = Jogo();

            return JogadaJogador;
        }

        public void Nome() 
        {
            Console.Write("oi 2");
        }

        public void ExibirResumo()
        {
           CriandoArq(nome_arq);
            LerArq(texto);
        }

        public void Sair()
        {
            Console.Write("oi 4");
        }
    }
}
