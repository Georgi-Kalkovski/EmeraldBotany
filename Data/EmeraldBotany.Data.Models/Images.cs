namespace EmeraldBotany.Data.Models
{
    using System.Collections.Generic;

    using EmeraldBotany.Data.Common.Models;
    using Newtonsoft.Json;

    public class Images : BaseDeletableModel<int>
    {
        [JsonProperty("bark")]
        public string Bark { get; set; }

        [JsonProperty("flower")]
        public string Flower { get; set; }

        [JsonProperty("fruit")]
        public string Fruit { get; set; }

        [JsonProperty("habit")]
        public string Habit { get; set; }

        [JsonProperty("leaf")]
        public string Leaf { get; set; }

        [JsonProperty("other")]
        public string Other { get; set; }
    }
}
