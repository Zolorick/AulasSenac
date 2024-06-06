using System.Collections.Generic;
using Ado_teste_2;
using System.IO;
using System.Runtime.CompilerServices;

//1-pedra; 2-papel, 3-tesoura

File_Manager files = new File_Manager();
Menus menu = new Menus();

int MenuOpcao, JogadaJogador, JogadaBot; 
int PontosJogador = 0;
int PontosBot = 0;
int TotalPartidas = 0;
int TotalVitorias = 0;
string nome,file_paht1,file_paht2,ConvertidaJogador, ConvertidaBot,Resultado;


file_paht1 = @$"C:\Users\Maria\OneDrive\Área de Trabalho\Historico de jogadas da ultima partida.txt";
file_paht2 = @$"C:\Users\Maria\OneDrive\Área de Trabalho\Historico geral de jogo.txt";


do
{
    MenuOpcao = menu.Menu();
    nome = menu.Name();

    switch (MenuOpcao)
    {
        case 1:

            // despoluindo contagem de pontos, garantindo que eu nao as aumente com os dados do novo jogo
            Limpeza.LimparNum(ref PontosJogador);
            Limpeza.LimparNum(ref PontosBot);

            files.CriarOuSubstituir(file_paht1, $"Partida {TotalPartidas + 1}");
            files.AddText(file_paht1, "");

            do
            {
                JogadaJogador = menu.Jogo(nome, PontosJogador, PontosBot);
                JogadaBot = menu.JogoBot();

               ConvertidaBot = menu.ConversaoJogada(JogadaBot);
               ConvertidaJogador= menu.ConversaoJogada(JogadaBot);

                //ainda nao terminei esse metodo
                Resultado = menu.ResultadoRodada(JogadaJogador,JogadaBot,ConvertidaJogador, ConvertidaBot, nome);

                files.AddText(file_paht1,$" {nome} usou {ConvertidaJogador}  e  máquina usou {ConvertidaBot}, portanto {Resultado}");

                if (Resultado == $"vitória {nome}") 
                { PontosJogador++; }
                else { PontosBot++; }

            } while (PontosBot != 3 || PontosJogador != 3);

            if (PontosJogador == 3)  
            {
                TotalVitorias++;
                files.AddText(file_paht1,$" Vitória {nome}, parabéns!");
            }
            else 
            {
                files.AddText(file_paht1, $" Derrota {nome}, sinto muito");
            }

            TotalPartidas++;

            

        break;

        case 2:
            files.Exibir2( file_paht2, file_paht1);
        break;

        case 3:

            menu.QuerSalvar();

            string resposta = Console.ReadLine().ToLower();
            
            if (resposta == "s" || resposta == "sim" || resposta == "y" || resposta == "yep" || resposta == "yes") 
            {
                files.CriarOuSubstituir(file_paht2, $"Jogador: {nome}");
                files.AddText(file_paht2,$" De {TotalPartidas} você venceu {TotalVitorias} vezes");
                files.AddText(file_paht2,"");
                files.AddText(file_paht2,"A seguir está o histórico da última partida");
                // ja estara salvo o historico, eu nao preciso colocar de novo
            }

            Console.WriteLine();
            Console.WriteLine("Obrigada por jogar, estamos prontos para encerrar");
            Console.WriteLine("Fechando o programa");

        break;
    }

} while (MenuOpcao != 3 );
