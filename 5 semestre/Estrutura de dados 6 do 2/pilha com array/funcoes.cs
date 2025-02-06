using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pilha_com_array
{
    public class funcoes
    {
        public static int topo = 0;
        public void colocar(int[] pilha, int valor)
        {
            if (topo < pilha.Length)
            {
                pilha[topo] = valor;
                topo++;
            }
            else
            {
                Console.WriteLine("Pilha cheia");
            }
        }

        public void remove(int[] pilha)
        {
            if (topo > 0)
            {
                pilha[topo -1] = 0;
                topo--;
            }
            else
            {
                Console.WriteLine("Pilha vazia");
            }
        }

       public void olhar(int[] pilha)
        {
            if (topo > 0)
            {
                Console.WriteLine(pilha[topo -1]);
            }
            else
            {
                Console.WriteLine("Pilha vazia");
            }
        }

    }
}
