Console.WriteLine("Zadejte kladné číslo!");
int cislo = int.Parse(Console.ReadLine());

while (cislo < 0 || cislo == 00)
{
    if (cislo < 0)
    {
        Console.WriteLine("To je záporné číslo!");
        Console.WriteLine("Go next");
        cislo = int.Parse(Console.ReadLine());
    }
    else if (cislo == 0)
    {
        Console.WriteLine("To je nula!");
        Console.WriteLine("Go next");
        cislo = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine("Ano toto je kladné číslo");