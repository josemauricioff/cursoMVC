using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZehMau.LojaVirtual.Dominio.Entidade;

namespace ZehMau.LojaVirtual.Dominio.Repositorio
{
    public class ProdutoRepositorio : DbContext
    {
        private readonly EfDbContext context = new EfDbContext();

        public IEnumerable<Produto> Produtos => context.Produtos;

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
            modelBuilder.Entity<Produto>().ToTable("Produto");
        }
    }
}
