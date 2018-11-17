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
        List<Exemplar> exemplares;
        public List<Exemplar> listaExemplares()
        {
            return exemplares;
        }

        //construtores
        public Livro(int isbn, string titulo, string autor, string editora)
        {
            this.isbn = isbn;
            this.titulo = titulo;
            this.autor = autor;
            this.editora = editora;
            this.exemplares = new List<Exemplar>();
        }
        public Livro() : this(0, "", "", "")
        {
        }
        public Livro(int isbn):this(isbn,"","","")
        {
        }



        public string dados()
        {
            string dados = ("ISBN: " + isbn + " | Titulo: " + titulo + " | Autor: " + autor + " | Editora: " + editora);
            return dados +" \nTotal de Exemplares: "+ qtdeExemplares() +" | Quantidade disponível: "+ qtdeDisponiveis()+"\nQuantidade de empréstimos "+ qtdeEmprestimos()+" | Percentual de disponibilidade: " + percDisponibilidade()+"%";
        }
        public string dados2()
        {
            string str = dados()+"\n";
            foreach (Exemplar exemplar in exemplares)
            {
                str += "\n Exemplar: "+ exemplar.getTombo();
                str += "\n Emprestado: {0} Vezes " + exemplar.qtdeEmprestimos()+"\n";
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
                return 0;
            }
        }
        public Exemplar pesquisar(Exemplar e)
        {
            Exemplar exemplarAchado = null;
            foreach (Exemplar exemplar in this.exemplares)
            {
                if (exemplar.Equals(e))
                {
                    exemplarAchado = exemplar;
                }
            }
            return exemplarAchado;
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
