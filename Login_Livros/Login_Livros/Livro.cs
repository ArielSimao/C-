using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Livros {
   public class Livro {
        public string Nome { get; set; }
        public string Autor { get; set; }
        public DateTime dataPublicacao { get; set; }

        public Livro(string nome, string autor, DateTime data) {
            this.Nome = nome;
            this.Autor = autor;
            this.dataPublicacao = data;
        }


    }
}
