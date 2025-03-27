using System.Diagnostics;
using Fatorial;
matematica f = new matematica();
Palindromos p = new Palindromos();

int resultado;

//resultado = f.FatorialNaoRecursivo(5);
//resultado = f.FatorialRecursivo(5);
//resultado = f.FatorialComRepetição(6, 2);
//resultado = f.Fibonacchi(6);
//List<int> fib = f.GerarSequenciaFibonacci(6);

//Console.WriteLine($"O resultado é: {resultado}");
/*
for (int i = 0; i < fib.Count; i++)
{
    Console.WriteLine($"termo {i+1}: {fib[i]}");
}
*/

Console.WriteLine(p.VerificarPalindromoSemRecursividade("a"));


