namespace EmeraldBotany.Services.Data
{
    using System;
    using System.Collections;
    using System.IO;
    using System.IO.Compression;
    using System.Linq;
    using System.Threading.Tasks;

    using EmeraldBotany.Data.Common.Repositories;
    using EmeraldBotany.Data.Models;
    using EmeraldBotany.Data.Models.Enums;
    using EmeraldBotany.Web.ViewModel;
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

        public async void PopulateDatabaseWithPlants()
        {
            if (!File.Exists(Path.GetFullPath(@"..\..\Materials\species.csv")))
            {
                string zipPath = Path.GetFullPath(@"..\..\Materials\species.zip");
                string extractPath = Path.GetFullPath(@"..\..\Materials");
                await Task.Run(() => ZipFile.ExtractToDirectory(zipPath, extractPath));
            }

            TextFieldParser parser = new TextFieldParser(Path.GetFullPath(@"..\..\Materials\species.csv"))
            {
                TextFieldType = FieldType.Delimited,
            };
            parser.SetDelimiters("\t");

            var counter = 0;

            while (!parser.EndOfData && counter != 10)
            {
                // Processing row
                string[] row = parser.ReadFields();
                counter++;

                var species = new CreateSpeciesInputModel
                {
                    Id = int.Parse(row[0]),
                    ScientificName = row[1],
                    Rank = row[2],
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
                    //EdiblePart =(EdiblePartEnum) Enum.Parse(typeof(EdiblePartEnum), row[24].Split(",")), 
                };

                //await this.speciesRepo.AddAsync(species);

                await this.speciesRepo.SaveChangesAsync();
            }
        }
    }
}
