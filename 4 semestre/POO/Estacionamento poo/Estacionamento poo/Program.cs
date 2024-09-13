using Estacionamento_poo;

UI ui = new UI();
Estacionamento estacionamento = new Estacionamento();

int NumeroCarro = 0;
string opcao;



do 
{
    opcao = "";
    ui.Opcoes();
    opcao = Console.ReadLine();

    //aqui eu faço a escolha
    switch (opcao)
    {

        case "1":
            NumeroCarro++;
            estacionamento.NovoCarro(NumeroCarro);
            break;

        case "2":
            break;

        case "3":
            break;

        default:
            break;

    }
} while (opcao != "3");






