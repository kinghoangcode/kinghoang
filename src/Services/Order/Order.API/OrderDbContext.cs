using Microsoft.EntityFrameworkCore;

namespace Order.API
{
    public class OrderDbContext : DbContext
    {
        public DbSet<Models.Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=192.168.0.79,1433;database=King.Order;User Id=sa;Password=123;TrustServerCertificate=True;");
        }
    }
}
