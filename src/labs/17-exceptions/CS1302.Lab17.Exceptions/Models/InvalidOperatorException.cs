namespace CS1302.Lab17.Exceptions.Models;

public class InvalidOperatorException : Exception
{
    public InvalidOperatorException(string message)
        : base(message) { }
}
