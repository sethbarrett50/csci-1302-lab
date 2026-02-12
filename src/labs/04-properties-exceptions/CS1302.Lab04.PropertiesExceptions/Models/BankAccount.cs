namespace CS1302.Lab04.PropertiesExceptions.Models;

public class BankAccount
{
    public BankAccount(string owner, decimal startingBalance)
    {
        Owner = string.IsNullOrWhiteSpace(owner)
            ? throw new ArgumentException("Owner must not be empty.", nameof(owner))
            : owner;

        if (startingBalance < 0m)
        {
            throw new ArgumentOutOfRangeException(
                nameof(startingBalance),
                "Starting balance cannot be negative."
            );
        }

        Balance = startingBalance;
    }

    public string Owner { get; }

    public decimal Balance { get; private set; }

    public void Deposit(decimal amount)
    {
        if (amount <= 0m)
        {
            throw new ArgumentOutOfRangeException(
                nameof(amount),
                "Deposit amount must be greater than 0."
            );
        }

        Balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0m)
        {
            throw new ArgumentOutOfRangeException(
                nameof(amount),
                "Withdraw amount must be greater than 0."
            );
        }

        if (amount > Balance)
        {
            throw new InvalidOperationException("Insufficient funds.");
        }

        Balance -= amount;
    }

    public override string ToString()
    {
        return $"{Owner}: ${Balance:F2}";
    }
}
