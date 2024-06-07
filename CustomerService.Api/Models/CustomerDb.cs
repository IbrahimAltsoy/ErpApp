using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;

namespace CustomerService.Api.Models
{
    public class CustomerDb:DbContext
    {
        public CustomerDb(DbContextOptions<CustomerDb> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Customer>().HasKey(c => c.Id);
            modelBuilder.Entity<Customer>().Property(c => c.Name).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Customer>().Property(c => c.Phone).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Customer>().Property(c => c.Email).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Customer>().Property(c => c.Address).IsRequired().HasMaxLength(100);
        }

    }
}
//Server = (localdb)\\SF003; Database = Cron_Dev; MultipleActiveResultSets = True;