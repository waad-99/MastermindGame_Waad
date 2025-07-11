using System.Linq;

public static class InputValidator
{
    public static bool IsValid(string input)
    {
        if (input.Length != 4) return false;
        foreach (char c in input)
            if (c < '0' || c > '8') return false;

        return input.Distinct().Count() == 4;
    }
}