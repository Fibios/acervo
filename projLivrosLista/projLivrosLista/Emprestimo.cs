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
        private DateTime dtDevolucao;

        // Construtores

        public Emprestimo() {
            this.dtEmprestimo = DateTime.Now;
            this.dtDevolucao = DateTime.MinValue;
    }
        //atributos
        public DateTime Dtdevolucao { get { return dtDevolucao; } set { dtDevolucao = value; } }
    }
}

