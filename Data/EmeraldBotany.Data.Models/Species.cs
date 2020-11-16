namespace EmeraldBotany.Data.Models
{
    using System.Collections.Generic;

    using EmeraldBotany.Data.Common.Models;
    using Newtonsoft.Json;

    public class Species : BaseDeletableModel<int>
    {
        [JsonProperty("author")]
        public string Author { get; set; } // The author(s) of the first publication of a valid name of this species.

        [JsonProperty("bibliography")]
        public string Bibliography { get; set; } // The first publication of a valid name of this species.

        [JsonProperty("common_name")]
        public string CommonName { get; set; }

        [JsonProperty("common_names")]
        public string CommonNames { get; set; }

        [JsonProperty("distribution")]
        public string Distribution { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("edible")]
        public bool Edible { get; set; }

        [JsonProperty("edible_part")]
        public string EdiblePart { get; set; }

        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("family_common_name")]
        public string FamilyCommonName { get; set; }

        [JsonProperty("genus")]
        public string Genus { get; set; }

        [JsonProperty("genus_id")]
        public int GenusId { get; set; }

        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }

        [JsonProperty("observation")]
        public string Observation { get; set; }

        [JsonProperty("plant_id")]
        public int PlantId { get; set; }

        [JsonProperty("rank")]
        public string Rank { get; set; } // The taxonomic rank of the species, can be: species, ssp, var, form, hybrid, and subvar.

        [JsonProperty("scientific_name")]
        public string ScientificName { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("sources")]
        public string Sources { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; } // The acceptance status of this species by IPNI, can be: accepted and unknown.

        [JsonProperty("synonyms")]
        public string Synonyms { get; set; }

        [JsonProperty("vegetable")]
        public bool Vegetable { get; set; }

        [JsonProperty("year")]
        public string Year { get; set; } // The first publication year of a valid name of this species.
        
        [JsonProperty("distributions")]
        public int DistributionsId { get; set; }

        public virtual Distributions Distributions { get; set; }

        [JsonProperty("flower")]
        public int FlowerId { get; set; }

        public virtual Flower Flower { get; set; }

        [JsonProperty("foliage")]
        public int FoliageId { get; set; }

        public virtual Foliage Foliage { get; set; }

        [JsonProperty("fruit_or_seed")]
        public int FruitOrSeedId { get; set; }

        public virtual FruitOrSeed FruitOrSeed { get; set; }

        [JsonProperty("growth")]
        public int GrowthId { get; set; }

        public virtual Growth Growth { get; set; }

        [JsonProperty("images")]
        public int ImagesId { get; set; }

        public virtual Images Images { get; set; }

        [JsonProperty("links")]
        public int LinksId { get; set; }

        public virtual Links Links { get; set; }

        [JsonProperty("specifications")]
        public int SpecificationsId { get; set; }

        public virtual Specifications Specifications { get; set; }

        // public virtual Sources Sources { get; set; }

        // public virtual SynonymsList Synonyms { get; set; }
    }
}
