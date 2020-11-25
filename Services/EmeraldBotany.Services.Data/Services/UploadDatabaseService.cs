namespace EmeraldBotany.Services.Data
{
    using System;
    using System.IO;
    using System.IO.Compression;
    using System.Threading.Tasks;

    using EmeraldBotany.Data.Common.Repositories;
    using EmeraldBotany.Data.Models;
    using EmeraldBotany.Data.Models.Enums;
    using Microsoft.VisualBasic.FileIO;

    public class UploadDatabaseService : IUploadDatabaseService
    {
        private readonly IDeletableEntityRepository<Plant> plantsRepo;
        private readonly IDeletableEntityRepository<Species> speciesRepo;
        private readonly IDeletableEntityRepository<Growth> growthsRepo;
        private readonly IDeletableEntityRepository<Images> imagesRepo;
        private readonly IDeletableEntityRepository<Distributions> distributionsRepo;
        private readonly IDeletableEntityRepository<Specifications> specificationsRepo;

        public UploadDatabaseService(
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

        public async Task PopulateDatabaseWithPlants()
        {
            if (!File.Exists(@"..\..\..\..\..\Materials\species.csv"))
            {
                string zipPath = @"..\..\..\..\..\Materials\species.zip";
                string extractPath = @"..\..\..\..\..\Materials";
                ZipFile.ExtractToDirectory(zipPath, extractPath);
            }

            using TextFieldParser parser = new TextFieldParser(@"..\..\..\..\..\species.csv");
            parser.TextFieldType = FieldType.Delimited;
            parser.SetDelimiters("\t");

            var counter = 0;

            while (!parser.EndOfData && counter != 10)
            {
                // Processing row
                string[] row = parser.ReadFields();
                counter++;

                var species = new Species
                {
                    Id = int.Parse(row[0]),
                    ScientificName = row[1],
                    Rank = (SpeciesRankEnum)Enum.Parse(typeof(SpeciesRankEnum), row[2], true),
                    Genus = row[3],
                    Family = row[4],
                    Year = int.Parse(row[5]),
                    Author = row[6],
                    Bibliography = row[7],
                    CommonName = row[8],
                    FamilyCommonName = row[9],
                    ImageUrl = row[10],
                    Vegetable = bool.Parse(row[25]),
                    Links = new Links(),
                    Distribution = new Distributions(),
                    Images = new Images(),
                    Flower = new Flower(),
                    Foliage = new Foliage(),
                    FruitOrSeed = new FruitOrSeed(),
                    Specifications = new Specifications(),
                    Growth = new Growth(),
                };

                await this.speciesRepo.AddAsync(species);

                await this.speciesRepo.SaveChangesAsync();
            }
        }
    }
}
