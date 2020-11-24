namespace EmeraldBotany.Web.ViewModels.Plants
{
    using System.Collections.Generic;

    using EmeraldBotany.Data.Models;
    using EmeraldBotany.Services.Mapping;

    public class CreatePlantInputModel : IMapFrom<Plant>
    {
        public string CommonName { get; set; }

        public string Slug { get; set; }

        public string ScientificName { get; set; }

        public int? Year { get; set; }

        public string Bibliography { get; set; }

        public string Author { get; set; }

        public string FamilyCommonName { get; set; }

        public int GenusId { get; set; }

        public bool? Vegetable { get; set; }

        public string Observations { get; set; }

        public int? MainSpeciesId { get; set; }

        public virtual Links Links { get; set; } = new Links();

        public virtual Species Species { get; set; }

        public virtual IEnumerator<Source> Sources { get; set; }
    }
}
