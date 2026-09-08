namespace CS1302.Lab12.StacksQueues.Models;

public class PrintQueueSimulator
{
    private readonly Queue<string> _jobs = new Queue<string>();

    public int PendingCount => _jobs.Count;

    public void Enqueue(string jobName)
    {
        _jobs.Enqueue(jobName);
    }

    public string ProcessNext()
    {
        if (_jobs.Count == 0)
        {
            throw new InvalidOperationException("No jobs to process.");
        }

        return _jobs.Dequeue();
    }
}
