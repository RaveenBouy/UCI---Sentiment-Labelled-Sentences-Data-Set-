using System;
using System.Collections.Generic;
using System.IO;

namespace ToCSVConverter
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            var inputFile = "text.txt"; //Input .txt File
            var outputFile = "text.csv"; //Output .csv File

            var stringList = new List<string>();
            var linesRead = await File.ReadAllLinesAsync(Path.Combine(Environment.CurrentDirectory, inputFile));

            foreach (var str in linesRead)
            {
                var str2 = $@"""{str.Substring(0, (str.Length - 1))}"", {str.Substring((str.Length - 1), 1)}";
                stringList.Add(str2);
            }

            File.WriteAllLines(Path.Combine(Environment.CurrentDirectory, outputFile), stringList);
        }
    }
}
