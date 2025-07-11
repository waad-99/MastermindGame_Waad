public static class GuessEvaluator
{
    public static (int wellPlaced, int misplaced) Evaluate(string code, string guess)
    {
        int well = 0, misplaced = 0;

        for (int i = 0; i < 4; i++)
            if (guess[i] == code[i]) well++;

        foreach (char c in guess)
            if (code.Contains(c)) misplaced++;

        misplaced -= well;
        return (well, misplaced);
    }
}