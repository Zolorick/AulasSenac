using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento_poo
{
    public class Carro
    {
        public int ticket { get; private set; }
        public Carro(int ordem) 
        {
            this.ticket = ordem;
        }

    }
}
