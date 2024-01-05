using Microsoft.EntityFrameworkCore;
using portfolio_bff.Models;

namespace portfolio_bff.Repositories
{
    public class PortfolioDbContext : DbContext
    {
        public PortfolioDbContext(DbContextOptions<PortfolioDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Linkedin> LinkedinUsers { get; set; }
        public DbSet<Github> GithubUsers { get; set; }
    }
}
