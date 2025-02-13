int[] num = new int[20] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 41, 15, 16, 17, 18, 19, 20 };
int pares = 0;

foreach (int i in num)
{
    if (i % 2 == 0)
    {
        pares++;
    }
}

foreach (int i in num)
{
    Console.Write($"{i} ");
}

Console.WriteLine();
Console.WriteLine($" existem {pares} numeros pares nesse array");