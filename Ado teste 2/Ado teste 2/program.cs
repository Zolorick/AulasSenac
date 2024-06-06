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

//string caminho = "C:\\Users\\Maria\\source\\GitHub\\AulasSenac\\Ado teste 2\\Ado teste 2";

file_paht1 = @$"C:\Users\Maria\source\GitHub\AulasSenac\Ado teste 2\Ado teste 2\Historico de jogadas da ultima partida.txt";
file_paht2 = @$"C:\Users\Maria\source\GitHub\AulasSenac\Ado teste 2\Ado teste 2\ Historico geral de jogo.txt";


do
{
   
    MenuOpcao = menu.Menu();
   
    switch (MenuOpcao)
    {
        case 1:

            
            // despoluindo contagem de pontos, garantindo que eu nao as aumente com os dados do novo jogo
            Limpeza.LimparNum(ref PontosJogador);
            Limpeza.LimparNum(ref PontosBot);

            files.CriarOuSubstituir(file_paht1, $"Partida {TotalPartidas + 1}");
            files.AddText(file_paht1, "");
            nome = menu.Name();
            do
            {
                JogadaJogador = menu.Jogo(nome, PontosJogador, PontosBot);
                JogadaBot = menu.JogoBot();

               ConvertidaBot = menu.ConversaoJogada(JogadaBot);
               ConvertidaJogador= menu.ConversaoJogada(JogadaJogador);

                Console.WriteLine();
                Console.WriteLine($"A máquina escolhe {ConvertidaBot} ");
                Console.WriteLine();
                
                Resultado = menu.ResultadoRodada(JogadaJogador,JogadaBot, nome);

                string exibir = $"{nome} usou {ConvertidaJogador}  e  máquina usou {ConvertidaBot}, portanto {Resultado}";
                Console.WriteLine(exibir);
                Console.WriteLine();
                Console.WriteLine();

                files.AddText(file_paht1,exibir);

                if (Resultado == $"vitória {nome}") 
                { 
                    PontosJogador++; 
                }
                else if (Resultado == "vitória máquina")
                { 
                    PontosBot++; 
                }
                else if (Resultado == "empate")
                { Console.WriteLine("Ninguém ganha pontos nessa rodada"); }

                Limpeza.LimparString(ref ConvertidaBot);
                Limpeza.LimparString(ref ConvertidaJogador);
                Limpeza.LimparNum(ref JogadaJogador);
                Limpeza.LimparNum(ref JogadaBot);

               

            } while (PontosBot < 3 && PontosJogador < 3);

            string parabens;
            if (PontosJogador == 3)
            {
                TotalVitorias++;
                parabens = $"Vitória {nome}, parabéns! Você chegou a três pontos.";
            }
            else
            {
                parabens = $"Derrota {nome}, sinto muito. A máquina chegou a três pontos";
            }

            files.AddText(file_paht1, parabens);
            Console.WriteLine(parabens);
            TotalPartidas++;

            

        break;

        case 2:
            files.Exibir2(file_paht1, TotalVitorias, TotalPartidas);
        break;

        case 3:

            menu.QuerSalvar();

            string resposta = Console.ReadLine().ToLower();
            
            if (resposta == "s" || resposta == "sim" || resposta == "y" || resposta == "yep" || resposta == "yes") 
            {
                files.CriarOuSubstituir(file_paht2,$"De {TotalPartidas} você venceu {TotalVitorias} vezes");
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
