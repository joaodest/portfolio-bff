namespace portfolio_bff.Models
{
    public class Experience
    {
        public int ExperienceId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DataPeriod Data { get; set; }
        public ICollection<Organisation> Organisations { get; set; } = new List<Organisation>();
        public TimePeriod Period { get; set; }

    }
}