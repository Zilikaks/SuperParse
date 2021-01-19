using Newtonsoft.Json;

namespace SuperParser.DAL.Entities
{
    public class Employer
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public bool Trusted { get; set; }

        [JsonProperty("alternate_url")]
        public string AlternateUrl { get; set; }
        [JsonProperty("vacancies_url")]
        public string VacanciesUrl { get; set; }
    }
}
