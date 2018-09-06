using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projLivrosLista
{
    public class Exemplar : Livro
    {
        // Atributos
        private int tombo = 0;
        private List<Emprestimo> emprestimos;
        Emprestimo emprestimo;


        /* Propriedades
        public int Tompo { get => tompo; set => tompo = value; }
        public List<Emprestimo> Emprestimos { get => emprestimos; set => emprestimos = value; }
        */

        // Construtores

        /*Saulo
        public Exemplar() {
            tombo++;
        }*/

        // Bruno
        
        
        public Exemplar(int tombo):base()
        {
            
        }
        public Exemplar(Livro l , int tombo) : base()
        {
            super() = l;

        }
            
        //atributos
        public int getTombo()
        {
            return this.tombo;
        }


        // Métodos

        public bool emprestar()
        {
            // Bruno
            if (disponivel())
            {
                emprestimo = new Emprestimo();
                emprestimos.Add(emprestimo);
                return true;
            }
            else return false;

            /*Saulo
            try
            {
                emprestimo.dtEmprestimo = DateTime.Now;
                emprestimos.Add(emprestimo);
                return true;
            }
            catch {return false;}     */
        }
        public bool devolver()
        {
            // Bruno
            if (disponivel())
            {
                emprestimos[emprestimos.Count() - 1].setDtDevolucao(DateTime.Now);
                return true;
            }
            else return false;

            /* Saulo
            try
            {
                emprestimo.dtDevolucao = DateTime.Now;
                DateTime tempEmprestimo = emprestimos.Last().dtEmprestimo;
                emprestimos.RemoveAt(emprestimos.IndexOf(emprestimo));
                emprestimos.Add(emprestimo);
                return true;
            }
            catch { return false; }   */
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
