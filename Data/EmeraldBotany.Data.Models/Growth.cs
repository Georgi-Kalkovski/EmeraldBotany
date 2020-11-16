namespace EmeraldBotany.Data.Models
{
    using EmeraldBotany.Data.Common.Models;
    using Newtonsoft.Json;

    public class Growth : BaseDeletableModel<int>
    {
        [JsonProperty("atmospheric_humidity")]
        public int AtmosphericHumidity { get; set; }

        [JsonProperty("days_to_harvest")]
        public int DaysToHarvest { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("light")]
        public int Light { get; set; }

        [JsonProperty("ph_maximum")]
        public int PhMaximum { get; set; }

        [JsonProperty("ph_minimum")]
        public int PhMinimum { get; set; }

        [JsonProperty("soil_humidity")]
        public int SoilHumidity { get; set; }

        [JsonProperty("soil_nutriments")]
        public int SoilNutriments { get; set; }

        [JsonProperty("soil_salinity")]
        public int SoilSalinity { get; set; }

        [JsonProperty("soil_texture")]
        public int SoilTexture { get; set; }

        [JsonProperty("sowing")]
        public string Sowing { get; set; }

        [JsonProperty("bloom_months")]
        public string BloomMonth { get; set; }

        [JsonProperty("growth_months")]
        public string GrowthMonth { get; set; }

        [JsonProperty("fruit_months")]
        public string FruitMonths { get; set; }

        [JsonProperty("maximum_precipitation")]
        public string MaximumPrecipitation { get; set; }

        [JsonProperty("maximum_temperature")]
        public string MaximumTemperature { get; set; }

        [JsonProperty("minimum_precipitation")]
        public string MinimumPrecipitation { get; set; }

        [JsonProperty("minimum_root_depth")]
        public string MinimumRootDepth { get; set; }

        [JsonProperty("minimum_temperature")]
        public string MinimumTemperature { get; set; }

        [JsonProperty("string")]
        public string RowSpacing { get; set; }

        [JsonProperty("spread")]
        public string Spread { get; set; }
    }
}
