using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakingStuffHelper
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (TextFieldParser parser = new TextFieldParser(@"C:\Users\Smiley\Desktop\species.csv"))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");

                var list = new List<string[]>();

                while (!parser.EndOfData)
                {
                    var sb = new StringBuilder();

                    //Processing row
                    string[] fields = parser.ReadFields();
                    for (int row= 0 ; row < fields.Length-1;)
                    {
                        var col = fields[row].Split("\t").ToArray();
                        foreach (var id in col)
                        {
                            sb.Append($"{id} ");
                        }
                        list.Add(col);
                        sb.AppendLine();

                        Console.WriteLine(sb.ToString());
                        row++;
                        break;
                    }
                }
            }
        }
    }
}
