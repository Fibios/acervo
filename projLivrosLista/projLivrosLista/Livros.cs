using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projLivrosLista
{
    class Livros
    {
        // Atributos
        private List<Livro> acervo = new List<Livro>();
        Exemplar l;

        /* Propriedades
        public List<Livro> Acervo { get => acervo; set => acervo = value; }
        */

        //Métodos
        public void adicionar(Livro livro)
        { 
            acervo.Add(livro);
            

        }
        public Livro pesquisar(Livro l)
        {
            Livro livroAchado = null;
            foreach (Livro livro in this.acervo)
            {
                if (livro.Equals(l))
                {
                    livroAchado = livro;
                }
            }
            return livroAchado;
        }

    }
}
