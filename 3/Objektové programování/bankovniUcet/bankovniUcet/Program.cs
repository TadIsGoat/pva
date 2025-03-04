using bankovniUcet;
BankovniUcet ucet1 = new BankovniUcet("Jan", "Novák", 1000);
BankovniUcet ucet2 = new BankovniUcet("Jakub", "Kutěj", 5000);

while (true)
{
    Menu();

    string volba = Console.ReadLine();
    switch (volba)
    {
        case "1":
            ucet1.ZobrazitZustatek();
            break;
        case "2":
            ucet1.Vlozit(double.Parse(Console.ReadLine()));
            break;
        case "3":
            ucet1.Vybrat(double.Parse(Console.ReadLine()));
            break;
        case "4":
            ucet1.Prevest(double.Parse(Console.ReadLine()));
            break;
        case "5":
            ucet1.ZobrazitTransakce();
            break;
        case "6":
            ucet1.Ulozit();
            break;
        case "7":
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Špatná volba");
            break;
    }

    Console.ReadKey();
    Console.Clear();
}

void Menu()
{
    Console.WriteLine("1. zůstatek");
    Console.WriteLine("2. vlozit");
    Console.WriteLine("3. vybrat");
    Console.WriteLine("4. převést peníze");
    Console.WriteLine("5. zobrazit transakce");
    Console.WriteLine("6. uložit do dokumentu");
    Console.WriteLine("7. konec");
}