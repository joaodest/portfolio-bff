using portfolio_bff.Models.Github;
using portfolio_bff.Models.Linkedin;
using portfolio_bff.Repositories;
using System.ComponentModel.DataAnnotations;

namespace portfolio_bff.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        public LinkedInUser LinkedinData { get; set; }
        public GithubUser GithubData { get; set; }

        public Dictionary<string, string> SocialLinks { get; set; } = new Dictionary<string, string>();

        public void SetSocialLinks(Dictionary<string, string> socialLinks)
        {
            SocialLinks = socialLinks;
        }
        public void MapToUser(Object obj)
        {
            if (obj is LinkedInUser linkedinData)
            {
                this.LinkedinData = linkedinData;
            }
            else if (obj is GithubUser githubData)
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
