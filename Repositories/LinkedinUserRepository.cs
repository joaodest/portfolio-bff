using Microsoft.EntityFrameworkCore;
using portfolio_bff.Exceptions;
using portfolio_bff.Models.Linkedin;
using portfolio_bff.Repositories.Interfaces;

namespace portfolio_bff.Repositories
{
    public class LinkedinUserRepository : IUserRepository<LinkedInUser>
    {
        private readonly PortfolioDbContext _context;
        public LinkedinUserRepository(PortfolioDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(LinkedInUser user)
        {
            await _context.LinkedinUsers.AddAsync(user);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _context.LinkedinUsers.FindAsync(id);
            if (entity != null)
            {
                _context.LinkedinUsers.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<LinkedInUser> GetByIdAsync(int id)
        {
            var linkedinUser = await _context.LinkedinUsers.FindAsync(id);

            if (linkedinUser == null)
                throw new InvalidUserException();

            return linkedinUser;
        }

        public async Task<LinkedInUser> GetUserByUsernameAsync(string username)
        {
            var linkedinUser = await _context.LinkedinUsers
                .FirstOrDefaultAsync(u => u.Username == username);

            if (linkedinUser == null)
                throw new InvalidUserException();

            return linkedinUser;
        }


        public async Task UpdateAsync(LinkedInUser entity)
        {
            _context.LinkedinUsers.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
