using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex_Claudio_2_Ex_4;

namespace Ex_Claudio_2_Ex_4
{
    public class Biblioteca
    {
        Dictionary<int, Emprestimo> emprestimos = new Dictionary<int, Emprestimo>();
        Dictionary<int, Livro> livros = new Dictionary<int, Livro>();

        public void StatusEmprestimo()
        {
            foreach (var atual in emprestimos)
            {
                if (atual.Value.Liv.Emprestimo)
                { Console.WriteLine($"Codigo: {atual.Key}, Nome: {atual.Value.Liv.Nome}"); }
            }
            Console.WriteLine();
            Console.WriteLine("Digite o código do emprestimo a ser checado");

            int opcao = int.Parse(Console.ReadLine());
            Emprestimo emp = emprestimos[opcao];
            Emprestimo.Status(emp);

        }

        public void EmprestarLivro(Aluno alun)
        {
            Console.WriteLine("Livros disponiveis:");
            foreach (var atual in livros)
            {
                if (!atual.Value.Emprestimo) 
                { Console.WriteLine($"Codigo: {atual.Key}, Nome: {atual.Value.Nome}"); }
                    
            }
            Console.WriteLine();
            Console.WriteLine("Digite o código do livro a ser pego emprestado");
            int opcao = int.Parse(Console.ReadLine());
            Livro livro = livros[opcao];
            Emprestimo emp = new Emprestimo (livro, alun);
            emprestimos.Add(emp.CodigoEmp, emp);

        }

        public void CriarLivro() 
        {
            Livro liv = new Livro();
            livros.Add(liv.ISBN, liv);
        }

        public void DevolverLivro() 
        {
            foreach (var atual in emprestimos)
            {
                if (atual.Value.Liv.Emprestimo) 
                { 
                    Console.WriteLine($"Codigo: {atual.Key}, Nome: {atual.Value.Liv.Nome}");
                }
                
            }
            Console.WriteLine();
            Console.WriteLine("Digite o código do emprestimo a ser fechado");

            int opcao = int.Parse(Console.ReadLine());
            Emprestimo emp = emprestimos[opcao];
            emp.Devolver();
        }

       

    }
}
