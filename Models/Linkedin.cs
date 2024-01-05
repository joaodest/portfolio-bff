namespace portfolio_bff.Models
{
    public class Linkedin
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Headline { get; set; } = string.Empty;
        public string Summary { get; set; } = string.Empty;
        public string Link { get; set; } = string.Empty;   
        public ICollection<Experience> Experiences { get; set; } = new List<Experience>();

    }
}