Console.WriteLine("Zadej počet účastníků: ");
int pocetUcastniku = int.Parse(Console.ReadLine());
string[] ucastnici = new string [pocetUcastniku];
double[] casy = new double [pocetUcastniku];
double body;
string volba2 = "";

Menu:
while (true)
{
    //MENU
    Console.WriteLine("\nVyber z menu: ");
    Console.WriteLine("1 - 100m běh");
    Console.WriteLine("2 - výsledková listina");
    int volba = int.Parse(Console.ReadLine());

    //100m běh
    if (volba == 1)
    {
        Console.WriteLine("\n===== 100m běh =====");
        for (int i = 0; i < pocetUcastniku; i++)
        {
            Console.WriteLine($"Jméno účastníka č.{i + 1}: ");
            ucastnici[i] = Console.ReadLine();
            Console.WriteLine("Čas v destinnném čísle: ");
            casy[i] = int.Parse(Console.ReadLine());
        }
    }

    //listina
    else if (volba == 2)
    {
        Console.WriteLine("\n===== Výsledková listina =====");
        for (int i = 0; i < pocetUcastniku; i++)
        {
            if (casy[i] < 10)
            {
                body = casy[i] * 2;
            }
            if ((casy[i] >= 10) && (casy[i] < 12))
            {
                body = casy[i] * 1.5;
            }
            else
            {
                body = casy[i];
            }

            Console.WriteLine($"{ucastnici[i]} - {body} bodů");
        }

    }
    else
    {
        Console.WriteLine("Neplatná hodnota!");
    }
}

Console.WriteLine("Chcete zadat nové výsledky? [ano/ne]");
volba2 = Console.ReadLine();

switch (volba2)
{
    case "ano":
        goto Menu;
        break;
    default:
        Console.WriteLine("Konec programu");
        Environment.Exit(0);
        break;
}