string volba = "";
string[] poznamky = new string[3];
int counter = 0;
int pozice = 0;

while (true)
{
    Console.WriteLine();
    Console.WriteLine("1. Přidat poznámku");
    Console.WriteLine("2. Odstranit poznámku");
    Console.WriteLine("3. Zobrazit poznámky");
    Console.WriteLine("4. Exit");
    Console.Write("Vaše volba: ");
    volba = Console.ReadLine();
    Console.WriteLine();

    if (volba == "1")
    {
        if (counter < poznamky.Length)
        {
            Console.Write("Zadejte poznámku: ");
            poznamky[counter] = Console.ReadLine();
            counter++;
            Console.WriteLine("Poznámka přidána.");
        }
        else
        {
            Console.WriteLine("Vaše poznámky jsou plné!");
            Console.Beep(700, 3000);
        }
       
    }
    if (volba == "2")
    {
        Console.Write("Vyberte pozici pro smazání: ");
        pozice = int.Parse(Console.ReadLine());
        if (pozice >= 0 && pozice < counter)
        {
            poznamky[pozice - 1] = "";
            counter--;
            Console.WriteLine("Poznámka smazána.");
        }
        else
        {
            Console.WriteLine("Neplatná pozice!");
        }
    }
    if (volba == "3")
    {
        if (counter == 0)
        {
            Console.WriteLine("Žádné poznámky");
        }
        else
        {
            Console.WriteLine("Vaše poznámky:");
            for (int i = 0; i < poznamky.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + poznamky[i]);
            }
        }
    }
    if (volba == "4")
    {
        Console.WriteLine("Na shledanou!");
        Environment.Exit(0);
    }
    else
    {
        Console.WriteLine("Zadej znovu!");
    }
}