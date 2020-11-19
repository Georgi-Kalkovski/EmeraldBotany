using System;
using System.Collections.Generic;
using System.Linq;

namespace EmeraldBotany.Common
{
    public class FileSeeder
    {
        public static void Seeder()
        {


            var list = new List<string>();

            using (TextFieldParser parser = new TextFieldParser(@"C:\Users\Smiley\Desktop\species.csv"))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");

                while (!parser.EndOfData)
                {
                    //Processing row
                    string[] fields = parser.ReadFields();
                    foreach (var row in fields)
                    {
                        var element = row.Split("\t", StringSplitOptions.RemoveEmptyEntries).ToArray();
                        Console.WriteLine(element[1]);
                        list.Add(element[1]);
                        break;
                    }
                }
            }
        }
    }
}
