using MasterKitchen2;
using System.Runtime.InteropServices;

Prato p1 = new Prato();
Prato p2 = new Prato();
Prato p3 = new Prato();

Pilha pilha_Limpo = new Pilha();
Pilha pilha_Sujo = new Pilha();

pilha_Limpo.Adicionar(p1);
pilha_Limpo.Adicionar(p2);
pilha_Limpo.Adicionar(p3);

Console.WriteLine(pilha_Limpo.Topo.Estado); ;

Console.WriteLine(pilha_Limpo.Tamanho);

pilha_Limpo.Zerar(pilha_Sujo);

Console.WriteLine(pilha_Sujo.Topo.Estado);

Console.WriteLine(pilha_Limpo.Tamanho);
Console.WriteLine(pilha_Sujo.Tamanho);

int t = pilha_Sujo.Tamanho;
Prato[] pratos = new Prato[t];
int i = 0;

while (t > 0)
{
    Console.WriteLine(pilha_Sujo.Topo.Estado); ;
    pratos[i] = pilha_Sujo.Remover();
    Console.WriteLine(pratos[i].Estado);
    i++;
    if (pilha_Sujo.Topo == null)
    {
       break;
    }
}
foreach (Prato p in pratos)
{
    pilha_Limpo.Adicionar(p);
}   