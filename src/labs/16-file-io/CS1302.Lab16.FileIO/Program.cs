using CS1302.Lab16.FileIO.Models;

namespace CS1302.Lab16.FileIO;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("== File I/O Practice ==");
        Console.WriteLine();

        string inputPath = Path.Combine(Path.GetTempPath(), "cs1302-lab16-roster.csv");
        string outputPath = Path.Combine(Path.GetTempPath(), "cs1302-lab16-summary.txt");

        File.WriteAllLines(inputPath, new[] { "Alex,88", "Bailey,95", "Casey,72" });

        List<StudentRecord> roster = RosterProcessor.ReadRoster(inputPath);
        RosterProcessor.WriteSummaryReport(outputPath, roster);

        Console.WriteLine($"Wrote summary to: {outputPath}");
        Console.WriteLine();
        Console.WriteLine(File.ReadAllText(outputPath));
    }
}
