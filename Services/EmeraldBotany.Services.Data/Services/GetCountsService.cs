namespace EmeraldBotany.Services.Data
{
    using System.Linq;

    using EmeraldBotany.Data.Common.Repositories;
    using EmeraldBotany.Data.Models;
    using EmeraldBotany.Web.ViewModels.Home;

    public class GetCountsService : IGetCountsService
    {
        private readonly IDeletableEntityRepository<Plant> plantsRepo;
        private readonly IDeletableEntityRepository<Species> speciesRepo;
        private readonly IDeletableEntityRepository<Growth> growthsRepo;
        private readonly IDeletableEntityRepository<Images> imagesRepo;
        private readonly IDeletableEntityRepository<Distributions> distributionsRepo;
        private readonly IDeletableEntityRepository<Specifications> specificationsRepo;

        public GetCountsService(
            IDeletableEntityRepository<Plant> plantsRepo,
            IDeletableEntityRepository<Species> speciesRepo,
            IDeletableEntityRepository<Growth> growthsRepo,
            IDeletableEntityRepository<Images> imagesRepo,
            IDeletableEntityRepository<Distributions> distributionsRepo,
            IDeletableEntityRepository<Specifications> specificationsRepo)
        {
            this.plantsRepo = plantsRepo;
            this.speciesRepo = speciesRepo;
            this.growthsRepo = growthsRepo;
            this.imagesRepo = imagesRepo;
            this.distributionsRepo = distributionsRepo;
            this.specificationsRepo = specificationsRepo;
        }

        public IndexViewModel GetCounts()
        {
            var data = new IndexViewModel
            {
                PlantsCount = this.plantsRepo.All().Count(),
                SpeciesCount = this.speciesRepo.All().Count(),
                GrowthCount = this.growthsRepo.All().Count(),
                ImagesCount = this.imagesRepo.All().Count(),
                DistributionsCount = this.distributionsRepo.All().Count(),
                SpecificationsCount = this.specificationsRepo.All().Count(),
            };

            return data;
        }
    }
}
