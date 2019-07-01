using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;

namespace Heroes.Data.Models
{
    public class HeroDocument : BaseDocument
    {

        [JsonProperty("object")]
        public override string Object => "Hero";

        [JsonProperty("hero_id")]
        public Guid HeroId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("powers")]
        public string[] Powers { get; set; }

        [JsonProperty("affiliations")]
        public string[] Affiliations { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }
    }
}
