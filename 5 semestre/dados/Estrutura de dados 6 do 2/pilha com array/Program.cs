using pilha_com_array;

funcoes fun = new funcoes();

Console.WriteLine(funcoes.topo);

int[] pilha = new int[10];

fun.colocar(pilha, 10);

fun.colocar(pilha, 20);

fun.olhar(pilha);


Console.WriteLine(funcoes.topo);

fun.remove(pilha);
fun.olhar(pilha);