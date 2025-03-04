using System.Linq.Expressions;

class Program
{
    static List<string> Praha = new List<string> { "Octavia", "Golf", "Polo", "Kodiaq", "Karoq", "Passat" };
    static List<string> Brno = new List<string> { "Lambo", "Civic", "Veyron", "Chiron", "Feruci", "Rover" };
    static List<string> Ostrava = new List<string> { "Mower", "Karan", "Košík", "Fabia", "Mustang", "Traktor" };
    
   

    static void LoginMain()
    {
        Console.WriteLine("----------- Přihlašte se do systému -----------");
        string login;
        string password;
        int pokusy = 0;
        int Captcha;
        do
        {
            Console.Write("Login: ");
            login = Console.ReadLine();
            if (login == "admin")
                break;
            Console.Write("Zadejte správný login: ");
            login = Console.ReadLine();
            pokusy++;
            if (pokusy > 3)
            {
                Bezpokusu();
            }
            if (login == "admin")
            {
                pokusy = 0;
            }
        } while (login != "admin");



        Console.Write("Password: ");
        do
        {
            password = Console.ReadLine();
            if (password == "admin")
                break;
            Console.Write("Zadejte správný password: ");
            login = Console.ReadLine();
            pokusy++;
            if (pokusy > 3)
            {
                Bezpokusu();
            }
            if (password == "admin")
            {
                pokusy = 0;
            }
        } while (password != "admin");

        int guess;

        do
        {
            Random rand = new Random();
            Captcha = rand.Next(10000, 99999);
            Console.WriteLine("Vygenerované číslo CAPTCHA: {0}", Captcha);
            Console.Write("Ověřte číslo CAPTCHA jejím zadáním: ");
            guess = int.Parse(Console.ReadLine());
            pokusy++;
            if (pokusy > 3)
            {
                Bezpokusu();
            }
        } while (guess != Captcha);

    }

    static void Bezpokusu()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Došli ti pokusy zkus znovu za 5 sekund!");
        Thread.Sleep(5000);
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.White;
        LoginMain();
    }

    static void Main()
    {
        LoginMain();
        Console.WriteLine();
        Console.WriteLine("===================== Vítejte v systému =====================");
        Console.Write("Zadejte provozovnu (Praha, Brno nebo Ostrava) s databází: ");
        string provozovna = Console.ReadLine().ToUpper();
        if (provozovna == "PRAHA")
        {
            ProvozovnaPraha(Praha);
        }
        if (provozovna == "BRNO")
        {
            ProvozovnaBrno(Brno);
        }
        if (provozovna == "OSTRAVA")
        {
            ProvozovnaOstrava(Ostrava);
        }
    }

    static void ProvozovnaPraha(List<string> Praha)
    {
        Console.WriteLine();
        Console.WriteLine("Databáze automobilů Praha");
        Console.WriteLine("Prosím zvolte si volbu: ");
      while (true) { 
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("1. Přidat nové vozidlo s daty");
            Console.WriteLine("2. Odstranit vozidlo");
            Console.WriteLine("3. Vyhledat model");
            Console.WriteLine("4. Vypiš seznam vozidel");
            Console.WriteLine("5. Spočítej počet modelu");
            Console.WriteLine("6. Uložit do textového souboru");
            Console.WriteLine("7. Exit");
            Console.WriteLine("-----------------------------------");
            Console.Write("Volba: ");
            int volba = int.Parse(Console.ReadLine());


            switch (volba)
            {
                case 1:
                    Console.Write("Zadej produkt: ");
                    string pridat = Console.ReadLine();
                    Praha.Add(pridat);
                    break;
                case 2:
                    Console.Write("Smaž produkt: ");
                    string smazat = Console.ReadLine();
                    Praha.Remove(smazat);
                    break;
                case 3:
                    Console.Write("Vyhledej produkt: ");
                    string hledat = Console.ReadLine();
                    if (Praha.Contains(hledat))
                    {
                        Console.WriteLine("{0} je v seznamu", hledat);
                    }
                    else
                        Console.WriteLine("Produkt není na prodejně");
                    break;
                case 4:
                    foreach (string P in Praha)
                    {
                        Console.WriteLine(P);
                    }
                    Console.Write("-------- Seznam produktů --------");
                    break;
                case 5:
                    Console.Write("Zadej název produktu: ");
                    string nazevKs = Console.ReadLine();

                    int pocetKs = Praha.Count(p => p.Equals(nazevKs));

                    Console.WriteLine("Počet ks produktu {0}: {1}", nazevKs, pocetKs);
                    break;
                case 6:
                    File.WriteAllLines("Praha", Praha);
                    Console.WriteLine("========= Uloženo =========");
                    break;
                case 7:
                    Console.WriteLine("Program ukončen");
                    Environment.Exit(0);
                    break;
            }
        }

    }

    static void ProvozovnaBrno(List<string> Brno)
    {
        Console.WriteLine("Databáze automobilů Brno");
        Console.WriteLine("Prosím zvolte si volbu: ");
        while (true)
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("1. Přidat nové vozidlo s daty");
            Console.WriteLine("2. Odstranit vozidlo");
            Console.WriteLine("3. Vyhledat model");
            Console.WriteLine("4. Vypiš seznam vozidel");
            Console.WriteLine("5. Spočítej počet modelu");
            Console.WriteLine("6. Uložit do textového souboru");
            Console.WriteLine("7. Exit");
            Console.WriteLine("-----------------------------------");
            Console.Write("Volba: ");
            int volba = int.Parse(Console.ReadLine());


            switch (volba)
            {
                case 1:
                    Console.Write("Zadej produkt: ");
                    string pridat = Console.ReadLine();
                    Brno.Add(pridat);
                    break;
                case 2:
                    Console.Write("Smaž produkt: ");
                    string smazat = Console.ReadLine();
                    Brno.Remove(smazat);
                    break;
                case 3:
                    Console.Write("Vyhledej produkt: ");
                    string hledat = Console.ReadLine();
                    if (Brno.Contains(hledat))
                    {
                        Console.WriteLine("{0} je v seznamu", hledat);
                    }
                    else
                        Console.WriteLine("Produkt není na prodejně");
                    break;
                case 4:
                    foreach (string B in Brno)
                    {
                        Console.WriteLine(B);
                    }
                    Console.Write("-------- Seznam produktů --------");
                    break;
                case 5:
                    Console.Write("Zadej název produktu: ");
                    string nazevKs = Console.ReadLine();

                    int pocetKs = Brno.Count(p => p.Equals(nazevKs));

                    Console.WriteLine("Počet ks produktu {0}: {1}", nazevKs, pocetKs);
                    break;
                case 6:
                    File.WriteAllLines("Brno", Brno);
                    Console.WriteLine("========= Uloženo =========");
                    break;
                case 7:
                    Console.WriteLine("Program ukončen");
                    Environment.Exit(0);
                    break;
            }
        }
    }

    static void ProvozovnaOstrava(List<string> Ostrava)
    {
        Console.WriteLine("Databáze automobilů Ostrava");
        Console.WriteLine("Prosím zvolte si volbu: ");
        while (true)
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("1. Přidat nové vozidlo s daty");
            Console.WriteLine("2. Odstranit vozidlo");
            Console.WriteLine("3. Vyhledat model");
            Console.WriteLine("4. Vypiš seznam vozidel");
            Console.WriteLine("5. Spočítej počet modelu");
            Console.WriteLine("6. Uložit do textového souboru");
            Console.WriteLine("7. Exit");
            Console.WriteLine("-----------------------------------");
            Console.Write("Volba: ");
            int volba = int.Parse(Console.ReadLine());


            switch (volba)
            {
                case 1:
                    Console.Write("Zadej produkt: ");
                    string pridat = Console.ReadLine();
                    Ostrava.Add(pridat);
                    break;
                case 2:
                    Console.Write("Smaž produkt: ");
                    string smazat = Console.ReadLine();
                    Ostrava.Remove(smazat);
                    break;
                case 3:
                    Console.Write("Vyhledej produkt: ");
                    string hledat = Console.ReadLine();
                    if (Ostrava.Contains(hledat))
                    {
                        Console.WriteLine("{0} je v seznamu", hledat);
                    }
                    else
                        Console.WriteLine("Produkt není na prodejně");
                    break;
                case 4:
                    foreach (string O in Ostrava)
                    {
                        Console.WriteLine(O);
                    }
                    Console.Write("-------- Seznam produktů --------");
                    break;
                case 5:
                    Console.Write("Zadej název produktu: ");
                    string nazevKs = Console.ReadLine();

                    int pocetKs = Ostrava.Count(p => p.Equals(nazevKs));

                    Console.WriteLine("Počet ks produktu {0}: {1}", nazevKs, pocetKs);
                    break;
                case 6:
                    File.WriteAllLines("Ostrava", Ostrava);
                    Console.WriteLine("========= Uloženo =========");
                    break;
                case 7:
                    Console.WriteLine("Program ukončen");
                    Environment.Exit(0);
                    break;
            }
        }
    }
}