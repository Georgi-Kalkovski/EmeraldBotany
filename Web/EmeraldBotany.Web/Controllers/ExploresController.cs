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

    public class ExploresController : Controller
    {
        private readonly IExploresService exploresService;
        private readonly IRepository<SpeciesDataDump> repository;

        public ExploresController(IExploresService exploresService, IRepository<SpeciesDataDump> repository)
        {
            this.exploresService = exploresService;
            this.repository = repository;
        }

        public IActionResult Index()
        {
            var explores = this.exploresService.GetAll<ExploreViewModel>();
            var model = new ExploresListViewModel { Explores = explores };
            return this.View(model);
        }
    }
}
