using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projLivrosLista
{
    /*  Saulo Silva Castilhos
        Bruno de Oliveira Silva */
    class Program
    {
        //inicializando variaveis e classes

        static Livros acervo;
        static Livro livro;
        static void Main(string[] args)
        {
            acervo = new Livros();

            int opcao = 10;
            do
            {
                Console.Clear();
                Console.WriteLine("0. Sair");
                Console.WriteLine("1.Adicionar livro");
                Console.WriteLine("2.Pesquisar livro(sintético)");
                Console.WriteLine("3.Pesquisar livro(analítico)");
                Console.WriteLine("4.Adicionar exemplar");
                Console.WriteLine("5.Registrar empréstimo");
                Console.WriteLine("6.Registrar devolução");

                try
                { opcao = int.Parse(Console.ReadLine()); }
                catch { continue; };

                Console.Clear();
                switch (opcao)
                {
                    case 1: adicionarLivro(); break;
                    case 2: pesquisarLivroSintetico(); break;
                    case 3: pesquisarLivroAnalitica(); break;
                    case 4: adicionarExemplar(); break;
                    case 5: registrarEmprestimo(); break;
                    case 6: registrarDevolucao(); break;
                }
            } while (opcao != 0);
        }

        static public void adicionarLivro()
        {
            int isbn;
            string titulo, autor, editora;
            Console.WriteLine("Dados do Livro que deseja adicionar");
            Console.WriteLine("ISBN: ");
            isbn = int.Parse(Console.ReadLine());

            livro = new Livro(isbn);
            if (acervo.pesquisar(livro) == null)
            {
                Console.WriteLine("Título: ");
                titulo = Console.ReadLine();
                Console.WriteLine("Autor: ");
                autor = Console.ReadLine();
                Console.WriteLine("Editora: ");
                editora = Console.ReadLine();
                livro = new Livro(isbn, titulo, autor, editora);
                acervo.adicionar(livro);
                Console.WriteLine("Livro " + titulo + " | Adicionado com sucesso!");
            }
            else
                Console.WriteLine("ISBN já existente no acervo");
            Console.ReadKey();

        }
        static public void pesquisarLivroSintetico()
        {
            int isbn;
            Console.WriteLine("Digite o número do ISBN do Livro que deseja encontrar: ");
            isbn = int.Parse(Console.ReadLine());
            livro = new Livro(isbn);
            livro = acervo.pesquisar(livro);

            if (livro != null)
                Console.WriteLine(livro.dados());
            else Console.WriteLine("Livro não encontrado no acervo (ISBN)");
            Console.ReadKey();
        }
        static public void pesquisarLivroAnalitica()
        {
            int isbn;
            Console.WriteLine("Digite o número do ISBN do Livro que deseja encontrar: ");
            isbn = int.Parse(Console.ReadLine());
            livro = new Livro(isbn);
            livro = acervo.pesquisar(livro);
            if (livro != null)
            {
                Console.WriteLine(livro.dados2());
            }
            else
                Console.WriteLine("Livro não encontrado no acervo (ISBN)");
            Console.ReadKey();
        }
        static public void adicionarExemplar()
        {
            Console.WriteLine("Adicionar Exemplar \n ___________________");
            Console.WriteLine("Digite o ISBN do Livro que deseja: ");
            int isbn = int.Parse(Console.ReadLine());
            livro = new Livro(isbn);

            if (acervo.pesquisar(livro) != null)
            {
                Console.WriteLine("Digite o tombo do Exemplar: ");
                int tombo = int.Parse(Console.ReadLine());
                Exemplar exemplar = new Exemplar(tombo);
                acervo.pesquisar(livro).adicionarExemplar(exemplar);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Livro não encontrado!\n");
            }
            Console.ReadKey();
        }
        static public void registrarEmprestimo()
        {
            int tombo, isbn;
            Console.WriteLine("Empréstimo de Livros \n _________________");
            Console.WriteLine("\nDigite o ISBN do Livro: ");
            isbn = int.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite qual o Tombo do Exemplar? \nTombo: ");
            tombo = int.Parse(Console.ReadLine());

            livro = acervo.pesquisar(new Livro(isbn));
            if (livro != null)
            {
                Exemplar exemplar = new Exemplar(tombo);
                exemplar = livro.pesquisar(exemplar);
                if (exemplar != null)
                {
                    if (exemplar.emprestar())
                        Console.WriteLine("Livro emprestado com sucesso!");
                }
                else Console.WriteLine("Exemplar não encontrado");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Livro não existe no acervo");
            }
            Console.ReadKey();
        }
        static public void registrarDevolucao()
        {
            int tombo, isbn;
            Console.WriteLine("Devolução de Livros \n _________________");
            Console.WriteLine("\nDigite o ISBN do Livro: ");
            isbn = int.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite qual o Tombo do Exemplar? \nTombo: ");
            tombo = int.Parse(Console.ReadLine());

            livro = acervo.pesquisar(new Livro(isbn));
            if (livro != null)
            {
                Exemplar exemplar = new Exemplar(tombo);
                exemplar = livro.pesquisar(exemplar);

                if (exemplar.devolver())
                {
                    Console.WriteLine("Livro devolvido com sucesso!");
                }
                else Console.WriteLine("Exemplar não encontrado");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Livro não existe no acervo");
            }
            Console.ReadKey();
        }
    }
}
