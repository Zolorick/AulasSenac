using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterKitchen2
{
    public class Fila
    {
        string[] fila;
        //tamanho da fila
        private int tamanho;
        //primeiro da fila
        private int inicio;
        // ultimo da fila
        private int final;
        //tamanho atual da fila
        private int tamanhoAtual;

        public Fila(int tamanho)
        {
            fila = new string[tamanho];
            Inicio = 0;
            Final = 0;
            TamanhoAtual = 0;
            this.Tamanho = tamanho;
        }

        public int Tamanho { get => tamanho; private set => tamanho = value; }
        public int Inicio { get => inicio; private set => inicio = value; }
        public int Final { get => final; private set => final = value; }
        public int TamanhoAtual { get => tamanhoAtual; private set => tamanhoAtual = value; }

        public void Adicionar(string pedido) 
        { 
          if(TamanhoAtual == Tamanho)
            {
              Console.WriteLine("Fila cheia");
            }

          else
            {
                fila[Final] = pedido;
                Console.WriteLine($"{pedido} adicionado a fila na posiçao {final}");
                Final = (Final + 1) % Tamanho;
                TamanhoAtual++;

            }
        
        }

        public string Retirar()
        {
            if (TamanhoAtual == 0)
            {
                return "Fila vazia";
            }
            else
            {
                string temp = fila[Inicio];
                Console.WriteLine($"{fila[inicio]} foi retirado da posicao {inicio}");
                fila[Inicio] = null; //so da pq aceita string nula, mas se nao der, pode deixzar ali, vai sobreescrever
               Inicio = (Inicio + 1) % Tamanho;
               TamanhoAtual--;
               return temp;
            }

        }

        public void ZerarFila()
        {
            foreach (string pedido in fila)
            {
                Retirar();
            }
        }

    }
}
