using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex_Claudio2_Ex_3;

namespace Ex_Claudio2_Ex_3
{
    public class ContaBancaria
    {
        private static int numConta = 1;
        private string titular;
        private double saldo;

        public int NumConta
        { get; private set; }
        public string Titular
        { get => titular; private set => titular = value; }
        public double Saldo
        { get => saldo; private set => saldo = value; }


        public ContaBancaria()
        {
            NumConta = numConta;
            numConta++;
            saldo = 0;

            Console.Write("Insira o nome do titular:");
            Titular = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("O saldo inicial da Conta é R$ 0,00");
            Console.WriteLine("Faça um deposito para começar as operações");
            Console.WriteLine("");
        }

        public void Depositar(Log log, Funcionario fun) 
        {

            Console.WriteLine("Qual o valor a ser depositado?");
            double deposito;
            if (double.TryParse(Console.ReadLine(), out deposito))
            {
                saldo =+ deposito;
                Console.WriteLine("Deposito realizado com sucesso");
                ConsultarSaldo();
                log.InfoDeposito(deposito, fun);
            }
            else 
            {
                Console.WriteLine("valor invalido");
            }


        }
        public void Sacar(Log log, Funcionario fun) 
        {

            Console.WriteLine("Qual o valor a ser sacado?");
            double saque;
            if (double.TryParse(Console.ReadLine(), out saque))
            {
                if (saldo >= saque) 
                {
                    saldo =- saque;
                    Console.Write("Saque realizado com sucesso");
                    ConsultarSaldo();
                    log.InfoSaque(saque, fun);
                }
                else 
                { 
                    Console.WriteLine("Saldo insuficiente");
                    ConsultarSaldo();
                }
            }
            else
            {
                Console.WriteLine("valor invalido");
            }

        }
        public void ConsultarSaldo() 
        {
            Console.WriteLine($"O saldo da conta n° {NumConta} é de R$ {Saldo}");
        }

    }
}
