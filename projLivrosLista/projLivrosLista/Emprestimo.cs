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

        /*
        // Propriedades
        public DateTime DtEmprestimo { get => dtEmprestimo; set => dtEmprestimo = value; }
        public DateTime DtDevolucao { get => dtDevolucao; set => dtDevolucao = value; }
        */

        // Construtores

        public Emprestimo() {
            this.dtEmprestimo = DateTime.Now; ;
            this.dtDevolucao = dtEmprestimo.AddDays(7);
        }
    }
}

