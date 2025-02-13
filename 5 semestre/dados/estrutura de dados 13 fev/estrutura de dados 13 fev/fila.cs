using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estrutura_de_dados_13_fev
{
    //fila usando vetor
    public class Fila
    {
       public int inicio { get; private set; }
       public int fim { get; private set; }
       public int tamanhoAtual { get; private set; }

       int[] nome = new int[10];

        public Fila()
        {  
            Console.WriteLine("Fila criada, ela tem 10 lugares");
        }
        public void tirar()
        {
            Console.WriteLine("");
        }

        public void inserir()
        {
            Console.WriteLine("");
        }

        public void mostrar()
        {
            Console.WriteLine($"{nome[0]}");
        }

        public void ReOrganizar()
        {
            Console.WriteLine("");
        }   

    }
}
