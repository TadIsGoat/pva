Console.WriteLine("čísla od 1 - n, vypisuje pouze sudá: ");

int velikostPole = Convert.ToInt32(Console.ReadLine());

int[] pole = new int[velikostPole];

Console.WriteLine("Sudá čísla:");
for (int i = 0; i < pole.Length; i++)
{
    pole[i] = i + 1;
    if (pole[i] % 2 == 0)
    {
        Console.Write("{0} ", pole[i]);
    }
}

Console.WriteLine();
Console.Write("Zadejte počet čísel: ");
int vstup = int.Parse(Console.ReadLine());

int[] cisla = new int[vstup];

for (int i = 0; i < cisla.Length; i++)
{
    Console.Write("Zadej číslo: ");
    cisla[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Max číslo: " + cisla.Max());
Console.WriteLine("Min číslo: " + cisla.Min());
Console.WriteLine("\n pole:");

for (int i = 0; i < cisla.Length; i++)
{
    cisla[i] = i + 1;
    Console.Write("{0} ", cisla[i]);
}