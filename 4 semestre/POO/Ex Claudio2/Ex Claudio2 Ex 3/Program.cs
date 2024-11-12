/*Crie uma classe ContaBancariacom os atributos numeroConta, titular e saldo. 
 * Encapsule os atributos e crie métodos para depositar, sacar e consultar o saldo. 
 * Implemente validações para garantir que o saldo não seja negativo após uma retirada.
 * Crie uma classe para armazenar os dados dos Funcionários.
 * Crie uma classe de Log para armazenar as transações realizadas. 
 * -Um depósito deve armazenar o valor depositado, a data e hora, o funcionário que realizou o depósito e o código da transação, 
 * -Um saque deve armazenar valor sacado, data e hora do saque, funcionário que autorizou o saque e código da transação.
 * */

using Ex_Claudio2_Ex_3;
using System;

int opcao;
Log log = new Log();
Funcionario f1 = new Funcionario();
Console.WriteLine("");
Console.WriteLine("Bem vindo");
Console.WriteLine("Criando conta");
Console.WriteLine("");
ContaBancaria c1 = new ContaBancaria();

do
{
    opcao = 0;
    Console.WriteLine("");
    Console.WriteLine("O que deseja fazer?");
    Console.WriteLine("");
    Console.WriteLine("1 - Fazer Saque");
    Console.WriteLine("2 - Fazer depósito");
    Console.WriteLine("3 - Consultar saldo");
    Console.WriteLine("4 - Sair");

    if (int.TryParse(Console.ReadLine(), out opcao))
    {}
    else
    {
        Console.WriteLine("precisa ser um numero inteiro");
    }
    Console.WriteLine("");

    switch (opcao) 
    {
        case 1:
            c1.Sacar(log, f1);
            Console.WriteLine("");
            break;

        case 2:
            c1.Depositar(log, f1);
            Console.WriteLine("");
            break;

        case 3:
            c1.ConsultarSaldo();
            Console.WriteLine("");
            break;

        case 4:
            break;

        default: 
            Console.WriteLine("opção invalida");
            Console.WriteLine("");
            break;

    }
        

} while (opcao!= 4);
