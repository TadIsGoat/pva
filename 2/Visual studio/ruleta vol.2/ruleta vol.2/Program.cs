Console.WriteLine("Program ruleta");
Console.WriteLine("Program ukončíte zápisem: konec");
string konec = Console.ReadLine();

start:
if (konec != "konec")
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("Zadejte číslo v rozmezí 0 - 37");
    int sazka = int.Parse(Console.ReadLine());

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine();
    Console.WriteLine("Hoď kuličkou!");
    Console.WriteLine();

    int cislo;
    Random random1 = new Random();
    cislo = random1.Next(0, 38);

    if (cislo % 2 == 0 && cislo != 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Losované číslo je: " + cislo);
    }
    if (cislo == 0)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Losované číslo je: " + cislo);
    }
    if (cislo % 2 != 0)
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Losované číslo je: " + cislo);
    }

    Console.ForegroundColor= ConsoleColor.White;

    if (sazka == cislo)
    {
        Console.WriteLine("Gratuluji, vyhrál jsi!");
    }
    if (sazka != cislo)
    {
        Console.WriteLine("Bohužel, prohrál jsi!");
    }

    Console.WriteLine("Chceš hrát znovu?");
    string odpoved = Console.ReadLine();

    if (odpoved == "ano")
    {
        goto start;
    }
    
    

}