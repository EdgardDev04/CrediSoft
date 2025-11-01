using CrediSoft.Domain.Entities;
using CrediSoft.Domain.Interfaces;
using CrediSoft.Infrastructure.Persistence;

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
            //await _context.Client.Add(client);
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(Client client)
        {
            //await _context.Client.Remove(client);
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Client>> GetAllAsync()
        {
            //await _context.Client.ToListAsync();
            throw new NotImplementedException();
        }

        public Task<Client?> GetByIdAsync(int id)
        {
            //await _context.Client.FirstOrDefaultAsync(c => c.Id == id);
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Client client)
        {
            //await _context.Client.Update(client);
            throw new NotImplementedException();
        }
    }
}
