Console.WriteLine("Skok do výšky");

Console.Write("Zajdete počet soutěžících: ");
int soutezici = int.Parse(Console.ReadLine());

double best = 0;

for (int i = 1; i <= soutezici; i++)
{
    Console.Write("Zadejte výšku skoku {0}. soutěžícího: ", i);

    double skok = double. Parse(Console.ReadLine());
    if (best < skok)
    {
        best = skok;
    }
}

Console.WriteLine("Nejlepší skok je: " + best);
Console.WriteLine();