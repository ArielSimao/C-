namespace Banco_de_Dados
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Conexao : DbContext
    {
        public Conexao()
            : base("name=Conexao")
        {
        }

        public virtual DbSet<Produtos> Produtos { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produtos>()
                .Property(e => e.descricao)
                .IsUnicode(false);

            modelBuilder.Entity<Produtos>()
                .Property(e => e.fornecedor)
                .IsUnicode(false);
        }
    }
}
