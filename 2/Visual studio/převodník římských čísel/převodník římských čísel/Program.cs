Console.WriteLine("K/k pro konec");
while (true)
{
    Console.WriteLine("Zvolte program (AR/RA): ");
    string odpoved = Console.ReadLine().ToUpper();
    if (odpoved == "K")
    {
        Environment.Exit(0);
    }
    if (odpoved == "AR")
    {
        while(true)
        {
            Console.Write("Zadejte arabské čislo: ");
            string vstup1 = Console.ReadLine().ToUpper();
            if (vstup1 == "K")
                break;

            int cislo = int.Parse(vstup1);
            int[] arabske = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string[] rimske = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            string vysledek1 = "";

            for (int i = 0; i < rimske.Length; i++)
            {
                while (cislo >= arabske[i])
                {
                    vysledek1 += rimske[i];
                    cislo -= arabske[i];
                }
            }
            Console.WriteLine("Výsledek: " + vysledek1);
        }
    }
    if (odpoved == "RA")
    {
        while (true)
        {
            int vysledek = 0;
            int hodnota = 0;
            int hodnotaZnaku = 0;
            string vstup = "";
            Console.Write("Zadejte římské číslo: ");
            vstup = Console.ReadLine().ToUpper();


            if (vstup == "K")
                break;

            for (int i = vstup.Length - 1; i >= 0; i--)
            {
                /*
                hodnotaZnaku = RimskeArabske(vstup[i]);
                */

                hodnotaZnaku = vstup[i];
                switch (hodnotaZnaku)
                {
                    case 'I':
                        hodnotaZnaku = 1;
                        break;
                    case 'V':
                        hodnotaZnaku = 5;
                        break;
                    case 'X':
                        hodnotaZnaku = 10;
                        break;
                    case 'L':
                        hodnotaZnaku = 50;
                        break;
                    case 'C':
                        hodnotaZnaku = 100;
                        break;
                    case 'D':
                        hodnotaZnaku = 500;
                        break;
                    case 'M':
                        hodnotaZnaku = 1000;
                        break;
                    default:
                        hodnotaZnaku = -1;
                        break;

                }

                if (hodnotaZnaku < 0)
                {
                    Console.WriteLine("neplatné číslo.");
                    break;
                }
                else if (hodnotaZnaku < hodnota)
                {
                    vysledek -= hodnotaZnaku;
                }
                else
                {
                    vysledek += hodnotaZnaku;
                }
                hodnota = hodnotaZnaku;

            }
            Console.WriteLine("Výsledek: " + vysledek);
        }
    }
    else
    {
        Console.WriteLine("Neplatná volba");
    }
}









/*
int RimskeArabske(char rimske)
{
    switch (rimske)
    {
        case 'I': return 1;
        case 'V': return 5;
        case 'X': return 10;
        case 'L': return 50;
        case 'C': return 100;
        case 'D': return 500;
        case 'M': return 1000;
        default: return -1;
    }
}
*/