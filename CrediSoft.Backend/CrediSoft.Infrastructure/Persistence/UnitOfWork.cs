using CrediSoft.Domain.Interfaces;
using CrediSoft.Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore.Storage;

namespace CrediSoft.Infrastructure.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CrediSoftDbContext _context;
        private IDbContextTransaction _transaction;

        public IClientRepository Client { get; }

        public ILoanRepository Loan { get; }

        public IUserRepository User { get; }

        public UnitOfWork(CrediSoftDbContext context)
        {
            _context = context;
            Client = new ClientRepository(_context);
            Loan = new LoanRepository(_context);
            User = new UserRepository(_context);
        }

        public async Task BeginTransactionAsync()
        {
            _transaction ??= await _context.Database.BeginTransactionAsync();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
            await _transaction?.CommitAsync()!;
            await _transaction.DisposeAsync();
            _transaction = null;
        }

        public async Task RollbackAsync()
        {
            if (_transaction != null)
            {
                await _transaction.RollbackAsync();
                await _transaction.DisposeAsync();
                _transaction = null;
            }
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
