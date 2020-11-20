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
                parser.SetDelimiters("\t");

                var list = new List<string[]>();

                while (!parser.EndOfData)
                {
                    //Processing row
                    string[] row = parser.ReadFields();
                    list.Add(row);
                }
            }
        }
    }
}
