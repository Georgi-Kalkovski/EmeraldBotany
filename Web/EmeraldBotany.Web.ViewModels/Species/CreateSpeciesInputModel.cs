namespace EmeraldBotany.Web.ViewModel
{
    using System.Collections.Generic;

    using EmeraldBotany.Data.Models;
    using EmeraldBotany.Services.Mapping;

    public class CreateSpeciesInputModel : IMapFrom<Species>
    {
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

        public string Rank { get; set; }

        public string Status { get; set; }

        public virtual IEnumerator<string> Duration { get; set; }

        public virtual IEnumerator<string> EdiblePart { get; set; }

        public virtual IEnumerator<Synonyms> Synonyms { get; set; }

        public virtual IEnumerator<Sources> Sources { get; set; }

        public virtual IDictionary<string, IEnumerator<string>> CommonNames { get; set; }

        public virtual IDictionary<string, IEnumerator<string>> Distributions { get; set; }
    }
}
