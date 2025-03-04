/* Michal Hřebačka  2.B   30.05. 14:40*/

/* ==========Monstra_RPG========== */


double Zlato = 0;
double Health;
int Kills = 0;
int Shield = 0;
int Armor = 0;
int Fire = 0;
int Poison = 0;
int Combo = 0;
int Golden = 0;
double PhDMG;
double MgDMG;
double DMGTotal = 0;
double GoldTotal = 0;
Random rNum = new Random();

string[] zbrane = { "basic sword", "sharp sword", "combo sword", "midas sword", "syphon sword", "fire aspect", "excalibur", "apprentice staff", "potion of poison", "wizard's wand", "golden stick", "steel breaker", "soul bringer" };
int[] Owned = { 1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 };
string[] Popisek = { "| DMG 250 - 500 | - Základní meč, meče nejsou efektivní vůči Armoru!", "| DMG 250 - 1500 | - Udělí maximální poškození Monstru bez Armoru", "| DMG 500 - 750 | - Udělí větší poškození čím vícekrát jím zautočíš zasebou", "| DMG 750 - 1000 | - Na zabití zvýší počet Zlata z monstra", "| DMG 850 - 1200 | Za každý útok Monstrum stratí část štítu", "| DMG 900 - 1300 | - Po dalších 5 útoků bude Monstru uděleno ohnivé poškození", "| DMG 900 - ERROR | Legendární excalibur, uděluje požkození podle toho, kolik má Monstrum životů!", /* hulky*/ "| DMG 300 - 600 | - Základní hůlka, hůlky nejsou účinné proti štítu!", "| DMG 750 - 1000 | - Lektvar Jedu, za každým dalším útokem bude Mostru uděleno požkození v podobě otravy", "| DMG 900 - 1200 | - Udělí maximální poškození Monstru bez štítu", "| DMG 850 - 1000 | - Zvýší Obdržené Zlato za zabití", "| DMG 1000 - 1250 | - Při efektivním zásahu sníží množství Armoru", " | DMG 900 - ERROR | -  Pozustalá hůl Sorcerrer Supreme, Zvyšuje svůj útok podle životů Monstra" };
int[] cena = { 100, 200, 400, 500, 300, 600, 700, 100, 200, 400, 500, 300, 700 };

/*Zombik*/
NewZombie:
Thread.Sleep(1000);
int Defence = rNum.Next(1, 3);
if (Defence == 1)
{
    Shield = rNum.Next(2, 6);
    Armor = rNum.Next(0, 2);
}
if (Defence == 2)
{
    Shield = rNum.Next(0, 2);
    Armor = rNum.Next(2, 6);
}
Health = rNum.Next(500, 1000) * (Kills * 0.25 + 1);
Health = Math.Round(Health, 10);
Console.WriteLine("Objevilo se monstrum!");
Thread.Sleep(2000);
Console.WriteLine();

do
{
    double[] DMG = { rNum.Next(250, 500), rNum.Next(500, 1000), rNum.Next(500, 750), rNum.Next(750, 1000), rNum.Next(850, 1200), rNum.Next(900, 1300), rNum.Next(750, 1500) + (1 + Health * 0.25),/* hulky */rNum.Next(300, 600), rNum.Next(750, 1000), rNum.Next(900, 1200), rNum.Next(850, 1000), rNum.Next(1000, 1250), rNum.Next(900, 1500) + (Health * 0.25) };
    Console.Clear();
    Console.WriteLine("Monstrum:");
    Console.WriteLine();
    /* životy */
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("Životy:         ");
    for (int i = 0; i < Health / 500; i++)
        Console.Write("*");
    Console.WriteLine();
    Console.WriteLine("                 {0}", Health);
    /* Ph Defence */
    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.Write("Armor:          ");
    for (int i = 0; i < Armor; i++)
        Console.Write("*");
    Console.WriteLine();
    Console.WriteLine("                  {0}", Armor);
    /* Mg Defence */
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("Štít:           ");
    for (int i = 0; i < Shield; i++)
        Console.Write("*");
    Console.WriteLine();
    Console.WriteLine("                  {0}", Shield);
    Console.ForegroundColor = ConsoleColor.White;
    Thread.Sleep(1000);
    Console.WriteLine("Vyberte Zbraň:");
    Console.WriteLine();

    foreach (string zbran in zbrane)
    {
        int owned = Array.IndexOf(zbrane, zbran);
        if (Owned[owned] == 1)
        {
            Console.WriteLine(zbran);
            Console.WriteLine();
            Console.WriteLine("     " + Popisek[owned]);
            Console.WriteLine();
        }
    }
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("Zlato: {0}", Zlato);
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine();
    Console.WriteLine("OBCHOD - Kup si nové zbraně!");
    Console.WriteLine("INVENTÁŘ - Prohlédni si své zbraně");
    Console.WriteLine("STATISTIKY - Podívej se na své uspěchy!");
    Console.WriteLine();
Volba:
    string volba = Console.ReadLine().ToLower();

    switch (volba)
    {
        case "obchod":
        Obchod:
            {
                Console.Clear();
                Console.WriteLine("Zlato: {0}", Zlato);
                Console.WriteLine();
                Console.WriteLine("Nakupte si Zbraně!");
                Console.WriteLine();

                foreach (string zbran in zbrane)
                {
                    int Pozice = Array.IndexOf(zbrane, zbran);
                    if (Owned[Pozice] == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine(zbran);
                        Console.WriteLine();
                        Console.WriteLine("     " + Popisek[Pozice]);
                        Console.WriteLine();
                        Console.WriteLine("ZAKOUPENO!");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    if (Owned[Pozice] == 0)
                    {
                        Console.Write(zbran);
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("   [{0}]", cena[Pozice]);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        Console.WriteLine("     " + Popisek[Pozice]);
                        Console.WriteLine();
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Kterou zbraň si chceš koupit?");
                Console.WriteLine();
                Console.WriteLine("Zpět - Zpátky do akce");
            volbaObchod:
                string nákup = Console.ReadLine();

                if (zbrane.Contains(nákup))
                {
                    int Pozice1 = Array.IndexOf(zbrane, nákup);
                    if (Owned[Pozice1] == 0)
                    {
                        if (Zlato >= cena[Pozice1])
                        {
                            Zlato -= cena[Pozice1];
                            Owned[Pozice1] = 1;
                            Console.WriteLine();
                            Console.WriteLine("Zbraň úspěšně zakoupena!");
                            Thread.Sleep(2000);
                            Console.WriteLine();
                            Console.Clear();
                            goto Obchod; // <----- toto počítám jako cyklus
                        }
                        else
                        {
                            Console.WriteLine("Nemáš Dostatek Zlata!");
                            goto volbaObchod;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Tuto Zbraň již vlastníš!");
                        goto volbaObchod;
                    }
                }
                if (nákup == "zpět")
                {
                    break;
                }
                else if (zbrane.Contains(nákup) == false)
                {
                    Console.WriteLine("Tato zbraň není v katalogu!");
                    goto volbaObchod;
                }
            }
            break;

        case "inventář":
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Zlato: {0}", Zlato);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("Tvé Zbraně: ");
                Console.WriteLine();

                foreach (string zbran in zbrane)
                {
                    int Pozice1 = Array.IndexOf(zbrane, zbran);
                    if (Owned[Pozice1] == 1)
                    {
                        Console.WriteLine(zbran);
                        Console.WriteLine();
                        Console.WriteLine("     " + Popisek[Pozice1]);
                        Console.WriteLine();
                    }
                }
                Console.WriteLine("Zmáčnete jakoukoliv klávesu pro návrat do akce");
                System.ConsoleKeyInfo zpět = Console.ReadKey();
                break;
            }

        case "statistiky":
            {
                Console.Clear();
                Console.WriteLine("Tvé Úspěchy:");
                Console.WriteLine();
                Console.WriteLine("Počet Zabití: {0}", Kills);
                Console.WriteLine();
                Console.WriteLine("Celkem získáno zlata: {0}", GoldTotal);
                Console.WriteLine();
                Console.WriteLine("Udělené Poškození: {0}", DMGTotal);
                Console.WriteLine();
                Console.WriteLine("Zmáčnete jakoukoliv klávesu pro návrat do akce");
                System.ConsoleKeyInfo zpět = Console.ReadKey();
                break;
            }

        default:
            {
                if (zbrane.Contains(volba))
                {
                    Console.WriteLine();
                    int Pozice2 = Array.IndexOf(zbrane, volba);
                    if (Owned[Pozice2] == 1)
                    {
                        if (Pozice2 is >= 0 and < 7)
                        {
                            PhDMG = DMG[Pozice2] - (0.2 * DMG[Pozice2] * Armor);
                            PhDMG = Math.Round(PhDMG, 10);
                            Health -= PhDMG;
                            Health = Math.Round(Health, 10);
                            if (Armor > 1)
                                Console.WriteLine("Útok nebyl zcela nejeffektivnější!");
                            Console.WriteLine();
                            Console.WriteLine("Monstrum obdrželo {0} poškození!", PhDMG);
                            DMGTotal += PhDMG;
                            Console.WriteLine();
                            Thread.Sleep(3000);

                            switch (volba)
                            {
                                case "sharp sword":
                                    Health -= 1200 - DMG[Pozice2];
                                    Console.WriteLine("Uděleno maximální poškození!");
                                    Console.WriteLine();
                                    Console.WriteLine("Monstrum obdrželo 1200 poškození!");
                                    break;
                                case "fire aspect":
                                    Fire = 5;
                                    break;
                                case "midas sword":
                                    Golden = 1;
                                    break;
                                case "combo sword":
                                    Health -= DMG[Pozice2] * (0.2 * Combo);
                                    Combo++;
                                    break;
                                case "syphon sword":
                                    if (Shield > 0)
                                        Shield--;
                                    break;
                            }
                        }
                        if (Pozice2 > 6)
                        {
                            MgDMG = DMG[Pozice2] - (0.2 * DMG[Pozice2] * Shield);
                            MgDMG = Math.Round(MgDMG, 10);
                            Health -= MgDMG;
                            Health = Math.Round(Health, 10);
                            if (Shield > 1)
                                Console.WriteLine("Útok nebyl zcela nejeffektivnější!");
                            Console.WriteLine();
                            Console.WriteLine("Monstrum obdrželo {0} poškození!", MgDMG);
                            DMGTotal += MgDMG;
                            Console.WriteLine();
                            Thread.Sleep(3000);
                            switch (volba)
                            {
                                case "potion of poison":
                                    Poison = 5;
                                    break;
                                case "steel breaker":
                                    if (Armor > 0)
                                        Armor--;
                                    break;
                                case "golden stick":
                                    Golden = 1;
                                    break;
                                case "wizard's wand":
                                    Health -= 1200 - DMG[Pozice2];
                                    Console.WriteLine("Uděleno maximální poškození!");
                                    Console.WriteLine();
                                    Console.WriteLine("Monstrum obdrželo 1200 poškození!");
                                    break;
                            }
                        }
                        if (Fire > 0)
                        {
                            Console.WriteLine("Monstrum Hoří:");
                            Console.WriteLine();
                            double FireDMG = DMG[Pozice2] / 5;
                            Console.WriteLine(" - {0} životů", FireDMG);
                            Health -= FireDMG;
                            Fire--;
                            Thread.Sleep(1500);
                        }
                        if (Poison > 0)
                        {
                            Console.WriteLine("Monstrum je otráveno!:");
                            Console.WriteLine();
                            double PoisonDMG = DMG[Pozice2] / 5;
                            Console.WriteLine(" - {0} životů", PoisonDMG);
                            Health -= PoisonDMG;
                            Poison--;
                            Thread.Sleep(1500);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Tuto Zbraň nemáš zakoupenou!");
                        Thread.Sleep(2000);
                        Console.WriteLine();
                        goto Volba;
                    }
                }
                else
                {
                    Console.WriteLine("Neplatná volba!");
                    Console.WriteLine();
                    goto Volba;
                }
            }
            break;
    }
} while (Health > 0);
Console.WriteLine();
Console.WriteLine("Monstrum Zabito!");
Console.ForegroundColor = ConsoleColor.DarkYellow;
double Gain = 100 * (1 + Kills * 0.1);
Gain = Math.Round(Gain, 10);
Zlato += Gain;
GoldTotal += Gain;
Console.WriteLine("+ {0} Zlata!", Gain);
if (Golden == 1)
{
    Zlato += Gain;
    Console.WriteLine("Midas: + {0} Zlata!", Gain);
    GoldTotal += Gain;
}
Console.ForegroundColor = ConsoleColor.White;
Kills++;
Fire = 0;
Poison = 0;
Combo = 0;
Golden = 0;
Thread.Sleep(3000);
Console.Clear();
goto NewZombie;


