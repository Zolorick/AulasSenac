int[] num = new int[10] {1,2,3,4,5,6,7,8,9,10};
int soma = 0;

foreach (int i in num)
{
    soma += i;
}

foreach (int i in num)
{
    Console.Write($"{i} ");
}

Console.WriteLine();
Console.WriteLine($" A soma dos numeros é:{soma}");
