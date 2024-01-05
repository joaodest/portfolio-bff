namespace portfolio_bff.Models
{
    public class Github
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string AvatarURL { get; set; } = string.Empty;
        public string ProfileURL { get; set; } = string.Empty;

        public ICollection<FeaturedProjects> Projects { get; set; } = new List<FeaturedProjects>();
    }
}