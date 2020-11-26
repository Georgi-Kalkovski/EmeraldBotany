namespace EmeraldBotany.Services.Data
{
    using System.Collections.Generic;
    using System.IO;
    using System.IO.Compression;
    using System.Threading.Tasks;

    using EmeraldBotany.Data.Common.Repositories;
    using EmeraldBotany.Data.Models;
    using Microsoft.VisualBasic.FileIO;

    public class UploadDatabaseService : IUploadDatabaseService
    {
        private readonly IDeletableEntityRepository<Species> speciesRepo;

        public UploadDatabaseService(
            IDeletableEntityRepository<Species> speciesRepo)
        {
            this.speciesRepo = speciesRepo;
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

                if (counter == 0)
                {
                    counter++;
                    continue;
                }

                counter++;

                var links = new Links
                {
                    UrlUsda = row[45],
                    UrlTropicos = row[46],
                    UrlTelaBotanica = row[47],
                    UrlPowo = row[48],
                    UrlPlantnet = row[49],
                    UrlGbif = row[50],
                    UrlOpenfarm = row[51],
                    UrlCatminat = row[52],
                    UrlWikipediaEn = row[53],
                };

                var images = new Images
                {
                    ImageUrl = row[10].Split(','),
                };

                var flowers = new Flower
                {
                    Color = new Color { Colors = row[11].Split(',') },
                    Conspicuous = bool.Parse(row[12]),
                };

                var foliage = new Foliage
                {
                    Color = new Color { Colors = row[11].Split(',') },
                    LeafRetention = bool.Parse(row[12]),
                    Texture = row[14],
                };

                var fruitOrSeed = new FruitOrSeed
                {
                    Color = new Color { Colors = row[11].Split(',') },
                    Conspicuous = bool.Parse(row[12]),
                };

                var specifications = new Specifications
                {
                    GrowthForm = row[20],
                    GrowthHabit = row[21],
                    GrowthRate = row[23],
                    AverageHeight = new AverageHeight { Cm = int.Parse(row[32]) },
                    MaximumHeight = new MaximumHeight { Cm = int.Parse(row[33]) },
                };

                var growths = new Growth
                {
                    DaysToHarvest = double.Parse(row[37]),
                    Description = row[38],
                    Sowing = row[39],
                    PhMaximum = double.Parse(row[35]),
                    PhMinimum = double.Parse(row[36]),
                    Light = int.Parse(row[27]),
                    AtmosphericHumidity = int.Parse(row[31]),
                    SoilNutriments = int.Parse(row[28]),
                    SoilSalinity = int.Parse(row[29]),
                    RowSpacing = new RowSpacing { Cm = double.Parse(row[40]) },
                    Spread = new Spread { Cm = double.Parse(row[41]) },
                    MinimumRootDepth = new MinimumRootDepth { Cm = double.Parse(row[34]) },
                    GrowthMonths = row[22].Split(','),
                    BloomMonths = row[18].Split(','),
                    FruitMonths = row[17].Split(','),
                };

                var synonyms = new Synonyms
                {
                    Author = row[6],
                    Name = row[8],
                };

                var species = new Species
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
                    Links = links,
                    Distributions = row[43].Split(','),
                    Images = images,
                    Flower = flowers,
                    Foliage = foliage,
                    FruitOrSeed = fruitOrSeed,
                    Specifications = specifications,
                    Growth = growths,
                    EdibleParts = row[24].Split(','),
                    Synonyms = new List<Synonyms>() { synonyms },
                    CommonNames = row[8].Split(','),
                };

                await this.speciesRepo.AddAsync(species);

                await this.speciesRepo.SaveChangesAsync();
            }
        }
    }
}
