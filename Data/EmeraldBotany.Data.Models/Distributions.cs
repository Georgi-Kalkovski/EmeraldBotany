namespace EmeraldBotany.Data.Models
{
    using EmeraldBotany.Data.Common.Models;
    using Newtonsoft.Json;

    public class Distributions : BaseDeletableModel<int>
    {
        [JsonProperty("absent")]
        public string Absent { get; set; }

        [JsonProperty("doubtful")]
        public string Doubtful { get; set; }

        [JsonProperty("extinct")]
        public string Extinct { get; set; }

        [JsonProperty("introduced")]
        public string Introduced { get; set; }

        [JsonProperty("native")]
        public string Native { get; set; }
    }
}
