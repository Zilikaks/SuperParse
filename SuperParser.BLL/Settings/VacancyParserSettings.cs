using SuperParser.Infrastructure.Interfaces;

namespace SuperParser.BLL.Settings
{
    public class VacancyParserSettings : IParserSettings
    {
        public string BaseUrl { get; set; }
        public string Pagination { get; set; }
        public int StartPage { get; set; }
        public int EndPage { get; set; }
    }
}
