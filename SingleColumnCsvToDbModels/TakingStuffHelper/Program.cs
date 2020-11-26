using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;

namespace TakingStuffHelper
{
    public class Program
    {
        static void Main(string[] args)
        {
            if (!File.Exists(@"..\..\..\..\..\Materials\species.csv"))
            {
                string zipPath = @"..\..\..\..\..\Materials\species.zip";
                string extractPath = @"..\..\..\..\..\Materials";
                ZipFile.ExtractToDirectory(zipPath, extractPath);
            }
            using (TextFieldParser parser = new TextFieldParser(@"..\..\..\..\..\Materials\species.csv"))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters("\t");

                var list = new List<string[]>();
                var counter = 0;
                while (!parser.EndOfData && counter != 10)
                {
                    //Processing row
                    string[] row = parser.ReadFields();
                    list.Add(row);
                    foreach (var id in row)
                    {
                        Console.WriteLine(id);
                    }
                    counter++;
                    Console.WriteLine("-----------------------------NEW ------------------------------");
                }
            }
        }
    }
}
