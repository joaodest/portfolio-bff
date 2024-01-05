namespace portfolio_bff.Models
{
    public struct DataPeriod
    {
        public string Start { get; set; }
        public string End { get; set; }

        DataPeriod(string start, string end)
        {
            Start = start;
            End = end;
        }
    }
}