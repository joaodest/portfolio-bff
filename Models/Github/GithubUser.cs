using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace portfolio_bff.Models.Github
{
    [Table("GithubUsers", Schema = "public")]
    public class GithubUser
    {
        [Key]
        public int Id { get; set; }
        [Column("Username")]
        public string Username { get; set; } = string.Empty;
        [Column("AvatarURL")]
        public string AvatarURL { get; set; } = string.Empty;
        [Column("ProfileURL")]
        public string ProfileURL { get; set; } = string.Empty;

        [Column("Email")]
        public string Email { get; set; } = string.Empty;

        public ICollection<FeaturedProjects> Projects { get; set; } = new List<FeaturedProjects>();
    }
}