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
    public class LoanRepository : ILoanRepository
    {
        private readonly CrediSoftDbContext _context;

        public LoanRepository(CrediSoftDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Loan loan)
        {
            await _context.Loan.AddAsync(loan);
        }

        public async Task DeleteAsync(Loan loan)
        {
            _context.Loan.Remove(loan);
        }

        public async  Task<IEnumerable<Loan>> GetAllAsync() => await _context.Loan.ToListAsync();

        public async Task<IEnumerable<Loan>> GetByClientIdAsync(int id) => await _context.Loan.Where(l => l.ClientId == id).ToListAsync();

        public async Task<Loan?> GetByIdAsync(int id) => await _context.Loan.FirstOrDefaultAsync(l => l.Id == id);

        public async Task UpdateAsync(Loan loan)
        {
             _context.Loan.Update(loan);
        }
    }
}
