using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Claudio2_Ex_3
{
    public class Funcionario
    {
        private static int numFuncionario = 1;
        private string nome;

        public int NumFum
        { get; private set ; }
        public string Nome 
        { get => nome; private set => nome = value; }

        public Funcionario()
        {
            NumFum = numFuncionario;
            numFuncionario++;

            Console.Write("Insira o nome do funcionario:");
            Nome = Console.ReadLine();
        }

    }
}
