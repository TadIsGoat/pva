int menuChoice = 4;
int pridaniSlov = 0;
List<string[]> slova = new List<string[]>();

Console.WriteLine("-----Slovníček-----");

while (true)
{
    menu();
    switch (menuChoice)
    {
        case 1: show(); break;
        case 2: add(); break;
        case 3: play(); break;
        case 4: delete(); break;
        case 5: Environment.Exit(0); break;
        default: Console.WriteLine("Neplatná volba, zkuste to znovu!"); break;
    }

    void menu()
    {
        Console.WriteLine("Menu: ");
        Console.WriteLine("1 - show");
        Console.WriteLine("2 - add");
        Console.WriteLine("3 - play");
        Console.WriteLine("4 - delete");
        Console.WriteLine("5 - exit");
        menuChoice = int.Parse(Console.ReadLine());
        Console.Clear();
    }

    void show()
    {
        if (emptyCheck())
        {
            return;
        }
        for (int j = 0; j < slova.Count; j++)
        {
            if (j < 9)
            {
                Console.Write($"{j + 1}. ");
            }
            else
            {
                Console.Write($"{j + 1}.");
            }
            for (int i = 0; i < slova[j].Length; i++)
            {
                Console.Write(" " + slova[j][i]);
            }
            Console.WriteLine();
        }
        Console.ReadKey();
        Console.Clear();
    }

    void play()
    {
        if (emptyCheck())
        {
            return;
        }
        for (int i = 0; i < slova.Count; i++)
        {
            Console.Write($"Zadejte překlad pro {slova[i][0]}: ");
            string odpoved = Console.ReadLine();

            if (odpoved == slova[i][1])
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Správně!");
                Console.ForegroundColor = ConsoleColor.White;

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Špatně, správná odpověď je {slova[i][1]}");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        Console.ReadKey();
        Console.Clear();
    }
    void add()
    {
        Console.WriteLine("Kolik slov chcete přidat?");
        pridaniSlov = int.Parse(Console.ReadLine());

        for (int i = 0; i < pridaniSlov; i++)
        {
            string[] novaSlova = new string[2];
            Console.Write($"Zadejte {i + 1}. slovo v prvním jazyce: ");
            novaSlova[0] = Console.ReadLine();

            Console.Write($"Zadejte {i + 1}. slovo v druhém jazyce: ");
            novaSlova[1] = Console.ReadLine();
            Console.Clear();

            slova.Add(novaSlova);
        }
    }

    void delete()
    {
        if (emptyCheck())
        {
            return;
        }
        for (int j = 0; j < slova.Count; j++)
        {
            if (j < 9)
            {
                Console.Write($"{j + 1}. ");
            }
            else
            {
                Console.Write($"{j + 1}.");
            }
            for (int i = 0; i < slova[j].Length; i++)
            {
                Console.Write(" " + slova[j][i]);
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nZadejte číslo slova, které chcete smazat: ");

        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < slova.Count)
        {
            slova.RemoveAt(index);
            Console.WriteLine("Slovo bylo úspešně smazáno!");
        }
        else
        {
            Console.WriteLine("Neplatný index, zkuste to znovu!");
        }
        Console.ReadKey();
        Console.Clear();
    }

    bool emptyCheck()
    {
        if (slova.Count <= 0)
        {
            Console.WriteLine("Ještě jsi nepřidal žádné slovo!");
            Console.ReadKey();
            Console.Clear();
            return true;
        } 
        else
        {
            return false;
        }
    }
}