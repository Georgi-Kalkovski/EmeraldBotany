namespace EmeraldBotany.Web.Controllers
{
    using System.Diagnostics;

    using EmeraldBotany.Web.TrefleOpenAPIService;
    using EmeraldBotany.Web.ViewModels;

    using Microsoft.AspNetCore.Mvc;

    public class HomeController : BaseController
    {
        private readonly IPlantsService plantsService;

        public HomeController(IPlantsService plantsService)
        {
            this.plantsService = plantsService;
        }

        public IActionResult Index()
        {
            return this.View();
        }

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
