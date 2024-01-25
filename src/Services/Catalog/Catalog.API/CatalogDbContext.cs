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
            optionsBuilder.UseSqlServer("Data Source=192.168.0.79,1433;database=King.Catalog;User Id=sa;Password=123;TrustServerCertificate=True;");
        }
    }
}
