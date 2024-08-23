using System.ComponentModel.Design;
using System.IO;
using ADO;

Classe1 metodos = new Classe1();
as_opçoes_menu acoes = new as_opçoes_menu();
Arq arq = new Arq();


int MenuOpcao, JogadaJogador, JogadaBot;

MenuOpcao = metodos.Menu();

switch (MenuOpcao) 
{ 
    case 1:
        acoes.IniciarJogo();
    break;

    case 2:
        acoes.ExibirResumo();
    break;

    case 3:
        acoes.Sair();
    break;
}

JogadaJogador = 1;
JogadaBot = 2;

switch (JogadaJogador, JogadaBot) 
{
    case (1,1):

    break;
}
