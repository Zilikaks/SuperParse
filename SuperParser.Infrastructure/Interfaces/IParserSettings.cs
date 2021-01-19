namespace SuperParser.Infrastructure.Interfaces
{
    public interface IParserSettings
    {
        string BaseUrl { get; set; }
        string Pagination { get; set; }
        int StartPage { get; set; }
        int EndPage { get; set; }
    }
}
