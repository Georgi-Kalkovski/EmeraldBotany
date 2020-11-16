namespace EmeraldBotany.Data.Models
{
    using EmeraldBotany.Data.Common.Models;
    using Newtonsoft.Json;

    public class Specifications : BaseDeletableModel<int>
    {
        [JsonProperty("growth_habit")]
        public string GrowthHabit { get; set; }

        [JsonProperty("growth_rate")]
        public string GrowthRate { get; set; }

        [JsonProperty("form")]
        public string Form { get; set; }

        [JsonProperty("nitrogen_fixation")]
        public string NitrogenFixation { get; set; }

        [JsonProperty("shape_and_orientation")]
        public string ShapeAndOrientation { get; set; }

        [JsonProperty("toxicity")]
        public string Toxicity { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("average_height")]
        public string AverageHeight { get; set; }

        [JsonProperty("maximum_height")]
        public string MaximumHeight { get; set; }
    }
}
