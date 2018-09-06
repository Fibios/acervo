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

        /*
        // Propriedades
        public DateTime DtEmprestimo { get => dtEmprestimo; set => dtEmprestimo = value; }
        public DateTime DtDevolucao { get => dtDevolucao; set => dtDevolucao = value; }
        */

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

