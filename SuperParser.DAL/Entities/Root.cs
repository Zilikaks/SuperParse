using Newtonsoft.Json;
using System.Collections.Generic;

namespace SuperParser.DAL.Entities
{
    public class Root
    {
        [JsonProperty("found")]
        public int Found { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("per_page")]
        public int PerPage { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("items")]
        public IEnumerable<Ref> Refs { get; set; }
    }
}
