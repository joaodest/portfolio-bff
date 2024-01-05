using portfolio_bff.Repositories;

namespace portfolio_bff.Models
{
    public class User
    {
        public int UserId { get; set; }

        public Linkedin LinkedinData { get; set; }
        public Github GithubData { get; set; }

        public Dictionary<string, string> SocialLinks { get; set; } = new Dictionary<string, string>();

        public void SetSocialLinks(Dictionary<string, string> socialLinks)
        {
            SocialLinks = socialLinks;
        }
        public void MapToUser(Object obj)
        {
            if (obj is Linkedin linkedinData)
            {
                this.LinkedinData = linkedinData;
            }
            else if (obj is Github githubData)
            {
                this.GithubData = githubData;
            }
            else
            {
                throw new Exception("Invalid object type. Expected Linkedin or Github.");
            }
        }
    }
}
