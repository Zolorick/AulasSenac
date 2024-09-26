//Crie uma classe ContaBancaria com os atributos privados numeroConta e saldo.
//Implemente métodos públicos para depositar e sacar dinheiro
//garantindo que o saldo nunca fique negativo.
//Utilize encapsulamento para proteger os atributos.

using Exercicio1;

OperacoesBancarias operacoes = new OperacoesBancarias();
ContaBancaria c1 = new ContaBancaria(12, 50);


operacoes.Depositar(50.0, c1);
operacoes.Sacar(20.0, c1);
