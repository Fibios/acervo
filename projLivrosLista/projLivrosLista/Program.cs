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
        static void Main(string[] args)
        {
            //inicializando variaveis e classes
            Exemplar exemplar = new Exemplar();
            Livros biblioteca = new Livros();
            Emprestimo emprestimo = new Emprestimo();
            Livro livro = new Livro();
            int opcao;
            do
            {
                Console.WriteLine("0. Sair");
                Console.WriteLine("1.Adicionar livro");
                Console.WriteLine("2.Pesquisar livro(sintético)");
                Console.WriteLine("3.Pesquisar livro(analítico)");
                Console.WriteLine("4.Adicionar exemplar");
                Console.WriteLine("5.Registrar empréstimo");
                Console.WriteLine("6.Registrar devolução");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1: biblioteca.adicionar(livro); break;
                    case 2: biblioteca.pesquisar(); break;
                    case 3: biblioteca.pesquisar(); break;
                    case 4: biblioteca.adicionar(); break;
                    case 5: exemplar.emprestar(); break;
                    case 6: exemplar.devolver(); break;
                }

              
            } while (opcao != 0);
            Console.ReadKey();


        }
    }
}
