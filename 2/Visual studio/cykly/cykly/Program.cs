Console.WriteLine("Můžete vkládat známky");

while (true)
{
    Console.Write("Zadej známku: ");
    int znamka = int.Parse(Console.ReadLine());

    if ((znamka <= 0) || (znamka >= 6))
    {
        Console.WriteLine("Špatně zadaná známka.");
        break;
    }
}

Console.ReadLine();


/*proměnné*/
string cislo;
int znamka1 = 0;
int znamka2 = 0;
int znamka3 = 0;
int znamka4 = 0;
int znamka5 = 0;

Console.WriteLine("Počítač množství známek");
do
{
    Console.Write("Zadej známku: ");
    cislo = Console.ReadLine();

    switch (cislo)
    {
        case "1":
            znamka1 += 1;
            break;

        case "2":
            znamka2 += 1;
            break;

        case "3":
            znamka3 += 1;
            break;

        case "4":
            znamka4 += 1;
            break;

        case "5":
            znamka5 += 1;
            break;
    }
} while (cislo != "0");
Console.WriteLine();
Console.WriteLine("Počet 1: " + znamka1);
Console.WriteLine("Počet 2: " + znamka2);
Console.WriteLine("Počet 3: " + znamka3);
Console.WriteLine("Počet 4: " + znamka4);
Console.WriteLine("Počet 5: " + znamka5);
Console.WriteLine();

Console.Write("1: ");
for (int i = 0; i < znamka1; i++)
{
    Console.Write("*");
}

Console.Write("\n2: ");
for (int i = 0; i < znamka2; i++)
{
    Console.Write("*");
}

Console.Write("\n3: ");
for (int i = 0; i < znamka3; i++)
{
    Console.Write("*");
}

Console.Write("\n4: ");
for (int i = 0; i < znamka4; i++)
{
    Console.Write("*");
}

Console.Write("\n5: ");
for (int i = 0; i < znamka5; i++)
{
    Console.Write("*");
}

Console.ReadLine();
/*proměnné*/
int cislo2;
int max = int.MinValue;
int min = int.MaxValue;

Console.WriteLine();
Console.WriteLine("Maximální a minimální číslo");

do
{
    Console.Write("Zadej číslo: ");
    cislo2 = int.Parse(Console.ReadLine());
    if (cislo2 > max)
    {
        max = cislo2;
    }
    if ((cislo2 < min) && (cislo2 > 0))
    {
        min = cislo2;
    }

} while (cislo2 != 0);

Console.WriteLine("Maximální číslo: " + max);
Console.WriteLine("Minimální číslo: " + min);

Console.ReadLine();

/*proměnné*/
char pismeno;

while (true)
{
    Console.WriteLine("Chceš pokračovat? (a/A)");
    //pismeno = (char)int.Parse(Console.ReadLine());
    //pismeno = Convert.ToChar(Console.ReadLine());
    pismeno = Console.ReadKey().KeyChar;

    if (pismeno == 'a')
    {
        Console.WriteLine("Správná volba");
        break;
    }
}