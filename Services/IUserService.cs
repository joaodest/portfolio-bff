using portfolio_bff.Models;

namespace portfolio_bff.Services
{
    public interface IUserService
    {
        Task<User> GetUserByIdAsync(int id);
        Task<User> GetUserByUsernameAsync(string username);
    }
}
