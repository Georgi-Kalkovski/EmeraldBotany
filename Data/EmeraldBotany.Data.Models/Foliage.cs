namespace EmeraldBotany.Data.Models
{
    using EmeraldBotany.Data.Common.Models;
    using Newtonsoft.Json;

    public class Foliage : BaseDeletableModel<int>
    {
        [JsonProperty("leaf_retention")]
        public bool LeafRetention { get; set; }

        [JsonProperty("color")]
        public string Texture { get; set; }

        [JsonProperty("texture")]
        public virtual string Color { get; set; }
    }
}
