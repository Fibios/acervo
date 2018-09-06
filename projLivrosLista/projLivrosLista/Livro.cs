using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projLivrosLista
{
    class Livro
    {
        private int isbn;
        private string titulo, autor, editora;
        List <Exemplar> exemplares;
        //construtores
        Livro (int isbn, string titulo, string autor, string editora )
        {
            this.isbn = isbn;
            this.titulo = titulo;
            this.autor = autor;
            this.editora = editora;
        }
        Livro():this(0, "", "", "") { }
       

        public void adicionarExemplar (Exemplar exemplar)
        {
            exemplares.Add(exemplar);
        }
        public int qtdeExemplares()
        {
            return exemplares.Count();
        }
        public int qtdeDisponiveis()
        {
            int contar = 0 ;
            foreach (Exemplar exemplar in exemplares)
            {
                if (exemplar.disponivel())
                {
                    contar++;
                }
            }
            return contar;
        }
        public int qtdeEmprestimos()
        {
            int total = 0;
            foreach (Exemplar exemplar in exemplares)
            {
                total += exemplar.qtdeEmprestimos();
            }
            return total;
        }

        public double percDisponibilidade()
        {
             return (qtdeDisponiveis() / exemplares.Count())*100;
        }

    }
}
