
namespace CrediSoft.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        IClientRepository Client { get; }
        ILoanRepository Loan { get; }
        IUserRepository User { get; }

        Task<int> SaveChangesAsync();
        Task BeginTransactionAsync();
        Task CommitAsync();
        Task RollbackAsync();
    }
}
