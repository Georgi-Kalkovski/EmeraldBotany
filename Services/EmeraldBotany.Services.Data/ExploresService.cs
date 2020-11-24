namespace EmeraldBotany.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;

    using EmeraldBotany.Data.Common.Repositories;
    using EmeraldBotany.Data.Models;
    using EmeraldBotany.Services.Mapping;

    public class ExploresService : IExploresService
    {
        private readonly IRepository<Species> repository;

        public ExploresService(IRepository<Species> repository)
        {
            this.repository = repository;
        }

        public int GetCount()
        {
            return this.repository.AllAsNoTracking().Count();
        }

        public IEnumerable<T> GetAll<T>()
        {
            return this.repository.All().To<T>().ToList();
        }
    }
}
