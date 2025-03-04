Menu();

static void Menu();
{
    Console.WriteLine("Zvolte hru:");
    Console.WriteLine("1 - Hádej číslo");
    Console.WriteLine("1 - Hádej slovo");
    Console.WriteLine("3 - Konec");
    Console.Write("Zadejte číslo: ");
    int volba = Convert.ToInt32(Console.ReadLine());

    switch (volba)
    {
        case 1:
            HadejCislo();
            break;
        case 2:
            HadejSlovo();
            break;
        case 3:
            Console.WriteLine("Konec programu");
            Environment.ExitCode = 0;
            break;
        default:
            Console.Clear();
            Console.WriteLine("Neplatná volba");
            Menu();
            break;
    }
}

static void HadejCislo()
{
    Random generator = new Random();
    int cislo = generator.Next(1, 11);
    int pokusy = 0;

    for (; ; )
    {
        Console.Write("Hádej čislo od 1 do 10: ");
        int hadaneCislo = Convert.ToInt32(Console.ReadLine());
        pokusy++;

        if (hadaneCislo < cislo)
        {
            Console.WriteLine("Tvé číslo je příliš nízké");
        }
        else if (hadaneCislo > cislo)
        {
            Console.WriteLine("Tvé číslo je příliš vysoké");
        }
        else
        {
            Console.WriteLine($"uhádl jsi číslo {cislo} se {pokusy} pokusy");
            Pokracovat();
        }
    }
}

static void HadejSlovo()
{
    string[] slova = { "jablko", "auto", "pes", "traktor", "strom" };
    Random generator = new Random();
    string hadaneSlovo = slova[generator.Next(slova.Length)];
    int pokusy = 0;

    Console.WriteLine($"Hádej slovo, které má {hadaneSlovo.Length} písmen");

    while (true)
    {
        Console.WriteLine("Slovo: ");
        string tipnuteSlovo = Console.ReadLine();
        pokusy++;
        if (tipnuteSlovo == hadaneSlovo)
        {
            Console.WriteLine($"Uhádl jsi slovo {hadaneSlovo} s {pokusy} pokusy");
        }
        else
            Console.WriteLine("Slovo není správné");
    }
}

static void Pokracovat()
{
    Console.WriteLine("Návrat do menu? [ano/ne]");
    string volba = Console.ReadLine().ToLower();
    if (volba == "ne")
    {
        Console.WriteLine("Konec programu");
        Environment.Exit(0);
    }
    else
    {
        Console.Clear();
        Menu();
    }
}