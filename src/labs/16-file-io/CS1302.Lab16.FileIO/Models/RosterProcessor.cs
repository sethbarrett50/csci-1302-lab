namespace CS1302.Lab16.FileIO.Models;

public static class RosterProcessor
{
    public static List<StudentRecord> ReadRoster(string path)
    {
        List<StudentRecord> records = new List<StudentRecord>();

        if (!File.Exists(path))
        {
            return records;
        }

        string[] lines = File.ReadAllLines(path);
        foreach (string line in lines)
        {
            if (string.IsNullOrWhiteSpace(line))
            {
                continue;
            }

            string[] parts = line.Split(',');
            if (parts.Length != 2)
            {
                continue;
            }

            string name = parts[0].Trim();
            if (double.TryParse(parts[1].Trim(), out double score))
            {
                records.Add(new StudentRecord(name, score));
            }
        }

        return records;
    }

    public static void WriteSummaryReport(string path, List<StudentRecord> records)
    {
        using (StreamWriter writer = new StreamWriter(path, append: false))
        {
            if (records.Count == 0)
            {
                writer.WriteLine("No records found.");
                return;
            }

            double total = 0.0;
            foreach (StudentRecord record in records)
            {
                writer.WriteLine($"{record.Name}: {record.Score:F1}");
                total += record.Score;
            }

            double average = total / records.Count;
            writer.WriteLine($"Class average: {average:F1}");
        }
    }
}
