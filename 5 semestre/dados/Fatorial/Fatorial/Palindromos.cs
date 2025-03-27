using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatorial
{
    public class Palindromos
    {
        public bool VerificarPalindromoSemRecursividade(string palavra)
        {
            bool palindromo;
            char[] AC = palavra.ToCharArray();
            char[] BC = palavra.ToCharArray();
            Array.Reverse(BC);

            if (AC.SequenceEqual(BC))
            {
                palindromo = true;
            }
            else
            {
                palindromo = false;
            }

            return palindromo; 
        }

        public bool VerificarPalindromoComRecursividade(string palavra)
        {
            if (palavra.Length <= 1)
            {
                return true;
            }

            if (palavra[0] != palavra[palavra.Length - 1])
            {
                return false;
            }

            return VerificarPalindromoComRecursividade(palavra.Substring(1, palavra.Length - 2));
        }


    }
}
