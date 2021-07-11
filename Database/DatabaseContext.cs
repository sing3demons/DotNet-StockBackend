using Microsoft.EntityFrameworkCore;
using StockBackend.Models;

namespace StockBackend.Database
{
    public class DatabaseContext : DbContext
    {
        DbSet<Product> Products { get; set; }
        DbSet<Category> Categories { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}