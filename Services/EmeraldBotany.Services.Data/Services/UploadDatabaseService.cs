namespace EmeraldBotany.Services.Data
{
    using System.Collections.Generic;
    using System.IO;
    using System.IO.Compression;
    using EmeraldBotany.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.VisualBasic.FileIO;

    public class UploadDatabaseService : IUploadDatabaseService
    {
        private readonly DbContext db;

        public UploadDatabaseService(DbContext db)
        {
            this.db = db;
        }

        public void PopulateDatabaseWithPlants()
        {
            if (!File.Exists(@"..\..\..\..\..\Materials\species.csv"))
            {
                string zipPath = @"..\..\..\..\..\Materials\species.zip";
                string extractPath = @"..\..\..\..\..\Materials";
                ZipFile.ExtractToDirectory(zipPath, extractPath);
            }

            var list = new List<string[]>();

            using (TextFieldParser parser = new TextFieldParser(@"..\..\..\..\..\species.csv"))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters("\t");

                var counter = 0;

                while (!parser.EndOfData && counter != 10)
                {
                    // Processing row
                    string[] row = parser.ReadFields();
                    list.Add(row);
                    counter++;

                    var species = new Species
                    {
                        Id = int.Parse(row[0]),
                        ScientificName = row[1],
                        Genus = row[3],
                        Family = row[4],
                        Year = int.Parse(row[5]),
                        Author = row[3],
                        AuthorId = row[3],
                        FlowerId = row[3],
                        FoliageId = row[3],
                        FruitOrSeedId = row[3],
                        SpecificationsId = row[3],
                        GrowthId = row[3],
                        DistributionId = row[3],
                        LinksId = row[3],
                        Links = new Links(row[3].Split()),
                        Distribution = row[3],
                        Images = row[3],
                        Flower = row[3],
                        Foliage = row[3],
                        FruitOrSeed = row[3],
                        Specifications = row[3],
                        Growth = row[3],
                        Rank = row[3],
                        Status = row[3],
                        Duration = row[3],
                        EdiblePart = row[3],
                        Synonyms = row[3],
                        Sources = row[3],
                        CommonNames = row[3],
                        Distributions = row[3],
                    };
                }
            }
        }
    }
}
