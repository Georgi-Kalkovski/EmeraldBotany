namespace EmeraldBotany.Data.Models
{
    using System.Collections.Generic;

    using EmeraldBotany.Data.Common.Models;
    using Newtonsoft.Json;

    public class Trefle : BaseDeletableModel<int>
    {
        public Trefle()
        {
            this.Data = new HashSet<Species>();
        }

        [JsonProperty("data")]
        public virtual ICollection<Species> Data { get; set; }
    }
}
