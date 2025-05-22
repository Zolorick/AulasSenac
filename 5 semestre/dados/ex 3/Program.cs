using senac.jogosdigitais.estruturaDeDados.questao2;
using System.Diagnostics;

Queue fila = new Queue();

fila.Enqueue(1);
Console.WriteLine(fila.front.Data);
Console.WriteLine(fila.rear.Data);
fila.Enqueue(2);
fila.Enqueue(3);

Console.WriteLine(fila.front.Data);
Console.WriteLine(fila.rear.Data);

fila.Dequeue();
Console.WriteLine(fila.front.Data);
Console.WriteLine(fila.rear.Data);
