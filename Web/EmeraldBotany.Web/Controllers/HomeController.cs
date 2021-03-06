﻿namespace EmeraldBotany.Web.Controllers
{
    using System.Diagnostics;
    using System.Threading.Tasks;

    using EmeraldBotany.Data.Common.Repositories;
    using EmeraldBotany.Data.Models;
    using EmeraldBotany.Services.Data;
    using EmeraldBotany.Web.ViewModels;
    using Microsoft.AspNetCore.Mvc;

    public class HomeController : BaseController
    {
        private readonly IGetCountsService getCountsService;
        private readonly IUploadDatabaseService uploadDatabase;
        private readonly IDeletableEntityRepository<Species> repository;

        public HomeController(IGetCountsService getCountsService, IUploadDatabaseService uploadDatabase, IDeletableEntityRepository<Species> repository)
        {
            this.getCountsService = getCountsService;
            this.uploadDatabase = uploadDatabase;
            this.repository = repository;
        }

        public IActionResult Index()
        {
            var viewModel = this.getCountsService.GetCounts();
            return this.View(viewModel);
        }

        // public IActionResult Upload()
        // {
        //    var upload = this.uploadDatabase.PopulateDatabaseWithPlants();
        //    return this.View(upload);
        // }
        public IActionResult Privacy()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
