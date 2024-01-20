using portfolio_bff.Models;

namespace portfolio_bff.Services.Interfaces
{
    public interface IUserService<T> where T : class
    {
        Task<T> GetUserByIdAsync(int id);
        Task<T> GetUserByUsernameAsync(string username);
    }
}
