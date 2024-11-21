using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Claudio_2_Ex_4
{
    public class Livro
    {
        public enum genero 
        { 
            Horror,
            Fantasia,
            Ação
        }
        public enum capa 
        { 
            Dura,
            Broxura
        }
        public enum formato 
        {
            Fisico,
            Digital
        }
        public enum idioma
        { 
            Portugues,
            Ingles
        }

        private static int isbn = 1;

        private string nome;
        private string editora;
        private int iSBN;
        private string autores;
        private capa capaLivro;
        private int edicao;
        private int nPag;
        private genero generoLivro;
        private formato formatoLivro;
        private idioma idiomaLivro;


        public bool Emprestimo;

        public string Nome 
        {
            get => nome; private set => nome = value; 
        }
        public string Editora 
        { 
            get => editora; private set => editora = value; 
        }
        public int ISBN 
        { 
            get => iSBN; private set => iSBN = value; 
        }
        public string Autores 
        { 
            get => autores; private set => autores = value;
        }
        public capa CapaLivro 
        { 
            get => capaLivro; private set => capaLivro = value;
        }
        public int Edicao 
        { 
            get => edicao; private set => edicao = value; 
        }
        public int NPag 
        { 
            get => nPag; private set => nPag = value;
        }
        public genero GeneroLivro 
        { 
            get => generoLivro; private set => generoLivro = value;
        }
        public formato FormatoLivro 
        { 
            get => formatoLivro; private set => formatoLivro = value;
        }
        public idioma IdiomaLivro 
        { 
            get => idiomaLivro; private set => idiomaLivro = value;
        }

        public Livro()
        {

            Emprestimo = false;
            iSBN = isbn;
            isbn++;
            int contagemEnum = 0;

            Console.WriteLine("Qual o nome do livro?");
            nome = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Qual a editora do livro?");
            editora = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Qual o(s) autor(es) do livro?");
            autores = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Qual o n° de páginas do livro?");
            nPag = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Qual o n° da edição do livro?");
            edicao = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Qual o tipo de capa do livro?");
            foreach (capa c in Enum.GetValues (typeof(capa)))
            {
                Console.WriteLine(c + "-" + contagemEnum);
                contagemEnum++;
            }
            capaLivro = (capa)int.Parse(Console.ReadLine());
            Console.WriteLine();

            contagemEnum = 0;

            Console.WriteLine("Qual o formato livro?");
            foreach (formato c in Enum.GetValues(typeof(formato)))
            {
                Console.WriteLine(c + "-" + contagemEnum);
                contagemEnum++;
            }
            formatoLivro = (formato)int.Parse(Console.ReadLine());
            Console.WriteLine();

            contagemEnum = 0;

            Console.WriteLine("Qual o genero do livro?");
            foreach (genero c in Enum.GetValues(typeof(genero)))
            {
                Console.WriteLine(c + "-" + contagemEnum);
                contagemEnum++;
            }
            generoLivro = (genero)int.Parse(Console.ReadLine());
            Console.WriteLine();

            contagemEnum = 0;

            Console.WriteLine("Qual o idioma do livro?");
            foreach (idioma c in Enum.GetValues(typeof(idioma)))
            {
                Console.WriteLine(c + "-" + contagemEnum);
                contagemEnum++;
            }
            idiomaLivro = (idioma)int.Parse(Console.ReadLine());

        }

        public Livro(string nome, string editora, int iSBN, string autores, capa capaLivro, int edicao, int nPag, genero generoLivro, formato formatoLivro, idioma idiomaLivro, bool emprestimo)
        {
            Nome = nome;
            Editora = editora;
            ISBN = iSBN;
            Autores = autores;
            CapaLivro = capaLivro;
            Edicao = edicao;
            NPag = nPag;
            GeneroLivro = generoLivro;
            FormatoLivro = formatoLivro;
            IdiomaLivro = idiomaLivro;
            Emprestimo = emprestimo;
            Nome = nome;
            Editora = editora;
            ISBN = iSBN;
            Autores = autores;
            CapaLivro = capaLivro;
            Edicao = edicao;
            NPag = nPag;
            GeneroLivro = generoLivro;
            FormatoLivro = formatoLivro;
            IdiomaLivro = idiomaLivro;
        }
    }

}
