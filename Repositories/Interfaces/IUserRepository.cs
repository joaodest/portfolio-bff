using portfolio_bff.Models;

namespace portfolio_bff.Repositories.Interfaces
{
    public interface IUserRepository<T> where T : class
    {
        Task<T> GetByIdAsync(int id);
        Task<T> GetUserByUsernameAsync(string username);
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(int id);
    }
}
