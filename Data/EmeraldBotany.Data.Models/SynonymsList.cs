namespace EmeraldBotany.Data.Models
{
    using System;

    using EmeraldBotany.Data.Common.Models;
    using Newtonsoft.Json;

    public class SynonymsList : BaseDeletableModel<string>
    {
        public SynonymsList()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
