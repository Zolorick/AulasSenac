using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado_teste_2
{
    internal class File_Manager
    {
        // "filePath" = O caminho completo do arquivo a ser criado ou usado.  
        //try-catch = trata exeções sem quebrar tudo
     

        // Adiciona uma linha de texto ao arquivo especificado.
        //"text" = O texto a ser adicionado ao arquivo.
        public void AddText(string filePath, string text)
            {
                try
                {
                    File.AppendAllText(filePath, text);
                }
                catch (Exception)
                {
                    Console.WriteLine("Erro ao adicionar texto ao arquivo");
                }
            }

        // Lê o conteúdo de um arquivo de texto.
        public void Ler(string filePath)
            {
                try
                {
                    // Lê o conteúdo do arquivo
                    string content = File.ReadAllText(filePath);
         
                }
                catch (Exception)
                {
                    Console.WriteLine("Erro ao ler o arquivo");
                    
                }
            }

        //substitui o texto em um arquivo
        public void CriarOuSubstituir(string filePath, string newText)
        {
            try
            {

                File.WriteAllText(filePath, newText);

            }
            catch (Exception)
            {
                Console.WriteLine($"Erro ao criar ou substituir o arquivo");
            }
        }

        public void Exibir2(string file_path2, string file_paht1) 
        {
            Console.WriteLine();
            Console.WriteLine("Exibindo o histórico da última partida");
            Console.WriteLine();

            Ler(file_path2);
            Ler(file_paht1);

        }
    }
}
