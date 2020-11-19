namespace EmeraldBotany.Data.Models
{
    public class Growth
    {
        public double? Days_to_harvest { get; set; }

        public string Description { get; set; }

        public string Sowing { get; set; }

        public double? Ph_maximum { get; set; }

        public double? Ph_minimum { get; set; }

        public int? Light { get; set; }

        public int? Atmospheric_humidity { get; set; }

        public System.Collections.Generic.ICollection<Growth_months?> Growth_months { get; set; }

        public System.Collections.Generic.ICollection<Bloom_months?> Bloom_months { get; set; }

        public System.Collections.Generic.ICollection<Fruit_months?> Fruit_months { get; set; }

        public Row_spacing Row_spacing { get; set; }

        public Spread Spread { get; set; }

        public Minimum_precipitation Minimum_precipitation { get; set; }

        public Maximum_precipitation Maximum_precipitation { get; set; }

        public Minimum_root_depth Minimum_root_depth { get; set; }

        public Minimum_temperature Minimum_temperature { get; set; }

        public Maximum_temperature Maximum_temperature { get; set; }

        public int? Soil_nutriments { get; set; }

        public int? Soil_salinity { get; set; }

        public int? Soil_texture { get; set; }

        public int? Soil_humidity { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }
}