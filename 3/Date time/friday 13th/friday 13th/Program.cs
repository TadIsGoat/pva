Console.WriteLine("Zadejte interval datumů: ");
Console.Write("1. datum: ");
DateTime datum1 = DateTime.Parse(Console.ReadLine());
Console.Write("2. datum: ");
DateTime datum2 = DateTime.Parse(Console.ReadLine());

Console.Write("\nPátky 13.: ");
do
{
    if ((datum1.Day == 13) && (datum1.DayOfWeek == DayOfWeek.Friday))
    {
        Console.Write($"{datum1.ToShortDateString()}, ");
    }
    datum1 = datum1.AddDays(1);
} while (datum1 <= datum2);