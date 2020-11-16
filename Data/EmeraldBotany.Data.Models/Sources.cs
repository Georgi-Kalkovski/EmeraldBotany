namespace EmeraldBotany.Data.Models
{
    using System;

    using EmeraldBotany.Data.Common.Models;
    using Newtonsoft.Json;

    public class Sources : BaseDeletableModel<string>
    {
        public Sources()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        [JsonProperty("citation")]
        public string Citation { get; set; }

        [JsonProperty("last_update")]
        public string LastUpdate { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
