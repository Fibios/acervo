using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projLivrosLista
{
    public class Exemplar
    {
        // Atributos
        private int tombo;
        private List<Emprestimo> emprestimos;

        /* Propriedades
        public int Tompo { get => tompo; set => tompo = value; }
        public List<Emprestimo> Emprestimos { get => emprestimos; set => emprestimos = value; }
        */

        // Construtores

        public Exemplar() {
        }

        public Exemplar(int tombo) {
            this.tombo = tombo;
        }

        // Métodos

        

        public bool emprestar() {
            
            Emprestimo emprestimo = new Emprestimo();
            emprestimos.Add(emprestimo);
            return true;
        }
        public bool devolver()
        {
            
            return true;
        }
        public bool disponivel()
        {

            return true;
        }
        public int qtdeEmprestimos() {
            return 0;
        }


    }
}
