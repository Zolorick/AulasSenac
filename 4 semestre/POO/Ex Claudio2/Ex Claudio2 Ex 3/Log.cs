using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Claudio2_Ex_3
{
    public class Log
    {
        public static int codTransacao;
        List<string>?  HistoricoTransacao;
        public DateTime DataHora = DateTime.Now;

        public int CodTransacao
        { get; private set; }


        public Log() 
        {
            HistoricoTransacao = new List<string?>();
        }

        // mao precisa fazer referencias posteriores a transacçao

        public void InfoSaque(double valor, Funcionario fun) 
        {

            string logS = $" Transação n° {codTransacao}: O valor de R$ {valor} foi sacado {DataHora} pelo funcionário {fun.Nome}, código {fun.NumFum}";
            Console.WriteLine(logS);
            ColocarNaLista(logS);
            codTransacao++;
        }
        public void InfoDeposito(double valor, Funcionario fun)
        {
            string logD = $" Transação n° {codTransacao}: O valor de R$ {valor} foi depositado {DataHora} pelo funcionário {fun.Nome}, código {fun.NumFum}";
            Console.WriteLine(logD);
            ColocarNaLista(logD);
            codTransacao++;
        }

        private void ColocarNaLista(string log) 
        {
            HistoricoTransacao.Add(log);
        }
                                                                              
    }
}
