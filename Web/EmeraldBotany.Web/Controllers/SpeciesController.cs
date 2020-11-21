namespace EmeraldBotany.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using EmeraldBotany.Data.Common.Repositories;
    using EmeraldBotany.Data.Models;
    using EmeraldBotany.Services.Data;
    using EmeraldBotany.Web.ViewModels.Species;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;

    public class SpeciesController : Controller
    {
        private readonly ISpeciesService speciesService;
        private readonly IRepository<SpeciesDataDump> repository;

        public SpeciesController(ISpeciesService speciesService, IRepository<SpeciesDataDump> repository)
        {
            this.speciesService = speciesService;
            this.repository = repository;
        }

        public IActionResult Index()
        {
            var species = this.speciesService.GetAll<SpecieViewModel>();
            var model = new SpeciesListViewModel { Species = species };
            return this.View(model);
        }
    }
}
