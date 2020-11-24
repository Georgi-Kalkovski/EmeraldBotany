namespace EmeraldBotany.Data.Models
{
    using System.Collections.Generic;

    using EmeraldBotany.Data.Common.Models;

    public class Plant : BaseDeletableModel<int>
    {
        public Plant()
        {
            this.Sources = new HashSet<Source>();
        }

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

        public virtual Species MainSpecies { get; set; }

        public virtual ICollection<Source> Sources { get; set; }
    }
}
