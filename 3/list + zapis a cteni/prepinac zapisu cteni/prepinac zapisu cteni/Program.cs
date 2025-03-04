Console.WriteLine("Zvolte funkci programu");
Console.WriteLine("1 - Zápis do souboru");
Console.WriteLine("2 - Čtení souboru");
Console.WriteLine("3 - Vyčištění souboru");
Console.WriteLine("4 - Konec");

while (true)
{
    Console.WriteLine("Vaše volba: ");
    string volba = Console.ReadLine();
    switch(volba)
    {
        case "zapis":
            StreamWriter vstup = new StreamWriter(@"text.txt", true);
            Console.WriteLine("-----Zapiš text-----");
            while(true)
            {
                string text = Console.ReadLine();
                if (text == "End") break;
                vstup.WriteLine(text);
            }
            vstup.Close();
            break;
        case "cteni":
            StreamReader vystup = new StreamReader(@"text.txt");
            Console.WriteLine("-----Výstup textu-----");
            string vypis = vystup.ReadToEnd();
            vystup.Close();
            Console.WriteLine(vypis);
            break;
        case "vycisteni":
            StreamWriter novyDokument = new StreamWriter(@"text.txt");
            novyDokument.Close();
            Console.WriteLine("-----Text byl smazán-----");
            /*
            File.Delete("text.txt");
            Console.WriteLine("-----Text byl smazán-----");
            */
            break ;
        case "konec":
            Console.WriteLine("Ukončení programu");
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Neplatné");
            break;
    }
}