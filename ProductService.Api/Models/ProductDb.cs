using Microsoft.EntityFrameworkCore;

namespace ProductService.Api.Models
{
    public class ProductDb:DbContext
    {
        public ProductDb(DbContextOptions<ProductDb> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasKey(c => c.Id);
            modelBuilder.Entity<Product>().Property(c => c.Name).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Product>().Property(c => c.Stock).IsRequired();
            modelBuilder.Entity<Product>().Property(c => c.Price).IsRequired();
            
        }
    }
}
