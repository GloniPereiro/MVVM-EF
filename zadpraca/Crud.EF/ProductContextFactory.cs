using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.EF
{
    public class ProductContextFactory : IDesignTimeDbContextFactory<ProductDBContext>
    {
        public ProductDBContext CreateDbContext(string[] args = null)
        {
            var options = new DbContextOptionsBuilder<ProductDBContext>();
            options.UseSqlServer("Server=.; Database=ProduktyiHistoria; Trusted_Connection=True; TrustServerCertificate=True;");
            return new ProductDBContext(options.Options);
        }
    }
}
