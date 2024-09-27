using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
     public class ContaBancaria
    {
        //protegendo meus valores
        private int NumeroConta;
        private double Saldo; 


        //Construtor com parrametros
        public ContaBancaria(int numero, double dinheiro)
        {
            NumeroConta = numero; 
            Saldo = dinheiro;
        }

        //dando acesso
        public int _NumeroConta 
        { 

            get => NumeroConta; 
            private set => NumeroConta = value;
            
        }

        public double _Saldo
        { 
        
            get => Saldo;
            set => Saldo = value;
        
        }

    }
}
