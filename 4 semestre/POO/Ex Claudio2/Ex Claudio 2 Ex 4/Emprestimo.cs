using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Claudio_2_Ex_4
{
    public class Emprestimo
    {
        private Livro liv;
        private Aluno alun;
        private DateTime dataEmprestimo = DateTime.Now;
        private DateTime dataDevolução;
      
        public Livro Liv 
        { get => liv; private set => liv = value; }
        public Aluno Alun 
        { get => alun; private set => alun = value; }

        public Emprestimo(Livro liv, Aluno alun)
        {
            this.liv = liv;
            this.alun = alun;
            this.liv.Emprestimo = true;
            dataDevolução = dataEmprestimo.AddDays(7);
            Console.WriteLine($"Emprestando");
        }
        public void Devolver() 
        { }

        public void StatusEmprestimo() 
        { }
    }
}
