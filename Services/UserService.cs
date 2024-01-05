
using portfolio_bff.Models;
using portfolio_bff.Repositories;

namespace portfolio_bff.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository<Linkedin> _linkedinRepository;
        private readonly IUserRepository<Github> _githubRepository;


        public UserService(
            IUserRepository<Linkedin> linkedinRepository,
            IUserRepository<Github> githubRepository)
        {
            _linkedinRepository = linkedinRepository;
            _githubRepository = githubRepository;
        }
         public async Task<User> GetUserByIdAsync(int id)
        {
            var linkedinData = await _linkedinRepository.GetByIdAsync(id);
            var githubData = await _githubRepository.GetByIdAsync(id);

            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>
            {
                { "linkedinUrl", linkedinData.Link },
                { "githubUrl", githubData.ProfileURL }
            };

            var user = new User
            {
                LinkedinData = linkedinData,
                GithubData = githubData,  
            };

            user.SetSocialLinks(keyValuePairs);

            if(user == null)
                throw new ArgumentNullException(nameof(user));

            return user;
        }

        public Task<User> GetUserByUsernameAsync(string username)
        {
            throw new NotImplementedException();
        }
    }
}
