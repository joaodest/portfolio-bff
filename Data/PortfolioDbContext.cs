using Microsoft.EntityFrameworkCore;
using portfolio_bff.Models;
using portfolio_bff.Models.Github;
using portfolio_bff.Models.Linkedin;

namespace portfolio_bff.Repositories
{
    public class PortfolioDbContext : DbContext
    {
        public PortfolioDbContext(DbContextOptions<PortfolioDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<LinkedInUser> LinkedinUsers { get; set; }
        public DbSet<GithubUser> GithubUsers { get; set; }
    }
}
