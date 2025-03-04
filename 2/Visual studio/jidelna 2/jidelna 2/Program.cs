Console.WriteLine("Program jidelna 2");
Console.WriteLine();

Console.WriteLine("1 | Pondělí: Halušky");
Console.WriteLine("2 | Úterý: Řízek");
Console.WriteLine("3 | Středa: Guláš");
Console.WriteLine("4 | Čtvrtek: Svíčková");
Console.WriteLine("5 | Pátek: Salát");

Console.WriteLine();


int[] pole = new int[5];
string odpoved;

Console.WriteLine("PO UT ST CT PA");
for (int i = 0; i < 5; i++)
{
    if (pole[i] == 0)
    {
        Console.Write("[ ]", pole[i]);
    }
    else
        Console.Write("[x]", pole[i]);
}

do
{
    Console.WriteLine();
    Console.Write("Který den si přejete objednat? ");
    int pozice = int.Parse(Console.ReadLine());
    pole[pozice - 1] = 1;
    Console.WriteLine("Přehled objednaných dnů: ");
    Console.WriteLine("PO UT ST CT PA");
    for (int i = 0; i < 5; i++)
    {
        if (pole[i] == 0)
        {
            Console.Write("[ ]", pole[i]);
        }
        else
            Console.Write("[x]", pole[i]);
    }
    Console.WriteLine("\nChcete objednat další den? (ano/ne)");
    odpoved = Console.ReadLine();

} while (odpoved != "ne");