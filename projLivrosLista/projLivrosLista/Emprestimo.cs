using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projLivrosLista
{
    public class Emprestimo
    {
        // Atributos
        private DateTime dtEmprestimo;
        private DateTime dtDevolucao = DateTime.MinValue;

        // Construtores

        public Emprestimo() {
            this.dtEmprestimo = DateTime.Now; ;
        }
        //atributos
        public DateTime getdtDevolucao()
        {
            return this.dtDevolucao;
        }
        public void setDtDevolucao (DateTime dt)
        {
            this.dtDevolucao = dt;
        }


    }
}

