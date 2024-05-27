using System.IO;
using System.Reflection;

namespace Arquivos
{
    class Arq
    {
        public void CriandoArq(string nome_arq)
        {
           
            string texto = @$"C:\Users\Maria\{nome_arq}.txt";

            using (StreamWriter sw = new StreamWriter(texto)) 
            {
                texto = "ola teste este";
                sw.WriteLine(texto);
            }
        }

        public void InfoJogo() 
        {
        
            

        }
    }
}
