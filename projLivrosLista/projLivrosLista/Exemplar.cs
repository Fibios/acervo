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
        private List<Emprestimo> emprestimos = new List<Emprestimo>();
        Emprestimo emprestimo;
        public Exemplar(int tombo)
        {
            this.tombo = tombo;
        }
     
        //atributos
        public int getTombo()
        {
            return this.tombo;
        }
        // Métodos

        public bool emprestar()
        {
            if (disponivel())
            {
                emprestimo = new Emprestimo();
                emprestimos.Add(emprestimo);
                return true;
            }
            else return false;
        }
        public bool devolver()
        {
            if (disponivel())
            {
                emprestimos[emprestimos.Count() - 1].setDtDevolucao(DateTime.Now);
                return true;
            }
            else return false;
        }
        public bool disponivel()
        {
            if (emprestimos[emprestimos.Count() - 1].getdtDevolucao().Equals(DateTime.MinValue))
            {
                return false;
            }
            else return true;
        }
        public int qtdeEmprestimos()
        {
            return emprestimos.Count();
        }
        #region Sobreescritas
        public override bool Equals(object obj)
        {
            Exemplar e = (Exemplar)obj;
            return this.tombo.Equals(e.tombo);
        }
        #endregion

    }
}
