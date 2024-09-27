using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exercicio1
{
    public class OperacoesBancarias
    {
        public void Sacar(double saque, ContaBancaria conta)
        {
            if (saque <= conta._Saldo) 
            {
                conta._Saldo -= saque;
                Console.WriteLine($"Saque de {saque} realizado com sucesso.");
                MostrarSaldo(conta);
                
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para o saque.");
            }

        }

        public void Depositar(double deposito, ContaBancaria conta)
        {
            conta._Saldo += deposito;
            Console.WriteLine($"Depósito de {deposito} realizado com sucesso.");
            MostrarSaldo(conta);

        }

        public void MostrarSaldo(ContaBancaria conta) 
        {
            Console.WriteLine($"Saldo atual: R$ {conta._Saldo}");
        }

        public double ValorParaOperacao() 
        {
            double valorDob;
            string VarStr = Console.ReadLine();
            double.TryParse(VarStr, out valorDob);

            return valorDob;
        }
       



    }
}
