Console.WriteLine("Vítejte v programu ruleta");
string odpoved1 = "";
string odpoved2 = "";
int kredit = 0;

start:

Console.Write("Vložte kredit: ");
int vklad = int.Parse(Console.ReadLine());
kredit = kredit + vklad;

while (true)
{


    Console.WriteLine("Stav vašeho kreditu je: " + kredit);

    fortuna:

    Console.Write("Kolik kreditu chcete vsadit? ");
    int sazka = int.Parse(Console.ReadLine());

    if (sazka > kredit)
    {
        Console.WriteLine("Nedostatek kreditu, chcete vložit kredit?");
        odpoved1 = Console.ReadLine();
    }
    if (odpoved1 == "ano")
    {
        goto start;
    }
    if (odpoved1 == "ne")
    {
        Console.Write("Vsaďte hodnotu v rozmezí vašeho kreditu:");
        goto fortuna;
    }
    else
    {
        Console.WriteLine("Na jaké číslo (0 - 37) si chcete vsadit?");
        int vsazeneCislo = int.Parse(Console.ReadLine());

        if ((vsazeneCislo < 0) || (vsazeneCislo > 37))
        {
            Console.WriteLine("Neplatné!");
            break;
        }

        kredit = kredit - sazka;

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Hoď kuličkou!");
        Console.WriteLine();

        int random;
        Random random1 = new Random();
        random = random1.Next(0, 38);

        if (random % 2 == 0 && random != 0)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Losované číslo je: " + random);
        }
        if (random == 0)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Losované číslo je: " + random);
        }
        if (random % 2 != 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Losované číslo je: " + random);
        }
        Console.ForegroundColor = ConsoleColor.White;

        if (random == vsazeneCislo)
        {
            Console.WriteLine("Gratuluji, vyhrál jsi!");
            kredit = kredit + (sazka * 35);
            Console.WriteLine("Stav kreditu je:" + kredit);
        }
        if (random != vsazeneCislo)
        {
            Console.WriteLine("Bohužel, prohrál jsi!");
            Console.WriteLine("Stav kreditu je:" + kredit);
        }

        Console.WriteLine("Chceš hrát znovu?");
        odpoved2 = Console.ReadLine();
        if (odpoved2 == "ano")
        {
            goto fortuna;
        }
        else
        {
            Console.WriteLine("Stav koncového kreditu je: " + kredit);
            break;
        }
    }
}