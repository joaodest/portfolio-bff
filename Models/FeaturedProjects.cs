public class FeaturedProjects
{
    private const string _defaultDescription = "Projeto atualmente sem descrição.";
    private string _description = string.Empty;
    public int ProjectId { get; set; }
    public string ProjectName { get; set; } = string.Empty;

    public string Description
    {
        get => string.IsNullOrEmpty(_description) ? _defaultDescription : _description;
        set => _description = value;
    }

    public string Url { get; set; } = string.Empty;
    public bool isPrivate { get; set; }
}