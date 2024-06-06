using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado_teste_2
{
    internal class Limpeza
    {
        public static void LimparNum(ref int _var)
        {
            _var = 0;
        }
        public static void LimparString(ref string _var)
        {
            _var = "";
        }
        
        //depois da ADO fazer comandos de limpeza de tudo
        public static void LimparQueueString(ref Queue<string> _var) 
        {
            for (int i = 0; i < _var.Count; i++)
            {
                _var.Dequeue();
            }
        }

        public static void LimparQueueInt(ref Queue<int> _var)
        {
            for (int i = 0; i < _var.Count; i++)
            {
                _var.Dequeue();
            }
        }


    }
}
