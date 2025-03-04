Console.WriteLine("Program - zápis do polí");
Console.Write("Zadejte velikost pole: ");
int velikostPole = int.Parse(Console.ReadLine());
int[] pole = new int[velikostPole];

while (true)
{
    Console.WriteLine("Výpis pole:");
    for (int i = 0; i < pole.Length; i++)
    {
        Console.Write("{0} ", pole[i]);
    }
    Console.WriteLine();
    Console.Write("Zadej pozici v poli: ");
    int pozice = int.Parse(Console.ReadLine());
    if (pozice > velikostPole)
    {
        Console.WriteLine("Pozice neexistuje.");
        Console.Write("Zadej pozici v poli: ");
        pozice = int.Parse(Console.ReadLine());
        Console.Write("Zadej hodnotu na pozici: ");
        pole[pozice - 1] = int.Parse(Console.ReadLine());
    }
    else if(pozice == 0)
    {
        Console.Write("Konec");
        //break;
        Environment.Exit(0);
        //tvrdé ukončení celého programu, nejen cyklu
    }
    else
    {
        Console.Write("Zadej hodnotu na pozici: ");
        pole[pozice - 1] = int.Parse(Console.ReadLine());
    }
}