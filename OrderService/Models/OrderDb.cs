using Microsoft.EntityFrameworkCore;

namespace OrderService.Models
{
    public class OrderDb : DbContext
    {
        public OrderDb(DbContextOptions<OrderDb> options) : base(options) { }

        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Order>().HasKey(o => o.Id);
            modelBuilder.Entity<Order>().Property(o => o.Title).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Order>().Property(o => o.Description).IsRequired().HasMaxLength(500);
            modelBuilder.Entity<Order>().Property(o => o.OrderNumber).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Order>().Property(o => o.Price).IsRequired().HasColumnType("decimal(18,2)");
          
        }
    }
}
