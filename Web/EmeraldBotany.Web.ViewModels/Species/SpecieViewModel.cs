namespace EmeraldBotany.Web.ViewModels.Species
{
    using EmeraldBotany.Data.Models;
    using EmeraldBotany.Services.Mapping;

    using AutoMapper;

    public class SpecieViewModel : IMapFrom<SpeciesDataDump>
    {
        public int Id { get; set; }

        public string ScientificName { get; set; }

        public string ImageUrl { get; set; }

    }
}
