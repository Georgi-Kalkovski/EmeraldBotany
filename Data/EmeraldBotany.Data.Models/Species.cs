namespace EmeraldBotany.Data.Models
{
    using EmeraldBotany.Data.Models.Enums;

    public class Species
    {
        public int Id { get; set; }

        public string Common_name { get; set; }

        public string Slug { get; set; }

        public string Scientific_name { get; set; }

        public int? Year { get; set; }

        public string Bibliography { get; set; }

        public string Author { get; set; }

        public SpeciesStatus Status { get; set; }

        public SpeciesRank Rank { get; set; }

        public string Family_common_name { get; set; }

        public string Family { get; set; }

        public int Genus_id { get; set; }

        public string Genus { get; set; }

        public string Image_url { get; set; }

        public Links10 Links { get; set; }

        public System.Collections.Generic.ICollection<Duration?> Duration { get; set; }

        public System.Collections.Generic.ICollection<Edible_part?> Edible_part { get; set; }

        public bool? Vegetable { get; set; }

        public string Observations { get; set; }

        public Images Images { get; set; }

        public System.Collections.Generic.IDictionary<string, System.Collections.Generic.ICollection<string>> Common_names { get; set; }

        public System.Collections.Generic.IDictionary<string, System.Collections.Generic.ICollection<string>> Distribution { get; set; }

        public Distributions Distributions { get; set; }

        public Flower Flower { get; set; }

        public Foliage Foliage { get; set; }

        public Fruit_or_seed Fruit_or_seed { get; set; }

        public Specifications Specifications { get; set; }

        public Growth Growth { get; set; }

        public System.Collections.Generic.ICollection<Synonyms> Synonyms { get; set; }

        public System.Collections.Generic.ICollection<Sources> Sources { get; set; }

        public object Extras { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}
