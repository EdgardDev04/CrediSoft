using CrediSoft.Domain.Entities;
using CrediSoft.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
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

        public async Task AddAsync(User user)
        {
            await _context.User.AddAsync(user);
        }

        public async Task DeleteAsync(User user)
        {
             _context.User.Remove(user);
        }

        public async Task<bool> ExistEmailAsync(string email) => await _context.User.AnyAsync(u => u.Email == email);

        public async Task<User?> GetByIdAsync(int id) => await _context.User.FirstOrDefaultAsync( u => u.Id == id);

        public async Task<User?> GetUserByUsernameAsync(string username) => await _context.User.FirstOrDefaultAsync(u => u.UserName == username);

        public async Task UpdateAsync(User user)
        {
            _context.User.Update(user);
        }
    }
}
