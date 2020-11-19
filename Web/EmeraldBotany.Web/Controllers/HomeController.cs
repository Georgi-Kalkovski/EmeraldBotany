namespace EmeraldBotany.Web.Controllers
{
    using System;
    using System.Diagnostics;
    using System.Linq;
    using EmeraldBotany.Web.TrefleOpenAPIService;
    using EmeraldBotany.Web.ViewModels;

    using Microsoft.AspNetCore.Mvc;
    using Microsoft.VisualBasic.FileIO;

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

        [HttpPost]
        public ActionResult Index(HttpPostedFileBase file)
        {
            using (TextFieldParser parser = new TextFieldParser(@"C:\Users\Smiley\Desktop\TakingStuffHelper\TakingStuffHelper\species.csv"))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");

                while (!parser.EndOfData)
                {
                    //Processing row
                    string[] fields = parser.ReadFields();
                    foreach (var field in fields)
                    {
                        var row = field.Split("\t", StringSplitOptions.RemoveEmptyEntries).ToArray();
                        Console.WriteLine(row[1]);
                        break;
                    }
                }
            }
        }
    }
}
