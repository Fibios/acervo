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
        Emprestimo emprestimo;
        public Exemplar(int tombo)
        {
            this.tombo = tombo;
            emprestimos = new List<Emprestimo>();
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
        /// <summary>
        /// Função que verifica a disponibilidade do exemplar
        /// </summary>
        /// <returns>Retorna se ta disponível ou não</returns>
        public bool disponivel()
        {
            if (emprestimos.Count() == 0)
            {
                return true;
            }
            else if (emprestimos[emprestimos.Count() - 1].getdtDevolucao().Equals(DateTime.MinValue))
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
