namespace Banco_de_Dados
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Produtos
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string descricao { get; set; }

        public double custo { get; set; }

        [Required]
        [StringLength(50)]
        public string fornecedor { get; set; }
    }
}
