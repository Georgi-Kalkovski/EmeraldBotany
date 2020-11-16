namespace EmeraldBotany.Data.Models
{
    using EmeraldBotany.Data.Common.Models;
    using Newtonsoft.Json;

    public class FruitOrSeed : BaseDeletableModel<int>
    {
        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("conspicuous")]
        public bool Conspicuous { get; set; }

        [JsonProperty("seed_persistence")]
        public bool SeedPersistence { get; set; }

        [JsonProperty("shape")]
        public string Shape { get; set; }
    }
}
