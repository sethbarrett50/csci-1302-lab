namespace CS1302.Lab17.Exceptions.Models;

public static class SafeCalculator
{
    public static int Calculate(int left, int right, string operatorSymbol)
    {
        switch (operatorSymbol)
        {
            case "+":
                return left + right;
            case "-":
                return left - right;
            case "*":
                return left * right;
            case "/":
                return left / right;
            default:
                throw new InvalidOperatorException($"Unrecognized operator: \"{operatorSymbol}\".");
        }
    }
}
