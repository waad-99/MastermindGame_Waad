using System;

public class Game
{
    private string secretCode;
    private int maxAttempts;

    public Game(string code, int attempts)
    {
        secretCode = code ?? CodeGenerator.GenerateCode();
        maxAttempts = attempts;
    }

    public void Start()
    {
        Console.WriteLine("Can you break the code? Enter a valid guess.");

        for (int round = 0; round < maxAttempts; round++)
        {
            Console.WriteLine($"---\nRound {round}");
            Console.Write(">");

            string input = Console.ReadLine();
            if (input == null) return;

            if (!InputValidator.IsValid(input))
            {
                Console.WriteLine("Wrong input!");
                round--;
                continue;
            }

            if (input == secretCode)
            {
                Console.WriteLine("Congratz! You did it!");
                return;
            }

            var result = GuessEvaluator.Evaluate(secretCode, input);
            Console.WriteLine($"Well placed pieces: {result.wellPlaced}");
            Console.WriteLine($"Misplaced pieces: {result.misplaced}");
        }
    }
}