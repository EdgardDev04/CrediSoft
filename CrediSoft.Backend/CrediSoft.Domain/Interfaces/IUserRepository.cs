using CrediSoft.Domain.Entities;


namespace CrediSoft.Domain.Interfaces
{
    public interface IUserRepository
    {
        Task<User?> GetByIdAsync(int id);
        Task AddAsync(User client);
        Task UpdateAsync(User client);
        Task DeleteAsync(User client);
    }
}
