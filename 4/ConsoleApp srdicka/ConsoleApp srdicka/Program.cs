List<string> results = new List<string>();

while (true)
{
    char[,] game =
    {
        {'.', '.', '.', '.', '.',},
        {'.', '.', '.', '.', '.',},
        {'.', '.', '.', '.', '.',},
        {'.', '.', '.', '.', '.',},
        {'.', '.', '.', '.', '.',},
    };

    int currentRow = 2;
    int currentCol = 2;
    int score = 0;
    int maxScore = 5;

    Console.WriteLine("Start the game by pressing <>^v");
    Heart(game);
    Render(game, currentRow, currentCol, score);
    Console.ReadKey();

    DateTime startTime = DateTime.Now;

    while (score < maxScore)
    {
        ConsoleKeyInfo key = Console.ReadKey();

        switch (key.Key)
        {
            case ConsoleKey.UpArrow:
                if (currentRow > 0)
                    currentRow--;
                break;
            case ConsoleKey.DownArrow:
                if (currentRow < game.GetLength(0) - 1)
                    currentRow++;
                break;
            case ConsoleKey.LeftArrow:
                if (currentCol > 0)
                    currentCol--;
                break;
            case ConsoleKey.RightArrow:
                if (currentCol < game.GetLength(1) - 1)
                    currentCol++;
                break;
        }

        if (game[currentRow, currentCol] == 'o')
        {
            score++;
            game[currentRow, currentCol] = '.';
            Heart(game);
        }

        Console.Clear();
        Render(game, currentRow, currentCol, score);
    }

    DateTime endTime = DateTime.Now;
    TimeSpan totalTime = endTime - startTime;

    Console.WriteLine($"You reached the score of {score} in {totalTime.TotalSeconds:N3}");
    Console.Write("Enter your nickname: ");
    results.Add(Console.ReadLine() + " - " + Math.Round(totalTime.TotalSeconds, 3));

    StreamWriter sw = new StreamWriter($"score.txt", true);
    foreach (var result in results)
    {
        sw.WriteLine(result);
    }
    sw.Close();

    Console.WriteLine("\nBest players: ");
    StreamReader sr = new StreamReader(@"score.txt");
    string output = sr.ReadToEnd();
    sr.Close();
    Console.WriteLine(output);
    Console.WriteLine("\nPress any key to play again");
    Console.ReadKey();
    Console.Clear();
}

void Heart(char[,] game)
{
    Random rnd = new Random();
    int row, col;

    do
    {
        row = rnd.Next(0, game.GetLength(0));
        col = rnd.Next(0, game.GetLength(1));
    } while (game[row, col] != '.');

    game[row, col] = 'o';
}

void Render(char[,] game, int currentRow, int currentCol, int score)
{
    Console.WriteLine();
    for (int i = 0; i < game.GetLength(0); i++)
    {
        for (int j = 0; j < game.GetLength(1); j++)
        {
            if (i == currentRow && j == currentCol)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("O ");
                Console.ResetColor();
            }
            else if (game[i, j] == 'o')
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("<3");
                Console.ResetColor();
            }
            else
            {
                Console.Write($"{game[i, j]} ");
            }
        }
        Console.WriteLine();
    }

    Console.WriteLine("Score: " + score);
}