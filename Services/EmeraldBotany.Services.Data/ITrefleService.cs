namespace EmeraldBotany.Services.Data
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using EmeraldBotany.Data.Models;

    public interface ITrefleService
    {
        public Task<ICollection<Species>> GetPlantsAsync();
    }
}
