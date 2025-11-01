using CrediSoft.Domain.Entities;
using CrediSoft.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrediSoft.Infrastructure.Persistence.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly CrediSoftDbContext _context;

        public UserRepository(CrediSoftDbContext context)
        {
            _context = context;
        }

        public Task AddAsync(User user)
        {
            // await _context.User.Add(client);
            throw new NotImplementedException();
        }

        public Task DeleteAsync(User user)
        {
            // await _context.User.Remove(client);
            throw new NotImplementedException();
        }

        public Task<User?> GetByIdAsync(int id)
        {
            // await _context.User.FirstOrDefaultAsync(client);
            throw new NotImplementedException();
        }

        public Task UpdateAsync(User user)
        {
            // await _context.User.Update(client);
            throw new NotImplementedException();
        }
    }
}
