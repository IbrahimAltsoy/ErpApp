using ErpApp.Domain.Entities;
using ErpApp.Domain.Entities.Common;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
namespace ErpApp.Persistance.Context
{
    public class ApplicationDbContext:IdentityDbContext<User, AppRole, string>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Endpoint> Endpoints { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.HasDefaultSchema("application");
            base.OnModelCreating(builder);

            // Identity tablolarının varsayılan yapılandırmasını kullan
            builder.Entity<User>(entity =>
            {
                entity.ToTable(name: "Users");
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            builder.Entity<IdentityUserLogin<string>>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });
            });

            builder.Entity<IdentityUserRole<string>>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });
            });

            builder.Entity<IdentityUserToken<string>>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });
            });

        }
        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var values = ChangeTracker.Entries<BaseEntity>();
            foreach (var value in values)
            {
                _ = value.State switch
                {
                    EntityState.Added => value.Entity.CreatedDate = DateTime.UtcNow,
                    EntityState.Modified => value.Entity.UpdateDate = DateTime.UtcNow,
                    _ => DateTime.UtcNow
                };
            }
            return await base.SaveChangesAsync(cancellationToken);
        }
    }

}

