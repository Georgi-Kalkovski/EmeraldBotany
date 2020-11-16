namespace EmeraldBotany.Data.Models
{
    using EmeraldBotany.Data.Common.Models;
    using Newtonsoft.Json;

    public class Flower : BaseDeletableModel<int>
    {
        [JsonProperty("introconspicuousduced")]
        public string Conspicuous { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }
    }
}
