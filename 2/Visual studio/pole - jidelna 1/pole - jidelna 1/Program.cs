Console.WriteLine("---Jídelna---");

int[] pole = new int[5];

while (true)
{
    Console.WriteLine("Objednané dny:");
    for (int i = 0; i < 5; i++)
    {
        Console.Write("{0} ", pole[i]);
    }
    Console.WriteLine();
    Console.Write("Který den si přejete objednat? ");
    int pozice = int.Parse(Console.ReadLine());
    pole[pozice -1 ] = 1;
    Console.WriteLine("Chcete objednat další den? (ano/ne)");
    string odpoved = Console.ReadLine();
    if (odpoved == "ne")
    {
        break;
    }
}