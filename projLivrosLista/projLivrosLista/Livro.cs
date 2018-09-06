using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projLivrosLista
{
    public class Livro
    {
        private int isbn;
        private string titulo, autor, editora;
        List<Exemplar> exemplares = new List<Exemplar>();
        //construtores
        public Livro (int isbn, string titulo, string autor, string editora )
        {
            this.isbn = isbn;
            this.titulo = titulo;
            this.autor = autor;
            this.editora = editora;
        }
        public Livro(isbn)
        {
            this.isbn = isbn;
        }
        public Livro() { }

        public string dados()
        {
            string dados = ("ISBN: " + isbn + " Titulo: " + titulo + " Autor: " + autor + "Editora: " + editora);
            return dados + qtdeExemplares() + qtdeDisponiveis()+ qtdeEmprestimos() + percDisponibilidade();
        }
        public string dados2()
        {
            string str = dados()+"\n";
            foreach (Exemplar exemplar in exemplares)
            {
                str += "\n"+ exemplar.getTombo();
                str += "\n" + exemplar.qtdeEmprestimos()+"\n";
            }
            return str;
        }
       

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
            try
            {
                return qtdeDisponiveis() / exemplares.Count() * 100;
            }

            catch
            {
                return -1;
            }
        }
        #region Sobreescritas
        public override bool Equals(object obj)
        {
            Livro c = (Livro)obj;
            return this.isbn.Equals(c.isbn);
        }
        #endregion
    }
}
