using System;
using static GetData.GetData;
using GetData;

using System.IO;
using Microsoft.VisualStudio.TextTemplating;

class Program
{
    static void Main(string[] args)
    {
        // Set the path to the template file
        var templatePath = @"path/to/CsvGenerator.tt";

        // Create a new instance of the TextTransformation class
        var transformation = new Engine()
            .CreateTransformation(templatePath);

        // Set the output path for the generated CSV file
        var outputPath = @"path/to/output.csv";

        // Set the host of the TextTransformation
        var host = new TextTemplatingSession();

        // Generate the CSV file using the template
        var result = transformation.TransformText();

        // Write the generated CSV file to disk
        File.WriteAllText(outputPath, result);

        Console.WriteLine($"CSV file generated at {outputPath}");
    }

}
