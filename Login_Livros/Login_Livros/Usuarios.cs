using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Livros {
    class Usuarios {
        public string Nome { get; set; }
        public string Senha { get; set; }

        public Usuarios(string nome, string senha) {
            this.Nome = nome;
            this.Senha = senha;
        }
    }
}
