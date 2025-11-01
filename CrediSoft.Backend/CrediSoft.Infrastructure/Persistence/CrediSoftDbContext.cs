using CrediSoft.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CrediSoft.Infrastructure.Persistence
{
    public class CrediSoftDbContext : DbContext
    {
        public DbSet<Client> Client { get; set; }
    }
}
