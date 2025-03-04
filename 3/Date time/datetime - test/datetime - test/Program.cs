DateTime datumNarozeni;
DateTime zacatekRezervace;
DateTime konecRezervace;
TimeSpan vek = new TimeSpan(0, 0, 0);

Main();

while (vek.Days / 365 < 18)
{
    Console.Clear();
    Console.WriteLine("Váš věk je pro rezervaci příliš nízký.");
    Console.Write("Pro přepsání dat zadejte 1, pro ukončení programu zadejte 2: ");
    int choice = int.Parse(Console.ReadLine());
    if (choice == 1)
    {
        Console.Clear();
        Main();
    }
    else if (choice == 2)
    {
        Console.Clear();
        Console.WriteLine("Progrem se ukončuje");
        Environment.Exit(0);
    }
    else
    {
        Console.WriteLine("Zadejte znova!");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();

    }
}

Console.Clear();
Console.WriteLine("===== Děkujeme =====");
Console.WriteLine("vaše údaje jsou vpořádku");
TimeSpan pocetNoci = konecRezervace - zacatekRezervace;
Console.WriteLine($"Počet nocí: {pocetNoci.Days}\nRezervace od {zacatekRezervace.ToShortDateString()} do {konecRezervace.ToShortDateString()}");

void Main()
{
    Console.WriteLine("===== Rezervační systém =====");
    Console.WriteLine("Zadejte jméno a přijmení: ");
    string jmenoAPrijmeni = Console.ReadLine();
    Console.WriteLine("Zadejte datum narození: ");
    datumNarozeni = DateTime.Parse(Console.ReadLine());
    Console.WriteLine("Zadejte e-mail: ");
    string email = Console.ReadLine();
    Console.WriteLine("Zadejte telefonní číslo: ");
    int telefon = int.Parse(Console.ReadLine());
    Console.WriteLine("Zadejte začátek rezervace: ");
    zacatekRezervace = DateTime.Parse(Console.ReadLine());
    Console.WriteLine("Zadejte konec rezervace: ");
    konecRezervace = DateTime.Parse(Console.ReadLine());

    TimeSpan vek = DateTime.Today - datumNarozeni;
}