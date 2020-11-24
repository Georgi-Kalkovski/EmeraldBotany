namespace EmeraldBotany.Web.ViewModels.Explores
{
    using EmeraldBotany.Data.Models;
    using EmeraldBotany.Services.Mapping;

    public class ExploreViewModel : IMapFrom<Species>
    {
        public int Id { get; set; }

        public string ScientificName { get; set; }

        public string Rank { get; set; }

        public string Genus { get; set; }

        public string Family { get; set; }

        public int? Year { get; set; }

        public string Author { get; set; }

        public string Bibliography { get; set; }

        public string CommonName { get; set; }

        public string FamilyCommonName { get; set; }

        public string ImageUrl { get; set; }
    }
}
