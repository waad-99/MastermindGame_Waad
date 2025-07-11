using System;

class Program
{
    static void Main(string[] args)
    {
        string code = null;
        int attempts = 10;

        for (int i = 0; i < args.Length - 1; i++)
        {
            if (args[i] == "-c") code = args[i + 1];
            if (args[i] == "-t") int.TryParse(args[i + 1], out attempts);
        }

        Game game = new Game(code, attempts);
        game.Start();
    }
}