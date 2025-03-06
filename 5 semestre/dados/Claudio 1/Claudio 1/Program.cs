using Claudio_1;

Menu menu = new Menu();
int jogadorAtual = 1;
Jogada jogadaAtual = null;

int escolha;
do
{
    
    escolha = menu.MostarOpcoes();
    if (escolha == 1)
    {
        jogadaAtual = new Jogada();
    }
    else if (escolha == 2)
    {
        menu.EncerrarTurno();
    }
    else if (escolha == 3)
    {
        break;
    }
    else
    {
        Console.WriteLine("Opção inválida");
    }


} while (escolha != 3);
menu.encerrarJogo();

