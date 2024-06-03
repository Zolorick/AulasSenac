using System.Collections.Generic;
using Ado_teste_2;
using System.IO;
using System.Runtime.CompilerServices;


/*Exemplo de como usar os metodos de arquivo
  
fileManager.CreateTextFile(@"C:\Users\Maria\example.txt");

// Adicionar texto ao arquivo
fileManager.AppendTextToFile(@"C:Este Computador\example.txt", "Linha 1");
fileManager.AppendTextToFile(@"C:\Users\Maria\example.txt", "Linha 2");
fileManager.AppendTextToFile(@"C:\Users\Maria\example.txt", "Linha 3");

// Ler o conteúdo do arquivo
string fileContent = fileManager.ReadTextFile(@"C:\Users\Maria\example.txt");
Console.WriteLine(fileContent);
*/

//1-pedra; 2-papel, 3-tesoura


File_Manager files = new File_Manager();
Menus menu = new Menus();

int MenuOpcao, JogadaJogador, JogadaBot; 
int PontosJogador = 0;
int PontosBot = 0;
int TotalPartidas = 0;
int TotalVitorias = 0;
string nome, texto,file_paht1,file_paht2, file_path3;

Queue<string> JoJoHi = new Queue<string>();
Queue<string> JoBot = new Queue<string>();

file_paht1 = @$"C:\Users\Maria\OneDrive\Área de Trabalho\Historico de jogadas.txt";
file_paht2 = @$"C:\Users\Maria\OneDrive\Área de Trabalho\total de vitorias.txt";
file_path3 = @$"C:\Users\Maria\OneDrive\Área de Trabalho\nome.txt";

// por causa da "quer salvar" da tres eu nao posso deixar dentro da um os filepaths

do
{
    MenuOpcao = menu.Menu();

    switch (MenuOpcao)
    {
        case 1:
            nome = menu.Name();

            // despoluindo as queue e contagem de pontos, garantindo que eu nao as aumente com os dados do novo jogo
            Limpeza.LimparQueueString(ref JoBot); 
            Limpeza.LimparQueueString(ref JoJoHi);
            Limpeza.LimparNum(ref PontosJogador);
            Limpeza.LimparNum(ref PontosBot);

            do
            {
                JogadaJogador = menu.Jogo(nome, PontosJogador, PontosBot);
                JogadaBot = menu.JogoBot();

                //fazer um metodo pra checagem de vitoria da rodada
            } while (PontosBot != 3 || PontosJogador != 3);
             
            //e o que mais precisar fazer em caso de vitoria... uma linha de texto dizendo vitoria [nome]?
            if (PontosJogador == 3) 
            { TotalVitorias++; }


            // estutura pra passar pelas informações relevantes na partida e salvar de uma vez e de forma ordanizada
            //esta incompleto e precisa ser feito
            while (JoJoHi.Count > 0 && JoBot.Count > 0) 
            {

                texto = $"";
                Console.WriteLine(texto);
                //uma linha pra, vitoria da rodada
                //linha vazia pra ficar bonito
            }


            TotalPartidas ++;
        break;

        case 2:
            //eu posso fazer um array de tres lugares : nome, o arquivo do historico e o de total de vitorias? e exibir
            files.ReadTextFile(file_paht1);
        break;

        case 3:
        break;
    }

} while (MenuOpcao != 3 );


//eu deveria fazer uma pilha com os arquivos pra poder puxar o certo na opção 3 ou isso é meio automatico?
//fazendo com queue eu preciso fazer manualmente

//caso aperte pra sair
