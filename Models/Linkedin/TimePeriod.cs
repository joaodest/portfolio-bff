using System.ComponentModel.DataAnnotations;

namespace portfolio_bff.Models.Linkedin
{
    public class TimePeriod
    {
        [Key]
        public int TimePeriodId { get; set; }
        public string Month { get; set; } = string.Empty;
        public string Year { get; set; } = string.Empty;
    }
}