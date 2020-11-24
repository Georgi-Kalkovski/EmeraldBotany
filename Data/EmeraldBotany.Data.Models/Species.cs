namespace EmeraldBotany.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    using EmeraldBotany.Data.Common.Models;
    using EmeraldBotany.Data.Models.Enums;

    public class Species : BaseDeletableModel<int>
    {
        public Species()
        {
            this.Duration = new HashSet<Duration?>();
            this.EdiblePart = new HashSet<EdiblePart?>();
            this.CommonNames = new Dictionary<string, ICollection<string>>();
            this.Synonyms = new HashSet<Synonyms>();
            this.Sources = new HashSet<Sources>();
            this.Distributions = new Dictionary<string, ICollection<string>>();
        }

        public string ScientificName { get; set; }

        public string Genus { get; set; }

        public string Family { get; set; }

        public int? Year { get; set; }

        public virtual string Author { get; set; }

        public string Bibliography { get; set; }

        public string CommonName { get; set; }

        public string FamilyCommonName { get; set; }

        public string ImageUrl { get; set; }

        public bool? Vegetable { get; set; }

        public string Observations { get; set; }

        public string AuthorId { get; set; }

        public int? FlowerId { get; set; }

        public int? FoliageId { get; set; }

        public int? FruitOrSeedId { get; set; }

        public int? SpecificationsId { get; set; }

        public int? GrowthId { get; set; }

        public int? DistributionId { get; set; }

        public int? LinksId { get; set; }

        public virtual Links Links { get; set; }

        public virtual Distributions Distribution { get; set; }

        public virtual Images Images { get; set; }

        public virtual Flower Flower { get; set; }

        public virtual Foliage Foliage { get; set; }

        public virtual FruitOrSeed FruitOrSeed { get; set; }

        public virtual Specifications Specifications { get; set; }

        public virtual Growth Growth { get; set; }

        public SpeciesRank Rank { get; set; }

        public SpeciesStatus Status { get; set; }

        [NotMapped]
        public virtual ICollection<Duration?> Duration { get; set; }

        [NotMapped]
        public virtual ICollection<EdiblePart?> EdiblePart { get; set; }

        public virtual ICollection<Synonyms> Synonyms { get; set; }

        public virtual ICollection<Sources> Sources { get; set; }

        [NotMapped]
        public virtual IDictionary<string, ICollection<string>> CommonNames { get; set; }

        [NotMapped]
        public virtual IDictionary<string, ICollection<string>> Distributions { get; set; }
    }
}
