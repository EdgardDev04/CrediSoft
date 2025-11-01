using CrediSoft.Domain.Entities;
using CrediSoft.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;


namespace CrediSoft.Infrastructure.Persistence.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly CrediSoftDbContext _context;

        public ClientRepository(CrediSoftDbContext context)
        {
            _context = context; 
        }

        public async Task AddAsync(Client client)
        {
            await _context.Client.AddAsync(client);
        }

        public async Task DeleteAsync(Client client)
        {
            _context.Client.Remove(client);
        }

        public async Task<IEnumerable<Client>> GetAllAsync() => await _context.Client.ToListAsync();

        public async Task<Client?> GetByIdAsync(int id) => await _context.Client.FirstOrDefaultAsync(c => c.Id == id);


        public async Task UpdateAsync(Client client)
        {
            _context.Client.Update(client);
        }
    }
}
