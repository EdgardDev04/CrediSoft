using CrediSoft.Domain.Entities;
using CrediSoft.Infrastructure.Persistence.Configurations;
using Microsoft.EntityFrameworkCore;

namespace CrediSoft.Infrastructure.Persistence
{
    public class CrediSoftDbContext : DbContext
    {
        public DbSet<Client> Client { get; set; }
        public DbSet<Loan> Loan { get; set; }
        public DbSet<User> User { get; set; }

        public CrediSoftDbContext(DbContextOptions<CrediSoftDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ClientConfiguration());
            modelBuilder.ApplyConfiguration(new LoanConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());

        }
    }
}
