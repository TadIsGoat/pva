Console.WriteLine("---Program pro výpočet vzorců 2.0---");
Console.Write("Zadej stranu a: ");
float a = float.Parse(Console.ReadLine());

Console.Write("Zadej stranu b: ");
float b = float.Parse(Console.ReadLine());

Console.Write("Zadej stranu c: ");
float c = float.Parse(Console.ReadLine());

float objemkrychle = a * a * a;
float povrchkrychle = a * a * 6;
float objemkvadru = a * b * c;
float povrchkvadru = 2 * (a * b + a * c + b * c);

Console.WriteLine();

if ((a == 0) || (b == 0) || (c == 0))
{
    Console.WriteLine("Nelze pokračovat, protože jedna z hodnot je rovna 0");
}
else
{
    Console.WriteLine("Početní operace: ");
    Console.WriteLine("1 - Výpočet objemu krychle");
    Console.WriteLine("2 - Výpočet povrchu krychle");
    Console.WriteLine("3 - Výpočet objemu kvádru");
    Console.WriteLine("4 - Výpočet povrchu kvádru");
    Console.WriteLine();

    Console.Write("Zvolte početní operaci: ");
    int volba = int.Parse(Console.ReadLine());

    if (volba == 1)
    {
        Console.WriteLine("1 - Výpočet objemu krychle");
        Console.WriteLine("Objem krychle je: " + objemkrychle);
    }
    else if (volba == 2)
    {
        Console.WriteLine("2 - Výpočet povrchu krychle");
        Console.WriteLine("Povrch krychle je: " + povrchkrychle);
    }
    else if (volba == 3)
    {
        Console.WriteLine("3 - Výpočet objemu kvádru");
        Console.WriteLine("Objem kvádru je: " + objemkvadru);
    }
    else if (volba == 4)
    {
        Console.WriteLine("4. Výpočet povrchu kvádru");
        Console.WriteLine("Povrch kvadru je: " + povrchkvadru);
    }
    else
    {
        Console.WriteLine("Neplatná hodnota");
    }
}