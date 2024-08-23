using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_1_scola
{
    internal class aluno : pessoa
    {
        private int ano_escolar;
        private string periodo;
        private int turma;

        public bool assinar_presenca(bool presenca) 
        {
            
            Console.WriteLine("Voce estava em aula hoje?");
            Console.WriteLine("1 - sim");
            Console.WriteLine("2 - nao");
            string resposta = Console.ReadLine();

            if (resposta == "1") 
            { 
                presenca = true; 
            }
            else
            {
                 presenca = false;
            }


            return presenca;
        }
    }
}
