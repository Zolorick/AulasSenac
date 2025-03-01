using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace MasterKitchen2
{
    public class Prato
    {
        //Atributos
        private E_EstadoPrato estado; // Estado do prato entre limpo e sujo
        private Prato? antes = null; // Prato anterior na pilha

        //Construtor
        public Prato()
        {
            estado = E_EstadoPrato.limpo; // Inicializa o prato como limpo
        }

        //Proteção dos atributos
        public E_EstadoPrato Estado { get => estado; private set => estado = value; }
        public Prato Antes { get => antes; } // Não tem set, pois o prato anterior não pode ser alterado



        public void Proximo(Prato? _antes) // Define o prato anterior
        {
            antes = _antes;
        }



        public void EstadoPrato() // Inverte o estado do prato
        {
            if (estado == E_EstadoPrato.limpo)
            {
                estado = E_EstadoPrato.sujo;
            }
            else if (estado == E_EstadoPrato.sujo)
            {
                estado = E_EstadoPrato.limpo;
            }
            else
            {
                Console.WriteLine("Estado do prato inválido");
            }
        }

    }
}
