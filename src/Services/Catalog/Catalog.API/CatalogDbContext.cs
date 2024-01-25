using Catalog.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Catalog.API
{
    public class CatalogDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=192.168.0.79,1433;database=King.Catalog;trusted_connection=true;TrustServerCertificate=True;");
        }
    }
}
