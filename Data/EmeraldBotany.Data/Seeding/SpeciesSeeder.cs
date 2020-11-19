using EmeraldBotany.Data;
using EmeraldBotany.Data.Models;
using EmeraldBotany.Data.Seeding;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmeraldBotany.Services.Data
{
    public class SpeciesSeeder : ISeeder
    {
        static async Task SeederAsync()
        {
            using (TextFieldParser parser = new TextFieldParser(@"C:\Users\Smiley\Desktop\TakingStuffHelper\TakingStuffHelper\Materials\species.csv"))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");

                var list = new List<string[]>();

                while (!parser.EndOfData)
                {

                    // Processing row
                    string[] fields = parser.ReadFields();
                    for (int row = 0; row < fields.Length - 1;)
                    {
                        var col = fields[row].Split("\t").ToArray();
                        list.Add(col);
                        row++;
                        break;
                    }
                }
            }
        }

        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Settings.Any())
            {
                return;
            }

            //await dbContext.Settings.AddAsync(new Species { Name = "Setting1", Value = "value1" });
        }
    }
}
