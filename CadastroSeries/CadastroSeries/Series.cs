using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroSeries {
   public class Series {
        public string Nome { get; set; }
        public string Genero { get; set; }
        public string Diretor { get; set; }

        public Series(string nome, string genero, string diretor) {
            this.Nome = nome;
            this.Genero = genero;
            this.Diretor = diretor;
        }
    }
}
