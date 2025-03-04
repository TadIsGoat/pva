int [,] pole = new int [3,4];

Random random = new Random();

int maxHodnota = int.MinValue;

Console.WriteLine("Vícerozměrné hodnot: ");

for (int i = 0; i < pole.GetLength(0); i++)
{
    for (int j = 0; j < pole.GetLength(1); j++)
    {
        pole[i, j] = random.Next(-100, 100);
        Console.Write($"{pole[i, j]} \t");
        if (pole[i,j] > maxHodnota)
        {
            maxHodnota = pole[i,j];
        }
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine($"Maximum: {maxHodnota}");