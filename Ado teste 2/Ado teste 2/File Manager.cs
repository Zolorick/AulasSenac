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
        public void CreateTextFile(string filePath)
            {
                try
                {
                    File.Create(filePath).Close();
                }
                catch (Exception)
                {
                    Console.WriteLine("Erro ao criar o arquivo");
                }
           
            }

        // Adiciona uma linha de texto ao arquivo especificado.
        //"text" = O texto a ser adicionado ao arquivo.
        public void AppendTextToFile(string filePath, string text)
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
        public void ReadTextFile(string filePath)
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
        public void ReplaceTextFile(string filePath, string newText)
        {
            try
            {
                
                string content = File.ReadAllText(filePath);
                File.WriteAllText(filePath, newText);

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao substituir o conteúdo do arquivo: {ex.Message}");
            }
        }


        public void SalvarJogo(string filePath, string texto, string nome) 
        {

            CreateTextFile(filePath);
            texto = $"Jogador: {nome}";
            AppendTextToFile(filePath, texto);

            //fazer um foreach que passe por duas pilhas ou filar de forma alternada que contem as jogadas do jogador e do bot; fazer com que diga "vitoria....
            //posso fazer com que a cada ponto se crie uma nova pilha e uma nova tabelinha pra manter bonito"

        }

    }
}
