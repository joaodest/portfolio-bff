using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace portfolio_bff.Models.Linkedin
{
    [Table("LinkedInUsers", Schema = "public")]
    public class LinkedInUser
    {
        [Key]
        public int UserId { get; set; }

        [Column("Headline")]
        public string Headline { get; set; } = string.Empty;
        [Column("Name")]
        public string Name { get; set; } = string.Empty;
        [Column("Summary")]
        public string Summary { get; set; } = string.Empty;

        [Column("Link")]
        public string Link { get; set; } = string.Empty;

        [Column("Username")]
        public string Username { get; set; } = string.Empty;
        public ICollection<Experience> Experiences { get; set; } = new List<Experience>();

    }
}