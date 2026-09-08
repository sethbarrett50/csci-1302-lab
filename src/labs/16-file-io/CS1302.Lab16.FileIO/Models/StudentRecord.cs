namespace CS1302.Lab16.FileIO.Models;

public class StudentRecord
{
    public string Name { get; }
    public double Score { get; }

    public StudentRecord(string name, double score)
    {
        Name = name;
        Score = score;
    }
}
