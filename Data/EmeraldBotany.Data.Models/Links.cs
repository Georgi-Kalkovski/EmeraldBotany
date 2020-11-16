namespace EmeraldBotany.Data.Models
{
    using EmeraldBotany.Data.Common.Models;
    using Newtonsoft.Json;

    public class Links : BaseDeletableModel<int>
    {
        [JsonProperty("genus")]
        public string Genus { get; set; }

        [JsonProperty("self")]
        public string Plant { get; set; }

        [JsonProperty("species")]
        public string Self { get; set; }
    }
}
