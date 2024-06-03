using ADO;
using System.IO;
using System.Reflection;

namespace ADO
{
    public class Arq 
    {
        public string nome_arq = "1";
        public string texto = "Historico de jogadas";
        public void CriandoArq()
        {
           
            string texto = @$"C:\Users\Maria\source\Repos\Zolorick\AulasSenac\ADO\ADO\bin\Debug\net8.0\C:\Users\Maria\Jogo.txt";

            using (StreamWriter arq = new StreamWriter(Jogo.txt)) 
            {
                arq.WriteLine(texto);
            }

        }

        public void AddInfo(string texto)
        {
            using (StreamWriter arq = File.AppendText(texto)) 
            {
                arq.WriteLine(texto);
            }
        }

        public void LerArq(string texto) 
        {
            using (StreamReader lendo = new StreamReader(texto))
            {
                string dados;
                while ((dados = lendo.ReadLine()) != null) 
                { Console.WriteLine(dados); }
            }
        }
    }

    //criar uma classe com as informações pra salvar?

    class InfoJogo
    {

        // nome jogadpr
        //as jogadas dele
        //intercala co jogadas bot

    }
}
