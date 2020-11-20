namespace EmeraldBotany.Data.Seeding
{
    using System;
    using System.Threading.Tasks;

    using EmeraldBotany.Data.Models;
    using Microsoft.VisualBasic.FileIO;

    internal class SpeciesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            //if (dbContext.Species.Any())
            //{
            //    return;
            //}

            TextFieldParser parser = new TextFieldParser(@"C:\Users\Smiley\Desktop\species.csv");
            parser.TextFieldType = FieldType.Delimited;
            parser.SetDelimiters("\t");

            // while (!parser.EndOfData)
            while (!parser.EndOfData)
            {
                // Processing row
                string[] fields = parser.ReadFields();

                await dbContext.Species.AddAsync(new Species
                {
                    CommonName = fields[8],
                    ScientificName = fields[1],
                    Year = int.Parse(fields[5]),
                    Bibliography = fields[7],
                    Author = fields[6],
                    FamilyCommonName = fields[9],
                    Family = fields[4],
                    Genus = fields[3],
                    ImageUrl = fields[10],
                    Vegetable = bool.Parse(fields[25]),
                });
            }
        }
    }
}