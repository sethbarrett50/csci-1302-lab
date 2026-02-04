namespace CS1302.Common;

public readonly record struct Result(bool IsSuccess, string? Error)
{
    public static Result Success() => new(true, null);

    public static Result Fail(string error)
    {
        error = Guard.NotNullOrWhiteSpace(error, nameof(error));
        return new(false, error);
    }

    public override string ToString() => IsSuccess ? "Success" : $"Fail: {Error}";
}

public readonly record struct Result<T>(bool IsSuccess, T? Value, string? Error)
{
    public static Result<T> Success(T value)
    {
        if (value is null)
        {
            throw new ArgumentNullException(nameof(value));
        }

        return new(true, value, null);
    }

    public static Result<T> Fail(string error)
    {
        error = Guard.NotNullOrWhiteSpace(error, nameof(error));
        return new(false, default, error);
    }

    public override string ToString() => IsSuccess ? $"Success: {Value}" : $"Fail: {Error}";
}
