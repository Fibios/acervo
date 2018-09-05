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

        //public void adicionarExemplar (Exemplar exemplar) { }
        public int qtdeExemplares() { return 1; }
        public int qtdeDisponiveis() { return 1; }
        public int qtdeEmprestimos() { return 1; }

        public double percDisponibilidade() { return 1; }

    }
}
