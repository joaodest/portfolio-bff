using Microsoft.EntityFrameworkCore;
using portfolio_bff.Exceptions;
using portfolio_bff.Models.Github;
using portfolio_bff.Repositories.Interfaces;

namespace portfolio_bff.Repositories
{
    public class GithubUserRepository : IUserRepository<GithubUser>
    {
        private readonly PortfolioDbContext _context;

        public GithubUserRepository(PortfolioDbContext context)
        {
            _context = context;
        }

        public async Task<GithubUser> GetByIdAsync(int id)
        {
            return await _context.GithubUsers.FindAsync(id);
        }

        public async Task<GithubUser> GetUserByUsernameAsync(string username)
        {
            var githubUser = await _context.GithubUsers
                .FirstOrDefaultAsync(u => u.Username == username);

            if (githubUser == null)
                throw new InvalidUserException();

            return githubUser;
        }

        public async Task AddAsync(GithubUser entity)
        {
            await _context.GithubUsers.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(GithubUser entity)
        {
            _context.GithubUsers.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var user = await GetByIdAsync(id);
            _context.GithubUsers.Remove(user);
            await _context.SaveChangesAsync();
        }
    }
}
