// https://www.itnetwork.cz/csharp/kolekce-a-linq/c-sharp-tutorial-seznamy-kolekce-list

List<string> simpsonovi = new List<string>() { "Homer", "Marge" };
/*
simpsonovi.Add("Bart");
simpsonovi.Add(Console.ReadLine());

Vypis(simpsonovi);

simpsonovi.Remove(Console.ReadLine());
//simpsonovi.RemoveAt(2);

Vypis(simpsonovi);
*/
Menu();

while (true)
{
    Console.WriteLine("Vaše volba: ");
    int volba = int.Parse(Console.ReadLine());

    switch (volba)
    {
        case 1:
            Console.WriteLine("zadej jméno:");
            simpsonovi.Add(Console.ReadLine());
            break;
        case 2:
            Console.WriteLine("Smaž jméno:");
            simpsonovi.Remove(Console.ReadLine());
            break;
        case 3:
            simpsonovi.Sort();
            Console.WriteLine("List seřazen!");
            break;
        case 4:
            Vypis(simpsonovi);
            break;
        case 5:
            StreamWriter ulozeniJmen = new StreamWriter(@"jmena.txt", true);
            foreach (string s in simpsonovi)
            {
                ulozeniJmen.WriteLine(s);
            }
            ulozeniJmen.Close();
            Console.WriteLine("Uloženo!");
            break;
        case 6:
            Console.WriteLine("Smaž jméno:");
            string jmenoKSmazani = Console.ReadLine();
            simpsonovi.RemoveAll(prvekSeznamu => prvekSeznamu == jmenoKSmazani);
            Console.WriteLine("Všechna zadaná jména smazána!");
            break ;
        case 7:
            Console.WriteLine("Ende");
            Environment.Exit(0);
            break ;
        default:
            Console.WriteLine("try again bozo");
            break;
    }
}

void Menu()
{
    Console.WriteLine("1. add");
    Console.WriteLine("2. delete");
    Console.WriteLine("3. sort");
    Console.WriteLine("4. write");
    Console.WriteLine("5. save");
    Console.WriteLine("6. delete all same");
    Console.WriteLine("7. Ende");
}

void Vypis(List<string> simpsonovi)
{
    Console.WriteLine("List: "); 
    foreach (string s in simpsonovi)
    {
        Console.WriteLine(s);
    }
}