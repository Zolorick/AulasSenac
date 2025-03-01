using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterKitchen2
{
    public class Pilha //Primeiro a entrar, último a sair
    {

        private Prato? topo; // Topo da pilha
        private int tamanho = 0; // Tamanho da pilha

        public Prato Topo { get => topo; private set => topo = value; }
        public int Tamanho { get => tamanho; private set => tamanho = value; }

        public void Adicionar(Prato p) // Adiciona um elemento no topo da pilha
        {

            p.Proximo(topo); // Define o prato anterior ao topo
            topo = p; // Define o novo topo

            Console.WriteLine($"O prato foi adicionado à pilha");

            Tamanho++; // Aumenta o tamanho da pilha

        }

        public Prato Remover() // Remove o elemento do topo da pilha e atribuir o novo topo
        {
            Prato temp = topo; // Guarda o topo atual numa variável temporária

            topo = temp.Antes; // Atribui o prato anterior ao topo
            Console.WriteLine($"O prato foi removido da pilha");
            Tamanho--; // Diminui o tamanho da pilha
            temp.EstadoPrato(); // Inverte o estado do prato

            return temp; // Retorna o prato removido para ser usado em outro lugar
        }

        public void Zerar(Pilha p) // Limpa a pilha
        {
           while (Tamanho > 0) // Enquanto a pilha não estiver vazia
           {
                p.Adicionar(Remover()); // Remove o prato do topo
           }
        }

    }
}
