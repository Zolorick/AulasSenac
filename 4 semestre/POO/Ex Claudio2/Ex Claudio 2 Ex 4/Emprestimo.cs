using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex_Claudio_2_Ex_4;

namespace Ex_Claudio_2_Ex_4
{
    public class Emprestimo
    {
        private Livro liv;
        private Aluno alun;
        private DateTime dataEmprestimo = DateTime.Now;
        private DateTime dataPrevista;
        private DateTime dataDevolvido;
        private static int nEmp =1;
        private int codigoEmp;

        public Livro Liv 
        { get => liv; private set => liv = value; }
        public Aluno Alun 
        { get => alun; private set => alun = value; }
        public int CodigoEmp { get => codigoEmp; private set => codigoEmp = value; }

        public Emprestimo(Livro liv, Aluno alun)
        {
            codigoEmp = nEmp;
            nEmp++;
            this.liv = liv;
            this.alun = alun;
            this.liv.Emprestimo = true;
            dataPrevista = dataEmprestimo.AddDays(7);
            Console.WriteLine($"O prazo de devolução é de sete dias");
            Console.WriteLine();
        }
        public void Devolver() 
        {
            this.liv.Emprestimo = false;
            dataDevolvido = DateTime.Now;
            Console.WriteLine($"{this.liv.Nome} devolvido com sucesso");

        }
        public static void Status(Emprestimo emp) 
        {
            if (emp.Liv.Emprestimo)
            {
                if (emp.dataPrevista < DateTime.Now)
                {
                    Console.WriteLine($"Atraso de {DateTime.Now - emp.dataPrevista}");
                }

                else
                {
                    Console.WriteLine($"Emprestimo dentro do prazo: {DateTime.Now - emp.dataPrevista} ");
                }
            }
            else { Console.WriteLine("Livro devolvido"); }

        }
    }
}
