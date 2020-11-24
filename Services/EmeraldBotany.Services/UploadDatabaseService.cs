namespace EmeraldBotany.Services
{
    using System.Collections.Generic;
    using System.IO;
    using System.IO.Compression;

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
            else
            {
                System.Console.WriteLine("ERROR");
                return;
            }

            using (TextFieldParser parser = new TextFieldParser(@"\species.csv"))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters("\t");

                var list = new List<string[]>();

                var counter = 0;

                while (!parser.EndOfData || counter != 10)
                {
                    // Processing row
                    string[] row = parser.ReadFields();
                    list.Add(row);
                    counter++;
                }
            }
        }
    }
}
