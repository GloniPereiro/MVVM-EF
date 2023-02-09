using Crud.domain.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.EF
{
    public class ProductDBContext : DbContext
    {
        public DbSet<ListaProduktow> ListaProduktow { get; set; }
        public DbSet<HistoriaProduktow> HistoriaProduktow { get; set; }
        public ProductDBContext()
        {

        }

        public ProductDBContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ListaProduktow>().HasKey(e => e.IdProduktu);
            modelBuilder.Entity<HistoriaProduktow>().HasKey(s => s.IdZmiany);
        }
    }
}
 