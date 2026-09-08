using CS1302.Lab16.FileIO.Models;
using Xunit;

namespace CS1302.Labs.Tests;

public class Lab16_FileIO_Tests
{
    [Fact]
    public void ReadRoster_Returns_Empty_When_File_Missing()
    {
        string missingPath = Path.Combine(
            Path.GetTempPath(),
            $"cs1302-missing-{Guid.NewGuid()}.csv"
        );

        List<StudentRecord> records = RosterProcessor.ReadRoster(missingPath);

        Assert.Empty(records);
    }

    [Fact]
    public void ReadRoster_Parses_Valid_Lines_And_Skips_Bad_Ones()
    {
        string path = Path.Combine(Path.GetTempPath(), $"cs1302-roster-{Guid.NewGuid()}.csv");
        File.WriteAllLines(path, new[] { "Alex,88", "", "BadLine", "Bailey,95" });

        try
        {
            List<StudentRecord> records = RosterProcessor.ReadRoster(path);

            Assert.Equal(2, records.Count);
            Assert.Equal("Alex", records[0].Name);
            Assert.Equal(88.0, records[0].Score);
            Assert.Equal("Bailey", records[1].Name);
            Assert.Equal(95.0, records[1].Score);
        }
        finally
        {
            File.Delete(path);
        }
    }

    [Fact]
    public void WriteSummaryReport_Writes_Scores_And_Average()
    {
        List<StudentRecord> records = new List<StudentRecord>
        {
            new StudentRecord("Alex", 80.0),
            new StudentRecord("Bailey", 100.0),
        };

        string path = Path.Combine(Path.GetTempPath(), $"cs1302-summary-{Guid.NewGuid()}.txt");

        try
        {
            RosterProcessor.WriteSummaryReport(path, records);
            string content = File.ReadAllText(path);

            Assert.Contains("Alex: 80.0", content);
            Assert.Contains("Bailey: 100.0", content);
            Assert.Contains("Class average: 90.0", content);
        }
        finally
        {
            File.Delete(path);
        }
    }

    [Fact]
    public void WriteSummaryReport_Handles_Empty_Roster()
    {
        string path = Path.Combine(Path.GetTempPath(), $"cs1302-empty-{Guid.NewGuid()}.txt");

        try
        {
            RosterProcessor.WriteSummaryReport(path, new List<StudentRecord>());
            string content = File.ReadAllText(path);

            Assert.Contains("No records found.", content);
        }
        finally
        {
            File.Delete(path);
        }
    }
}
