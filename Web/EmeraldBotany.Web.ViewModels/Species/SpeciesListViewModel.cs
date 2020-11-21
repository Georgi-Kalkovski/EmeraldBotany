namespace EmeraldBotany.Web.ViewModels.Species
{
    using EmeraldBotany.Data.Models;
    using System.Collections.Generic;

    public class SpeciesListViewModel
    {
        public IEnumerable<SpecieViewModel> Species { get; set; }
    }
}
