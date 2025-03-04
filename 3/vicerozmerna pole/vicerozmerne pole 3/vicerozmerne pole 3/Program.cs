int[,] kino = new int[5, 5];
const int cena = 179;
int listek = 0;
int vyslednaCena = 0;
int sedadlo;
int rada;
int pokracovani = 1;
while (true)
{
    do
    {
        Console.Write("zadejte číslo sedadla (1-5): ");
        sedadlo = int.Parse(Console.ReadLine());
        if (sedadlo < 1 || sedadlo > 5)
        {
            Console.WriteLine("Špatná hodnota!");
            break;
        }
        Console.Write("zadejte řadu (1-5): ");
        rada = int.Parse(Console.ReadLine());
        if (rada < 1 || rada > 5)
        {
            Console.WriteLine("Špatná hodnota!");
            break;
        }
        if (kino[sedadlo - 1, rada - 1] == 1)
        {
            Console.WriteLine("Obsazeno");
        }
        else
        {
            kino[sedadlo - 1, rada - 1] = 1;
            listek++;
            vyslednaCena = cena * listek;

            Console.WriteLine(" --- Plátno ---");

            for (int i = 0; i < kino.GetLength(0); i++)
            {
                for (int j = 0; j < kino.GetLength(1); j++)
                {
                    //Console.Write(kino[j, i]);
                    if (kino[j, i] == 0)
                    {
                        Console.Write("[ ]");
                    }
                    if (kino[j, i] == 1)
                    {
                        Console.Write("[X]");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Cena je: {vyslednaCena} Kč");
            Console.WriteLine($"Množství lístků je: {listek}");
            Console.WriteLine("Chete si pokračovat? (ANO=1, Zrušení = 2, NE = 3");
            pokracovani = int.Parse(Console.ReadLine());
        }
    } while (pokracovani == 1);

    if (pokracovani == 2)
    {
        do
        {
            Console.Write("zadejte číslo sedadla (1-5): ");
            sedadlo = int.Parse(Console.ReadLine());
            if (sedadlo < 1 || sedadlo > 5)
            {
                Console.WriteLine("Špatná hodnota!");
                break;
            }
            Console.Write("zadejte řadu (1-5): ");
            rada = int.Parse(Console.ReadLine());
            if (rada < 1 || rada > 5)
            {
                Console.WriteLine("Špatná hodnota!");
                break;
            }
            kino[sedadlo - 1, rada - 1] = 0;
            listek--;
            vyslednaCena = cena * listek;

            Console.WriteLine(" --- Plátno ---");

            for (int i = 0; i < kino.GetLength(0); i++)
            {
                for (int j = 0; j < kino.GetLength(1); j++)
                {
                    //Console.Write(kino[j, i]);
                    if (kino[j, i] == 0)
                    {
                        Console.Write("[ ]");
                    }
                    if (kino[j, i] == 1)
                    {
                        Console.Write("[X]");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Cena je: {vyslednaCena} Kč");
            Console.WriteLine($"Množství lístků je: {listek}");
            Console.WriteLine("Chete si pokračovat? (ANO=1, Zrušení = 2, NE = 3");
            pokracovani = int.Parse(Console.ReadLine());
        } while (pokracovani == 2);
    }
    else if (pokracovani == 3)
    {
        Environment.Exit(0);
    }
}