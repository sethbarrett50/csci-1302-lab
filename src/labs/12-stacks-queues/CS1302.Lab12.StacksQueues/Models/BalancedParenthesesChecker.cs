namespace CS1302.Lab12.StacksQueues.Models;

public static class BalancedParenthesesChecker
{
    private static readonly Dictionary<char, char> ClosingToOpening = new Dictionary<char, char>
    {
        [')'] = '(',
        [']'] = '[',
        ['}'] = '{',
    };

    public static bool IsBalanced(string expression)
    {
        Stack<char> openBrackets = new Stack<char>();

        foreach (char c in expression)
        {
            if (c == '(' || c == '[' || c == '{')
            {
                openBrackets.Push(c);
            }
            else if (ClosingToOpening.TryGetValue(c, out char expectedOpening))
            {
                if (openBrackets.Count == 0 || openBrackets.Pop() != expectedOpening)
                {
                    return false;
                }
            }
        }

        return openBrackets.Count == 0;
    }
}
