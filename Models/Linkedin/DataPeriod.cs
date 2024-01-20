using System.ComponentModel.DataAnnotations;

namespace portfolio_bff.Models.Linkedin
{
    public class DataPeriod
    {
        [Key]
        public string Start { get; set; }
        public string End { get; set; }

    }
}