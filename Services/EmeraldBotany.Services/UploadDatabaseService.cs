using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using Microsoft.VisualBasic.FileIO;

namespace EmeraldBotany.Services
{
    public class UploadDatabaseService : IUploadDatabaseService
    {
        public UploadDatabaseService()
        {
        }

        public void PopulateDatabaseWithPlants()
        {
            if (!File.Exists(@"..\..\..\..\..\Materials\species.csv"))
            {
                string zipPath = @"..\..\..\..\..\Materials\species.zip";
                string extractPath = @"..\..\..\..\..\Materials";
                ZipFile.ExtractToDirectory(zipPath, extractPath);
            }

            using (TextFieldParser parser = new TextFieldParser(@"\species.csv"))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters("\t");

                var list = new List<string[]>();

                var counter = 0;

                while (!parser.EndOfData || counter != 10)
                {
                    //Processing row
                    string[] row = parser.ReadFields();
                    list.Add(row);
                    counter++;
                }
            }
        }
    }
}
