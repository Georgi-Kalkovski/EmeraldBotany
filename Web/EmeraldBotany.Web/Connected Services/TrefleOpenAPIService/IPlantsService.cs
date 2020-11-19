using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmeraldBotany.Web.TrefleOpenAPIService
{
    public interface IPlantsService
    {
        public Task<List<Species>> GetPlantsAsync();
    }
}
