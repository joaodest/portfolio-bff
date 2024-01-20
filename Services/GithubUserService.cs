using portfolio_bff.Models.Github;
using portfolio_bff.Repositories;
using portfolio_bff.Services.Interfaces;

namespace portfolio_bff.Services
{
    public class GithubUserService : IUserService<GithubUser>
    {
        private readonly GithubUserRepository _userRepository;

        public GithubUserService(GithubUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<GithubUser> GetUserByIdAsync(int id)
        {
            var githubUser = await _userRepository.GetByIdAsync(id);

            if (githubUser == null)
                throw new ArgumentNullException(nameof(githubUser));

            return githubUser;
        }

        public async Task<GithubUser> GetUserByUsernameAsync(string username)
        {
            var githubUser = await _userRepository.GetUserByUsernameAsync(username);

            if (githubUser == null)
                throw new ArgumentNullException(nameof(githubUser));

            return githubUser;
        }
    }
}
