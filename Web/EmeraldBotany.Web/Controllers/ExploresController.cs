namespace EmeraldBotany.Web.Controllers
{
    using EmeraldBotany.Services.Data;
    using EmeraldBotany.Web.ViewModels.Explores;
    using Microsoft.AspNetCore.Mvc;

    public class ExploresController : Controller
    {
        private readonly IExploresService exploresService;

        public ExploresController(IExploresService exploresService)
        {
            this.exploresService = exploresService;
        }

        public IActionResult Index()
        {
            var explores = this.exploresService.GetAll<ExploreViewModel>();
            var model = new ExploresListViewModel { Explores = explores };
            return this.View(model);
        }
    }
}
