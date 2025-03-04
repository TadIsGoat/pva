namespace StackOverflow6
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            while (true)
            {
                /* Tadeáš Vykopal
                * II.B
                * datum startu: 31.5.2023
                * datum dokončení: 4.6.2023
                * PVA, název: Subjekt 61137
                */

                //PROMĚNNÉ
                string[] inventory = new string[3];
                inventory[0] = "";
                inventory[1] = "";
                inventory[2] = "";
                int goodPrisonerMeter = 5;
                string konec = "";
                string repeat = "";
                string choice = "";
                string choiceFlus = "";
                string choicePapir = "";
                string choiceSpanek = "";
                string choiceFight = "";
                string doorlock = "";

                info();

                //SCENE 1 - INTRO
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Rok 2743, OutLands, Laboratoře IMC - Probouzíš se v laboratorním křesle, máš bolest hlavy, jsi ve svěrací kazajce, nevíš kdo jsi, ani proč jsi tu. Do místnosti vejdou dva muži, jeden z nich si sedne k počítači v rohu místnosti, druhý tě začne odpoutávat od křesla. Mám žízeň - řekneš mu. Muž se na tebe podívá, poušklíbne se a pevně ti utáhne kazajku. Stojí přímo před tebou, je ta blízko, že zpod bílého pláště mu kouká tetování draka.");
                    Console.WriteLine("Plivneš mu do tváře? [ano/ne]");
                    choiceFlus = Console.ReadLine().ToLower();

                    if (choiceFlus == "ano")
                    {
                        goodPrisonerMeter = -2;
                        Console.WriteLine("\nFlus! - přímo do tváře, muž se zamračí. Za tebou! - ozve se hlas v tvé hlavě, v ten moment tě druhý muž praští do zátylku a ty zaskuhráš bolestí.");
                        Console.WriteLine("====================");
                        Console.WriteLine("Pokračujte stisknutím klávesy");
                        Console.ReadKey();
                        break;
                    }
                    if (choiceFlus == "ne")
                    {
                        Console.WriteLine("\n...");
                        Console.WriteLine("Nic nedostaneš, řekne muž, nemáš nárok.");
                        Console.WriteLine("====================");
                        Console.WriteLine("Pokračujte stisknutím klávesy");
                        Console.ReadKey();
                        break;
                    }
                    if (choiceFlus == ".info")
                    {
                        info();
                    }
                    if (choiceFlus == ".inv")
                    {
                        Console.Clear();
                        Console.WriteLine("");
                        Console.WriteLine("====================");
                        for (int i = 0; i < inventory.Length; i++)
                        {
                            Console.WriteLine((i + 1) + ". " + inventory[i]);
                        }
                        Console.WriteLine("====================");
                        Console.WriteLine("Pokračujte stisknutím klávesy");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    if (choiceFlus == ".konec")
                    {
                        Console.Clear();
                        while (true)
                        {
                            Console.WriteLine("Opravdu chceš ukončit hru?[ano/ne]");
                            konec = Console.ReadLine().ToLower();
                            if (konec == "ano")
                            {
                                Environment.Exit(0);
                            }
                            if (konec == "ne")
                            {
                                Console.Clear();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Neplatná odpověď!");
                            }
                        }
                    }
                    else
                    {
                        Thread.Sleep(2000);
                    }
                }

                //SCENE 2 - cesta k cele
                Console.Clear();
                Console.WriteLine("Oba muži tě zvednou za ramena, vyvedou ven z místnosti, pak dlouho tmavou chodbou. V budově je spousta místností, některé jsou prosklené, stejné jako ta, ze které tě právě vyvedli, jiné mají mříže a jsou očíslované. Najednou zastavíte u místnosti s mřížemi s číslem 61137, muži ti sundají kazajku a vstrčí tě dovnitř.");
                Console.WriteLine("====================");
                Console.WriteLine("Pokračujte stisknutím klávesy");
                Console.ReadKey();

                //SCENE 3 - v cele
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Vevnitř je tvrdá postel, záchod a umyvadlo.");
                    Console.WriteLine("Využiješ postel a půjdeš spát? [ano/ne]");
                    choiceSpanek = Console.ReadLine().ToLower();

                    if (choiceSpanek == "ano")
                    {
                        goodPrisonerMeter++;
                        Console.WriteLine("\nshhhhhh");
                        Console.WriteLine("====================");
                        Console.WriteLine("Pokračujte stisknutím klávesy");
                        Console.ReadKey();
                        break;
                    }
                    if (choiceSpanek == "ne")
                    {
                        Console.WriteLine("\nSedneš si na postel a snažíš se si vzpomenout kdo vlastně jsi, ale ani po hodině tě nic nenapadá.");
                        Console.WriteLine("====================");
                        Console.WriteLine("Pokračujte stisknutím klávesy");
                        Console.ReadKey();
                        while (true)
                        {
                            Console.Clear();
                            Console.Write("Najednou přijde muž v bílém plášti a začne si potichu povídat se strážným, který stojí před tvou celou, ale doteď nebyl ani vidět ani slyšet. V ruce má složku, je na ní napsané: Subjekt 61137,");
                            Console.Write(" TOP SECRET", Console.ForegroundColor = ConsoleColor.Red);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("\nBudeš předstírat, že spíš, nebo se pokusíš získat informace? [spánek/informace]");
                            choice = Console.ReadLine().ToLower();

                            if (choice == "spánek")
                            {
                                Console.WriteLine("\nMluví spolu tak potichu, že nic neslyšíš. Po pár minutách muž v plášti odejde, tebe už přemůže únava a tak usneš.");
                                Console.WriteLine("====================");
                                Console.WriteLine("Pokračujte stisknutím klávesy");
                                Console.ReadKey();
                                break;
                            }
                            if (choice == "informace")
                            {
                                goodPrisonerMeter--;
                                Console.WriteLine("\nHej! - zvoláš na muže v plášti, ale on se na tebe jen podívá a dál tě ignoruje. Kdo jsem? Co se mnou chcete udělat? - zvýšíš hlas.");
                                Console.WriteLine("====================");
                                Console.WriteLine("Pokračujte stisknutím klávesy");
                                Console.ReadKey();
                                Console.Clear();
                                Console.WriteLine("Jsi subjekt 61137 a zatím jsi v našich experimentech jedno velké sklamání. Takže je jenom na mně co s tebou bude. - pousměje se muž a se strážným se břiblíží k mřížím cely.");
                                Console.WriteLine("====================");
                                Console.WriteLine("Pokračujte stisknutím klávesy");
                                Console.ReadKey();
                                while (true)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Jaké experimenty? - zeptáš a v ten moment si všimneš, že muž je dost blízko k ukradení složky, kterou přinesl a možná něco zjistit. [ukrást/nekrást]");
                                    choice = Console.ReadLine().ToLower();
                                    choicePapir = choice;

                                    if (choice == "ukrást")
                                    {
                                        goodPrisonerMeter = -2;
                                        Console.WriteLine("\nStráže!!! - zařve muž v momentě kdy mu vytrhneš složku z ruky. Rychle z ní vythrneš několik papírů a hodíš je pod postel. Do cely vrazí strážný a omráčí tě.");
                                        Console.WriteLine("====================");
                                        Console.WriteLine("Pokračujte stisknutím klávesy");
                                        Console.ReadKey();
                                        break;
                                    }
                                    if (choice == "nekrást")
                                    {
                                        Console.WriteLine("\nJiž brzy si zase vzpomeneš - řekne muž v plášti a odejde.");
                                        Console.WriteLine("====================");
                                        Console.WriteLine("Pokračujte stisknutím klávesy");
                                        Console.ReadKey();
                                        Console.Clear();
                                        Console.WriteLine("\nJsou ty experimenty důvod, proč si nic nepamatuješ? - tahle otázka ti bloudí v hlavě dokud neusneš.");
                                        Console.WriteLine("====================");
                                        Console.WriteLine("Pokračujte stisknutím klávesy");
                                        Console.ReadKey();
                                        break;
                                    }
                                    if (choice == ".info")
                                    {
                                        info();
                                    }
                                    if (choice == ".inv")
                                    {
                                        Console.Clear();
                                        Console.WriteLine("");
                                        Console.WriteLine("====================");
                                        for (int i = 0; i < inventory.Length; i++)
                                        {
                                            Console.WriteLine((i + 1) + ". " + inventory[i]);
                                        }
                                        Console.WriteLine("====================");
                                        Console.WriteLine("Pokračujte stisknutím klávesy");
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                    if (choice == ".konec")
                                    {
                                        Console.Clear();
                                        while (true)
                                        {
                                            Console.WriteLine("Opravdu chceš ukončit hru?[ano/ne]");
                                            konec = Console.ReadLine().ToLower();
                                            if (konec == "ano")
                                            {
                                                Environment.Exit(0);
                                            }
                                            if (konec == "ne")
                                            {
                                                Console.Clear();
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Neplatná odpověď!");
                                            }
                                        }
                                    }
                                    else
                                    {
                                        Thread.Sleep(2000);
                                    }
                                }
                                break;
                            }
                            if (choice == ".info")
                            {
                                info();
                            }
                            if (choice == ".inv")
                            {
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("====================");
                                for (int i = 0; i < inventory.Length; i++)
                                {
                                    Console.WriteLine((i + 1) + ". " + inventory[i]);
                                }
                                Console.WriteLine("====================");
                                Console.WriteLine("Pokračujte stisknutím klávesy");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            if (choice == ".konec")
                            {
                                Console.Clear();
                                while (true)
                                {
                                    Console.WriteLine("Opravdu chceš ukončit hru?[ano/ne]");
                                    konec = Console.ReadLine().ToLower();
                                    if (konec == "ano")
                                    {
                                        Environment.Exit(0);
                                    }
                                    if (konec == "ne")
                                    {
                                        Console.Clear();
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Neplatná odpověď!");
                                    }
                                }
                            }
                            else
                            {
                                Thread.Sleep(2000);
                            }
                        }
                        break;
                    }
                    if (choiceSpanek == ".info")
                    {
                        info();
                    }
                    if (choiceSpanek == ".inv")
                    {
                        Console.Clear();
                        Console.WriteLine("");
                        Console.WriteLine("====================");
                        for (int i = 0; i < inventory.Length; i++)
                        {
                            Console.WriteLine((i + 1) + ". " + inventory[i]);
                        }
                        Console.WriteLine("====================");
                        Console.WriteLine("Pokračujte stisknutím klávesy");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    if (choiceSpanek == ".konec")
                    {
                        Console.Clear();
                        while (true)
                        {
                            Console.WriteLine("Opravdu chceš ukončit hru?[ano/ne]");
                            konec = Console.ReadLine().ToLower();
                            if (konec == "ano")
                            {
                                Environment.Exit(0);
                            }
                            if (konec == "ne")
                            {
                                Console.Clear();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Neplatná odpověď!");
                            }
                        }
                    }
                    else
                    {
                        Thread.Sleep(2000);
                    }
                }

                //SCENE 4 - Probuzení

                Console.Clear();
                if (choiceFlus == "ano")
                {
                    Console.WriteLine("\nProbudí tě rána jídelního tácku, který zrovna přinesl strážný. Na tácku je sklenka vody, talíř směsi připomínají cement a lžička.");
                    Console.WriteLine("====================");
                    Console.WriteLine("Pokračujte stisknutím klávesy");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("\nTo jsi ty?!? - vykřikne strážný když se na tebe otočí. A hned taky víš proč tak zuří, je to ten strážný, který včera schytal plivanec do tváře... Zamračí se na tebe a chvilku přemýšlí, pak se otočí zpátky k tácku, sebere ho i s jídlem a než se stihneš zvednout z postele tak se za ním zabouchnou dveře cely.");
                    Console.WriteLine("====================");
                    Console.WriteLine("Pokračujte stisknutím klávesy");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    while (true)
                    {
                        Console.WriteLine("Probudí tě rána jídelního tácku, který zrovna přinesl muž s dračím tetováním na krku. Na tácku je sklenka vody, talíř směsi připomínají cement a lžička. Dřív než se stihneš probrat tak se za strážným zabouchnou dveře cely.");
                        Console.WriteLine("====================");
                        Console.WriteLine("Pokračujte stisknutím klávesy");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("Po chvíli není po jídle ani stopy");
                        Console.WriteLine("Lžička by se dala ještě nějak použít, schováš si ji pod oblečení?");
                        Console.WriteLine("[ano/ne]");
                        choice = Console.ReadLine().ToLower();

                        if (choice == "ano")
                        {
                            goodPrisonerMeter--;
                            for (int i = 0; i < inventory.Length; i++)
                            {
                                if (inventory[i] == "")
                                {
                                    inventory[i] = "lžička";
                                }
                                break;
                            }
                            Console.WriteLine("\nPrávě jsi získal nový item, inventář zobrazíš příkazem .inv místo odpovídání na jakoukoli otázku.");
                            Console.WriteLine("====================");
                            Console.WriteLine("Pokračujte stisknutím klávesy");
                            Console.ReadKey();
                            break;
                        }
                        if (choice == "ne")
                        {
                            goodPrisonerMeter++;
                            Console.WriteLine("\nLžičku položíš zpátky na tácek");
                            Console.WriteLine("====================");
                            Console.WriteLine("Pokračujte stisknutím klávesy");
                            Console.ReadKey();
                            break;
                        }
                        if (choice == ".info")
                        {
                            info();
                        }
                        if (choice == ".inv")
                        {
                            Console.Clear();
                            Console.WriteLine("");
                            Console.WriteLine("====================");
                            for (int i = 0; i < inventory.Length; i++)
                            {
                                Console.WriteLine((i + 1) + ". " + inventory[i]);
                            }
                            Console.WriteLine("====================");
                            Console.WriteLine("Pokračujte stisknutím klávesy");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        if (choice == ".konec")
                        {
                            Console.Clear();
                            while (true)
                            {
                                Console.WriteLine("Opravdu chceš ukončit hru?[ano/ne]");
                                konec = Console.ReadLine().ToLower();
                                if (konec == "ano")
                                {
                                    Environment.Exit(0);
                                }
                                if (konec == "ne")
                                {
                                    Console.Clear();
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Neplatná odpověď!");
                                }
                            }
                        }
                        else
                        {
                            Thread.Sleep(2000);
                        }
                    }
                }

                if (choicePapir == "ukrást")
                {
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine("Je na čase prozkoumat ty vytržené stránky ze včerejška! - bleskne ti hlavou.");
                        Console.WriteLine("====================");
                        Console.WriteLine("Pokračujte stisknutím klávesy");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("Stránky jsou dvě. Na té první je spousta kolonek, některé jako jméno a věk jsou ale zamazané, jiné jsou zase nevyplněné. Jde přečíst pouze KRYCÍ JMÉNO: Voidwalker, ÚČEL: technologie interdimensionálních přeskoků, HODNOCENÍ: Neúspěch - to je zřejmě důvod, proč si nic nepamatuješ. Na druhé stránce stojí: Bude-li subjekt projevovat neúspěch i u nadcházejícího pokusu, bude určen k terminaci a převezen na planetu Solace.");
                        Console.WriteLine("Zalapáš po dechu - tomu musím zabránit, nemůžu dovolit, aby ten další pokus provedli!");
                        Console.WriteLine("====================");
                        Console.WriteLine("Pokračujte stisknutím klávesy");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("Chceš si vytržené stránky uložit do inventáře?");
                        Console.WriteLine("[ano/ne]");
                        choice = Console.ReadLine().ToLower();

                        if (choice == "ano")
                        {
                            for (int i = 0; i < inventory.Length; i++)
                            {
                                if (inventory[i] == "")
                                {
                                    inventory[i] = "stránky";
                                }
                                break;
                            }
                            Console.WriteLine("\nPrávě jsi získal nový item, inventář zobrazíš příkazem .inv místo odpovídání na jakoukoli otázku.");
                            Console.WriteLine("====================");
                            Console.WriteLine("Pokračujte stisknutím klávesy");
                            Console.ReadKey();
                            break;
                        }
                        if (choice == "ne")
                        {
                            Console.WriteLine("\nZmuchláš stránky a hodíš je zpátky pod postel.");
                            Console.WriteLine("====================");
                            Console.WriteLine("Pokračujte stisknutím klávesy");
                            Console.ReadKey();
                            break;
                        }
                        if (choice == ".info")
                        {
                            info();
                        }
                        if (choice == ".inv")
                        {
                            Console.Clear();
                            Console.WriteLine("");
                            Console.WriteLine("====================");
                            for (int i = 0; i < inventory.Length; i++)
                            {
                                Console.WriteLine((i + 1) + ". " + inventory[i]);
                            }
                            Console.WriteLine("====================");
                            Console.WriteLine("Pokračujte stisknutím klávesy");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        if (choice == ".konec")
                        {
                            Console.Clear();
                            while (true)
                            {
                                Console.WriteLine("Opravdu chceš ukončit hru?[ano/ne]");
                                konec = Console.ReadLine().ToLower();
                                if (konec == "ano")
                                {
                                    Environment.Exit(0);
                                }
                                if (konec == "ne")
                                {
                                    Console.Clear();
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Neplatná odpověď!");
                                }
                            }
                        }
                        else
                        {
                            Thread.Sleep(2000);
                        }
                    }
                }

                //SCENE 5 - pokus

                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Najednou do tvé cely vpadnou dva muži, popadnou tě za ramena a nesou tě chodbou pryč. V ten moment se ti zase ozve v hlavě hlas, říká: Bojuj!");
                    Console.WriteLine("Pokusíš se bojovat? [ano/ne]");
                    choiceFight = Console.ReadLine().ToLower();

                    if (choiceFight == "ano")
                    {
                        Console.WriteLine("\nJednomu z mužů se vykubneš, druhému dáš volnou rukou pěstí.");
                        Console.WriteLine("====================");
                        Console.WriteLine("Utíkej stisknutím klávesy!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                    if (choiceFight == "ne")
                    {
                        goodPrisonerMeter++;
                        Console.WriteLine("\nNěkdo je v mé hlavě! - zařveš na muže - Mám v hlavě hlas!");
                        Console.WriteLine("====================");
                        Console.WriteLine("Pokračujte stisknutím klávesy");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("\nMuži tě ale ignorují a dotáhnou tě až do nějaké laboratoře, větší než v té včerejší. Nasadí ti svěrací kazajku a připoutají ke křeslu.");
                        Console.WriteLine("====================");
                        Console.WriteLine("Pokračujte stisknutím klávesy");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("\nDo místnosti vejde další osoba, dá ti injekci a hned na to usneš...");
                        Console.WriteLine("====================");
                        Console.WriteLine("Pokračujte stisknutím klávesy");
                        Console.ReadKey();
                        Console.Clear();

                        //ENDING 1: Propuštění
                        if (goodPrisonerMeter == 8)
                        {
                            Console.WriteLine("\nProbudí tě řev - Je k ničemu! Odvést!");
                            Console.WriteLine("Na exekuci šéfe? - odvětí stráže z rohu místnosti.");
                            Console.WriteLine("Ne, za tu injekci nestojí.");
                            Console.WriteLine("====================");
                            Console.WriteLine("Pokračujte stisknutím klávesy");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("KONEC HRY!");
                            Console.WriteLine("Propustili tě!");
                            Console.WriteLine("Ale stále nevíš kdo jsi...");
                            Console.WriteLine("====================");
                            Console.WriteLine("Hru ukončíte stisknutím klávesy");
                            Console.ReadKey();
                            Console.Clear();
                            Console.Write("Ukončování");
                            Thread.Sleep(1000);
                            Console.Write(".");
                            Thread.Sleep(1000);
                            Console.Write(".");
                            Thread.Sleep(1000);
                            Console.Write(".");
                            Environment.Exit(0);
                        }
                        else
                        {
                            //ENDING 2: Exekuce
                            Console.WriteLine("KONEC HRY!");
                            Console.WriteLine("Nepodařilo se ti utéct exekuci!");
                            Console.WriteLine("Better luck next time");
                            Console.WriteLine("====================");
                            Console.WriteLine("Hru ukončíte stisknutím klávesy");
                            Console.ReadKey();
                            Console.Clear();
                            Console.Write("Ukončování");
                            Thread.Sleep(1000);
                            Console.Write(".");
                            Thread.Sleep(1000);
                            Console.Write(".");
                            Thread.Sleep(1000);
                            Console.Write(".");
                            Environment.Exit(0);
                        }
                        break;
                    }
                    if (choiceFight == ".info")
                    {
                        info();
                    }
                    if (choiceFight == ".inv")
                    {
                        Console.Clear();
                        Console.WriteLine("");
                        Console.WriteLine("====================");
                        for (int i = 0; i < inventory.Length; i++)
                        {
                            Console.WriteLine((i + 1) + ". " + inventory[i]);
                        }
                        Console.WriteLine("====================");
                        Console.WriteLine("Pokračujte stisknutím klávesy");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    if (choiceFight == ".konec")
                    {
                        Console.Clear();
                        while (true)
                        {
                            Console.WriteLine("Opravdu chceš ukončit hru?[ano/ne]");
                            konec = Console.ReadLine().ToLower();
                            if (konec == "ano")
                            {
                                Environment.Exit(0);
                            }
                            if (konec == "ne")
                            {
                                Console.Clear();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Neplatná odpověď!");
                            }
                        }
                    }
                    else
                    {
                        Thread.Sleep(2000);
                    }
                }

                //SCENE 6 - útěk

                Console.WriteLine("Dva strážné se ti podařilo setřást, ale ještě z toho nejsi venku, musíš odtud najít cestu!");
                Console.WriteLine("====================");
                Console.WriteLine("Pokračujte stisknutím klávesy");
                Console.ReadKey();
                Console.Clear();
                do
                {
                    Console.WriteLine("Narazíš na velké dveře s elekrickým zámkem, musíš ho nějak rozbít!");
                    Console.WriteLine("Pokud máš v inventáři item, který se dá použít, napiš jeho číslo!");
                    choice = Console.ReadLine().ToLower();

                    if (choice == "1")
                    {
                        if (inventory[0] == "lžička")
                        {
                            doorlock = "done";
                            Console.WriteLine("Podařilo se ti rozbít zámek, zahazuješ lžičku a utíkáš dveřmi dál. V budově se mezitím rozsvítily nouzová světla a začly houkat sirény.");
                            Console.WriteLine("====================");
                            Console.WriteLine("Pokračujte stisknutím klávesy");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            //ENDING 3: smrt
                            Console.WriteLine("Nemáš čím rozbít zámek! začneš do něj kopat, ale za tvými zády se objeví strážný a zastřelí tě.");
                            Console.WriteLine("====================");
                            Console.WriteLine("Pokračujte stisknutím klávesy");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("KONEC HRY!");
                            Console.WriteLine("Nepodařilo se ti utéct.");
                            Console.WriteLine("Skill issue!");
                            Console.WriteLine("====================");
                            Console.WriteLine("Hru ukončíte stisknutím klávesy");
                            Console.ReadKey();
                            Console.Clear();
                            Console.Write("Ukončování");
                            Thread.Sleep(1000);
                            Console.Write(".");
                            Thread.Sleep(1000);
                            Console.Write(".");
                            Thread.Sleep(1000);
                            Console.Write(".");
                            Environment.Exit(0);
                        }
                        break;
                    }
                    if (choice == "2")
                    {
                        if (inventory[1] == "lžička")
                        {
                            doorlock = "done";
                            Console.WriteLine("Podařilo se ti rozbít zámek, zahazuješ lžičku a utíkáš dveřmi dál. V budově se mezitím rozsvítily nouzová světla.");
                            Console.WriteLine("====================");
                            Console.WriteLine("Pokračujte stisknutím klávesy");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            //ENDING 3: smrt
                            Console.WriteLine("Nemáš čím rozbít zámek! začneš do něj kopat, ale za tvými zády se objeví strážný a zastřelí tě.");
                            Console.WriteLine("====================");
                            Console.WriteLine("Pokračujte stisknutím klávesy");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("KONEC HRY!");
                            Console.WriteLine("Nepodařilo se ti utéct.");
                            Console.WriteLine("Skill issue!");
                            Console.WriteLine("====================");
                            Console.WriteLine("Hru ukončíte stisknutím klávesy");
                            Console.ReadKey();
                            Console.Clear();
                            Console.Write("Ukončování");
                            Thread.Sleep(1000);
                            Console.Write(".");
                            Thread.Sleep(1000);
                            Console.Write(".");
                            Thread.Sleep(1000);
                            Console.Write(".");
                            Environment.Exit(0);
                        }
                        break;
                    }
                    if (choice == "3")
                    {
                        if (inventory[2] == "lžička")
                        {
                            doorlock = "done";
                            Console.WriteLine("Podařilo se ti rozbít zámek, zahazuješ lžičku a utíkáš dveřmi dál. V budově se mezitím rozsvítily nouzová světla.");
                            Console.WriteLine("====================");
                            Console.WriteLine("Pokračujte stisknutím klávesy");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            //ENDING 3: smrt
                            Console.WriteLine("Nemáš čím rozbít zámek! začneš do něj kopat, ale za tvými zády se objeví strážný a zastřelí tě.");
                            Console.WriteLine("====================");
                            Console.WriteLine("Pokračujte stisknutím klávesy");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("KONEC HRY!");
                            Console.WriteLine("Nepodařilo se ti utéct.");
                            Console.WriteLine("Skill issue!");
                            Console.WriteLine("====================");
                            Console.WriteLine("Hru ukončíte stisknutím klávesy");
                            Console.ReadKey();
                            Console.Clear();
                            Console.Write("Ukončování");
                            Thread.Sleep(1000);
                            Console.Write(".");
                            Thread.Sleep(1000);
                            Console.Write(".");
                            Thread.Sleep(1000);
                            Console.Write(".");
                            Environment.Exit(0);
                        }
                        break;
                    }
                    if (choice == ".info")
                    {
                        info();
                    }
                    if (choice == ".inv")
                    {
                        Console.Clear();
                        Console.WriteLine("");
                        Console.WriteLine("====================");
                        for (int i = 0; i < inventory.Length; i++)
                        {
                            Console.WriteLine((i + 1) + ". " + inventory[i]);
                        }
                        Console.WriteLine("====================");
                        Console.WriteLine("Pokračujte stisknutím klávesy");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    if (choice == ".konec")
                    {
                        Console.Clear();
                        while (true)
                        {
                            Console.WriteLine("Opravdu chceš ukončit hru?[ano/ne]");
                            konec = Console.ReadLine().ToLower();
                            if (konec == "ano")
                            {
                                Environment.Exit(0);
                            }
                            if (konec == "ne")
                            {
                                Console.Clear();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Neplatná odpověď!");
                            }
                        }
                    }
                    else
                    {
                        Thread.Sleep(2000);
                    }
                } while(doorlock != "done");

                //SCENE 7 - decisions

                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Narazíš na rozcestí, jedna cesta do leva, jedna cesta doprava, žádné cedule, hned za rozcestím je roh, takže nevidíš čím cesta pokračuje. Rozejdeš se doleva, ale v hlavě se ti ozve známý hlas - Jdi doprava!");
                    Console.WriteLine("Budeš věřit hlasu, nebo ne?");
                    Console.WriteLine("[levá/pravá]");
                    choice = Console.ReadLine().ToLower();

                    if (choice == "levá")
                    {
                        //ENDING 4: smrt při útěku
                        Console.WriteLine("\nRozběhneš se doleva, za rohem narazíš na několik strážných.");
                        Console.WriteLine("====================");
                        Console.WriteLine("Pokračujte stisknutím klávesy");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("KONEC HRY!");
                        Console.WriteLine("Chytili tě při útěku!");
                        Console.WriteLine("Příště vol jinak!");
                        Console.WriteLine("====================");
                        Console.WriteLine("Hru ukončíte stisknutím klávesy");
                        Console.ReadKey();
                        Console.Clear();
                        Console.Write("Ukončování");
                        Thread.Sleep(1000);
                        Console.Write(".");
                        Thread.Sleep(1000);
                        Console.Write(".");
                        Thread.Sleep(1000);
                        Console.Write(".");
                        Environment.Exit(0);
                        break;
                    }
                    if (choice == "pravá")
                    {
                        //ENDING 5: útěk!
                        Console.WriteLine("\nRozbehneš se doprava, zajdeš za roh a vidíš dveře, tentokrát obyčejné.");
                        Console.WriteLine("====================");
                        Console.WriteLine("Vykopni dveře stisknutím klávesy");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("Nepodařilo se.");
                        Console.WriteLine("====================");
                        Console.WriteLine("Zkus to ještě jednou!");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("Panty zaskřípou");
                        Console.WriteLine("====================");
                        Console.WriteLine("Kopni ještě!");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("KONEC HRY!");
                        Console.WriteLine("Podařilo se ti utéct!");
                        Console.WriteLine("Děkuji, že jsi hrál/a moji hru.");
                        Console.WriteLine("====================");
                        Console.WriteLine("Hru ukončíte stisknutím klávesy");
                        Console.ReadKey();
                        Console.Clear();
                        Console.Write("Ukončování");
                        Thread.Sleep(1000);
                        Console.Write(".");
                        Thread.Sleep(1000);
                        Console.Write(".");
                        Thread.Sleep(1000);
                        Console.Write(".");
                        Environment.Exit(0);
                        break;
                    }
                    if (choice == ".info")
                    {
                        info();
                    }
                    if (choice == ".inv")
                    {
                        Console.Clear();
                        Console.WriteLine("");
                        Console.WriteLine("====================");
                        for (int i = 0; i < inventory.Length; i++)
                        {
                            Console.WriteLine((i + 1) + ". " + inventory[i]);
                        }
                        Console.WriteLine("====================");
                        Console.WriteLine("Pokračujte stisknutím klávesy");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    if (choice == ".konec")
                    {
                        Console.Clear();
                        while (true)
                        {
                            Console.WriteLine("Opravdu chceš ukončit hru?[ano/ne]");
                            konec = Console.ReadLine().ToLower();
                            if (konec == "ano")
                            {
                                Environment.Exit(0);
                            }
                            if (konec == "ne")
                            {
                                Console.Clear();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Neplatná odpověď!");
                            }
                        }
                    }
                    else
                    {
                        Thread.Sleep(2000);
                    }
                }
            }
        }

        //MOŽNOSTI
        static void info()
        {
            Console.WriteLine("========== Subjekt 61137 ==========");
            Console.WriteLine("\nText based příběhová hra, vytvořil Tadeáš Vykopal 2023");
            Console.WriteLine("Volte pečlivě z možností v hranatých závorkách[] nebo vyberte z následujících možností, každá Vaše akce může mít následky.");
            Console.WriteLine("Další možnosti:");
            Console.WriteLine(".info - zobrazí informace");
            Console.WriteLine(".inv - zobrazí tvůj inventář");
            Console.WriteLine(".konec - vypne hru");
            Console.WriteLine("");
            Console.WriteLine("====================");
            Console.WriteLine("Pokračujte stisknutím libovolné klávesy.");
            Console.ReadKey();
            Console.Clear();
        }
    }
}

/* LAYOUT OTÁZKY

       while (true)
       {
           Console.Clear();
           Console.WriteLine("");
           Console.WriteLine("[ano/ne]");
           choice = Console.ReadLine().ToLower();

           if (choice == "ano")
           {
               Console.WriteLine("\n");
               Console.WriteLine("====================");
               Console.WriteLine("Pokračujte stisknutím klávesy");
               Console.ReadKey();
               break;
           }
           if (choice == "ne")
           {
               Console.WriteLine("\n");
               Console.WriteLine("====================");
               Console.WriteLine("Pokračujte stisknutím klávesy");
               Console.ReadKey();
               break;
           }
           if (choice == ".info")
           {
               info();
           }
           if (choice == ".inv")
           {
               Console.Clear();
               Console.WriteLine("");
               Console.WriteLine("====================");
               for (int i = 0; i < inventory.Length; i++)
               {
                   Console.WriteLine((i + 1) + ". " + inventory[i]);
               }
               Console.WriteLine("====================");
               Console.WriteLine("Pokračujte stisknutím klávesy");
               Console.ReadKey();
               Console.Clear();
           }
           if (choice == ".konec")
           {
               Console.Clear();
               while (true)
               {
                   Console.WriteLine("Opravdu chceš ukončit hru?[ano/ne]");
                   konec = Console.ReadLine().ToLower();
                   if (konec == "ano")
                   {
                       Environment.Exit(0);
                   }
                   if (konec == "ne")
                   {
                       Console.Clear();
                       break;
                   }
                   else
                   {
                       Console.WriteLine("Neplatná odpověď!");
                   }
               }
           }
           else
           {
               Thread.Sleep(2000);
           }
       }
*/

/* LAYOUT konverzace

        Console.WriteLine("");
        Console.WriteLine("====================");
        Console.WriteLine("Pokračujte stisknutím klávesy");
        Console.ReadKey();
        Console.Clear();
*/

/* LAYOUT ukládání do inventáře

        for (int i = 0; i < inventory.Length; i++)
            {
                if (inventory[i] == "")
                {
                    inventory[i] = "";
                }
                break;
            }
*/

/*LAYOUT ENDING
        
        Console.WriteLine("KONEC HRY!");
        Console.WriteLine("");
        Console.WriteLine("...");
        Console.WriteLine("====================");
        Console.WriteLine("Hru ukončíte stisknutím klávesy");
        Console.ReadKey();
        Console.Clear();
        Console.Write("Ukončování");
        Thread.Sleep(1000);
        Console.Write(".");
        Thread.Sleep(1000);
        Console.Write(".");
        Thread.Sleep(1000);
        Console.Write(".");
        Environment.Exit(0);
*/