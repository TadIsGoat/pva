string[] zelenina = { "zelí", "okurka", "rajče", "paprika", "ředkev", "mrkev", "brokolice" };
string[] ovoce = { "jablko", "hruška", "pomeranč", "jahoda", "banán", "kiwi", "malina" };

Console.Write("Zelenina: ");
foreach (string z in zelenina)
{
    Console.Write(z + ", ");
}

Console.Write("\nOvoce: ");
foreach (string o in ovoce)
{
    Console.Write(o + ", ");
}

string odpoved = "";
int pocetItemu = 0;

do
{
    Console.WriteLine("\nVyhledej libovolnou položku: ");
    string item = Console.ReadLine().ToLower();

    odpoved = "";

    if (zelenina.Contains(item))
    {
        Console.WriteLine("Zadal jsi zeleninu!");
    }
    else if (ovoce.Contains(item))
    {
        Console.WriteLine("Zadal jsi ovoce!");
    }
    else
    {
        Console.WriteLine("chyba!");
    }

    pocetItemu++;

    Console.WriteLine("Přeješ si hledat dál?");
    odpoved = Console.ReadLine().ToLower();

} while (odpoved == "ano");

Console.WriteLine("Zadal jsi {0} potravin", pocetItemu);