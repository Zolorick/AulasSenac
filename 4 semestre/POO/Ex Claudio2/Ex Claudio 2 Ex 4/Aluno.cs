using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Claudio_2_Ex_4
{
    public class Aluno
    {
        private static int nAlunos = 1;
        public int Matricula { get; private set; }
        public Aluno() 
        {
            Matricula = nAlunos;
            nAlunos++;
        }
    }
}
