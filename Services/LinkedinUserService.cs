using portfolio_bff.Models.Linkedin;
using portfolio_bff.Repositories;
using portfolio_bff.Services.Interfaces;

namespace portfolio_bff.Services
{
    public class LinkedinUserService : IUserService<LinkedInUser>
    {
        private readonly LinkedinUserRepository _userRepository;

        public LinkedinUserService(LinkedinUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<LinkedInUser> GetUserByIdAsync(int id)
        {
            var linkedinUser = await _userRepository.GetByIdAsync(id);

            if (linkedinUser == null)
                throw new ArgumentNullException(nameof(linkedinUser));

            return linkedinUser;
        }

        public async Task<LinkedInUser> GetUserByUsernameAsync(string username)
        {
            var linkedinUser = await _userRepository.GetUserByUsernameAsync(username);

            if(linkedinUser == null)
                throw new ArgumentNullException(nameof(linkedinUser));

            return linkedinUser;
        }
    }
}
