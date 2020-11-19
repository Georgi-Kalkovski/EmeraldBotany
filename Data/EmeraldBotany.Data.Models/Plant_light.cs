namespace EmeraldBotany.Data.Models
{
    public class Plant_light
    {
        public int Id { get; set; }

        public string Common_name { get; set; }

        public string Slug { get; set; }

        public string Scientific_name { get; set; }

        public int? Year { get; set; }

        public string Bibliography { get; set; }

        public string Author { get; set; }

        public string Family_common_name { get; set; }

        public int Genus_id { get; set; }

        public int? Main_species_id { get; set; }

        public bool? Vegetable { get; set; }

        public string Observations { get; set; }

        public Links9 Links { get; set; } = new Links9();

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}
