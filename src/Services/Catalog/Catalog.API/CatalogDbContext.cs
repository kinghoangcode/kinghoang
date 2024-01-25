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
            optionsBuilder.UseSqlServer("server=GETZ\\SQLEXPRESS;database=King.Catalog;trusted_connection=true;TrustServerCertificate=True;");
        }
    }
}
