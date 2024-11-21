using Ex_Claudio_2_Ex_4;

Biblioteca biblioteca = new Biblioteca();
Aluno aluno = new Aluno();
int opcao;

Console.WriteLine($"bem vindo a biblioteca aluno matricula {aluno.Matricula}");
Console.WriteLine("Siga ao balcao para atendimento");
Console.WriteLine("* no balcao");
Console.WriteLine("* voce é o funcionario atendendo");



do 
{
    opcao = 0;

    Console.WriteLine("Selecione a opção desejada");
    Console.WriteLine("");
    Console.WriteLine("1 - Adicionar livro ao acervo");
    Console.WriteLine("2 - Emprestar livro");
    Console.WriteLine("3 - Checar status de emprestimo");
    Console.WriteLine("4 - Devolver livro");
    Console.WriteLine("5 - Sair");

    opcao = int.Parse(Console.ReadLine());

    switch (opcao) 
    {
        case 1:
            biblioteca.CriarLivro();
            Console.WriteLine("");
            break;

        case 2:
            biblioteca.EmprestarLivro(aluno);
            Console.WriteLine("");
            break;

        case 3:
            biblioteca.StatusEmprestimo();
            Console.WriteLine("");
            break;

        case 4:
            biblioteca.DevolverLivro();
            Console.WriteLine("");
            break;

        default:
            break;


    }

} while (opcao != 5);
