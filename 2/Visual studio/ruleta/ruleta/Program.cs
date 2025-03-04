Console.WriteLine("Program ruleta");
Console.WriteLine("Hoďte kuličkou stisknutím ENTER, ukončete zápisem konec");
start:

string konec = Console.ReadLine();

if (konec != "konec")
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Hoď kuličkou!");


    int cislo;
    Random random1 = new Random();
    cislo = random1.Next(0, 38);

    if (cislo % 2 == 0 && cislo != 0)
    {
        Console.ForegroundColor= ConsoleColor.Red;
        Console.WriteLine("Losované číslo je: " + cislo);
    }
    if (cislo == 0)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Losované číslo je: " + cislo);
    }
    if(cislo % 2 != 0)
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Losované číslo je: " + cislo);
    }
    goto start;

}