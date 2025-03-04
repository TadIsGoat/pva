int volba;
string menu = "";
int hadaneCislo;
int nahodneCislo;
int nahodneCislo2;
int pocitadlo;
string[] slova = { "strom", "jablko", "hruška", "meruňka" };
string nahodneSlovo = "";
string hadaneSlovo ="";

do
{
    Console.Clear();
    Console.WriteLine("Zvolte hru: ");
    Console.WriteLine("1 - hádej číslo");
    Console.WriteLine("2 - hádej slovo");
    Console.WriteLine("3 - konec");
    volba = int.Parse(Console.ReadLine());
    pocitadlo = 0;

    switch (volba)
    {
        case 1:
            Random random = new Random();
            nahodneCislo = random.Next(1, 11);

            Console.WriteLine("Hádej číslo 1 - 10!");
            do
            {
                Console.Write("Hádej číslo:");
                hadaneCislo = int.Parse(Console.ReadLine());
                pocitadlo++;
                if (hadaneCislo > nahodneCislo)
                {
                    Console.WriteLine("Tvé číslo je příliš vysoké!");
                }
                if (hadaneCislo < nahodneCislo)
                {
                    Console.WriteLine("Tvé číslo je příliš malé");
                }

            } while (hadaneCislo != nahodneCislo);
            Console.WriteLine($"Uhodl jsi číslo {nahodneCislo} se {pocitadlo} pokusy!");

            break;
        case 2:
            Random random2 = new Random();
            nahodneCislo2 = random2.Next(1, 5);

            nahodneSlovo = slova[nahodneCislo2];

            Console.WriteLine($"Hádej slovo, které má {nahodneSlovo.Length} písmen:");
            do
            {
                Console.Write("Hádej slovo: ");
                hadaneSlovo = Console.ReadLine();
                pocitadlo++;

                if (hadaneSlovo != nahodneSlovo)
                {
                    Console.WriteLine("Tvé slovo není správné!");
                }
            } while (hadaneSlovo != nahodneSlovo);
            Console.WriteLine($"Uhodl jsi číslo {nahodneSlovo} se {pocitadlo} pokusy!");

            break;
        case 3:
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Chyba!");
            break;
    }
    Console.Write("Chcete se vrátit do menu? [ANO/NE]: ");
    menu = Console.ReadLine();
    menu.ToLower();
} while (menu == "ano");

Environment.Exit(0);