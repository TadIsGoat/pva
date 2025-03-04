while (true)
{
    Console.WriteLine("Definujte velikost hracího pole: ");
    Console.Write("Šířka: ");
    int b = int.Parse(Console.ReadLine());
    Console.Write("Výška: ");
    int a = int.Parse(Console.ReadLine());
    Console.Write("Definujte počet po sobě jdoucích bodů pro výhru: ");
    int bodyProVyhru = int.Parse(Console.ReadLine());

    int[,] plocha = new int[a, b];
    int i = 0;
    int j = 0;
    int radek;
    int sloupec;

    Console.Clear();
    while (true)
    {
        //hráč X
        Console.Write("Hráč X zadejte číslo řádku: ");
        radek = int.Parse(Console.ReadLine());
        Console.Write("Hráč X zadejte číslo sloupce: ");
        sloupec = int.Parse(Console.ReadLine());

        if (((radek - 1) < 0) || ((radek - 1) >= a) || ((sloupec - 1) < 0) || ((sloupec - 1) >= b))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Nelze!");
            Console.ForegroundColor = ConsoleColor.White;
            break;
        }
        else if ((plocha[radek - 1, sloupec - 1] == 1) || (plocha[radek - 1, sloupec - 1] == 2))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Pozice je již obsazená!");
            Console.ForegroundColor = ConsoleColor.White;
            break;
        }
        else if (plocha[radek - 1, sloupec - 1] == 0)
        {
            plocha[radek - 1, sloupec - 1] = 1;

            Console.Write("  ");
            for (i = 0; i < b; i++)
            {
                if (i < 9)
                    Console.Write(" " + (i + 1) + " ");
                else
                    Console.Write((i + 1) + " ");
            }
            Console.WriteLine();
            for (i = 0; i < a; i++)
            {
                if (i < 9)
                {
                    Console.Write($"{i + 1} ");
                }
                else
                {
                    Console.Write($"{i + 1}");
                }
                for (j = 0; j < b; j++)
                {
                    if (plocha[i, j] == 0)
                    {
                        Console.Write("[ ]");
                    }
                    if (plocha[i, j] == 1)
                    {
                        Console.Write("[x]");
                    }
                    if (plocha[i, j] == 2)
                    {
                        Console.Write("[o]");
                    }
                }
                Console.WriteLine();
            }
            //kontrola výhry
            for (i = 0; i <= plocha.GetLength(0) - bodyProVyhru; i++)
            {
                for (j = 0; j <= plocha.GetLength(1) - bodyProVyhru; j++)
                {
                    //kontrola křižně z leva do leva
                    bool vyherce = true;
                    for (int k = 0; k < bodyProVyhru; k++)
                    {
                        if (plocha[i + k, j + k] != 1)
                        {
                            vyherce = false;
                            break;
                        }
                    }
                    if (vyherce == true)
                    {
                        Console.WriteLine("Hráč X vyhrál!");
                        Console.WriteLine("Chcete hrát znovu?");
                        string pokracovani = Console.ReadLine();
                        if (pokracovani == "ano")
                        {

                        }
                        else
                        {
                            Console.WriteLine("Díky za hru");
                            Environment.Exit(0);
                        }
                    }
                    //kontrola křižně z prava do leva
                    vyherce = true;
                    for (int k = 0; k < bodyProVyhru; k++)
                    {
                        if (plocha[i + k, j + bodyProVyhru - 1 - k] != 1)
                        {

                        }
                    }
                }
            }
            //remiza
            bool remiza = true;
            for (i = 0; i < plocha.GetLength(0); i++)
            {
                for (j = 0; j < plocha.GetLength(1); j++)
                {
                    if (plocha[i, j] == 0)
                    {
                        remiza = false;
                        break;
                    }
                }
                if (!remiza)
                {
                    break;
                }
            }
            if (remiza)
            {
                Console.WriteLine("Hra skončila remízou!");
                Console.WriteLine("Chcete hrát znovu?");
                string pokracovani = Console.ReadLine();
                if (pokracovani == "ano")
                {
                    break; // ------------------------------------------------------------------------
                }
                else
                {
                    Console.WriteLine("Díky za hru");
                    Environment.Exit(0);
                }
            }
        }






        while (true)
        {
            //hráč O
            Console.Write("Hráč O zadejte číslo řádku: ");
            radek = int.Parse(Console.ReadLine());
            Console.Write("Hráč O zadejte číslo sloupce: ");
            sloupec = int.Parse(Console.ReadLine());

            if (((radek - 1) < 0) || ((radek - 1) >= a) || ((sloupec - 1) < 0) || ((sloupec - 1) >= b))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nelze!");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if ((plocha[radek - 1, sloupec - 1] == 1) || (plocha[radek - 1, sloupec - 1] == 2))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Pozice je již obsazená!");
                Console.ForegroundColor = ConsoleColor.White;

            }
            else if (plocha[radek - 1, sloupec - 1] == 0)
            {
                plocha[radek - 1, sloupec - 1] = 2;

                Console.Write("  ");
                for (i = 0; i < b; i++)
                {
                    if (i < 9)
                        Console.Write(" " + (i + 1) + " ");
                    else
                        Console.Write((i + 1) + " ");
                }
                Console.WriteLine();
                for (i = 0; i < a; i++)
                {
                    if (i < 9)
                    {
                        Console.Write($"{i + 1} ");
                    }
                    else
                    {
                        Console.Write($"{i + 1}");
                    }
                    for (j = 0; j < b; j++)
                    {
                        if (plocha[i, j] == 0)
                        {
                            Console.Write("[ ]");
                        }
                        if (plocha[i, j] == 1)
                        {
                            Console.Write("[x]");
                        }
                        if (plocha[i, j] == 2)
                        {
                            Console.Write("[o]");
                        }
                    }
                    Console.WriteLine();
                }
                break;
            }
        }
    }
}