Console.WriteLine("---ROZVRH HODIN---");
Console.WriteLine("");

/*příkazy*/
Console.WriteLine("Menu:");
Console.WriteLine("!Create - Vytvoří nový rozrh.");
Console.WriteLine("!Fin - Ukončí program");
Console.WriteLine("!Menu - Zobrazí menu");
Console.WriteLine("!Submenu - Zobrazí submenu");

reset:

/*proměnné*/
string prikaz;
string tridaNazev = "není vytvořena žádná třída";
/*dny*/
int pondeli;
int utery;
int streda;
int ctvrtek;
int patek;
/*hodiny*/
string pondeli1 = "";
string pondeli2 = "";
string pondeli3 = "";
string pondeli4 = "";
string pondeli5 = "";
string pondeli6 = "";
string pondeli7 = "";
string pondeli8 = "";
string utery1 = "";
string utery2 = "";
string utery3 = "";
string utery4 = "";
string utery5 = "";
string utery6 = "";
string utery7 = "";
string utery8 = "";
string streda1 = "";
string streda2 = "";
string streda3 = "";
string streda4 = "";
string streda5 = "";
string streda6 = "";
string streda7 = "";
string streda8 = "";
string ctvrtek1 = "";
string ctvrtek2 = "";
string ctvrtek3 = "";
string ctvrtek4 = "";
string ctvrtek5 = "";
string ctvrtek6 = "";
string ctvrtek7 = "";
string ctvrtek8 = "";
string patek1 = "";
string patek2 = "";
string patek3 = "";
string patek4 = "";
string patek5 = "";
string patek6 = "";
string patek7 = "";
string patek8 = "";

prikaz = Console.ReadLine();
do
{

    /*vytvoreni rozvrhu*/
    if (prikaz == "!Create")
    {
    create:
        /*nazev*/
        Console.Write("Zadejte název třídy (1-5 znaků): ");
        tridaNazev = Console.ReadLine();
        if ((tridaNazev.Length >= 5) || (tridaNazev.Length <= 0))
        {
            Console.WriteLine("Neplatné");
            goto create;
        }
        /*hodiny*/
        Console.Write("Zadejte 1. hodinu v pondělí: ");
        pondeli1 = Console.ReadLine();
        Console.Write("Zadejte 2. hodinu v pondělí: ");
        pondeli2 = Console.ReadLine();
        Console.Write("Zadejte 3. hodinu v pondělí: ");
        pondeli3 = Console.ReadLine();
        Console.Write("Zadejte 4. hodinu v pondělí: ");
        pondeli4 = Console.ReadLine();
        Console.Write("Zadejte 5. hodinu v pondělí: ");
        pondeli5 = Console.ReadLine();
        Console.Write("Zadejte 6. hodinu v pondělí: ");
        pondeli6 = Console.ReadLine();
        Console.Write("Zadejte 7. hodinu v pondělí: ");
        pondeli7 = Console.ReadLine();
        Console.Write("Zadejte 8. hodinu v pondělí: ");
        pondeli8 = Console.ReadLine();

        Console.Write("Zadejte 1. hodinu v úterý: ");
        utery1 = Console.ReadLine();
        Console.Write("Zadejte 2. hodinu v úterý: ");
        utery2 = Console.ReadLine();
        Console.Write("Zadejte 3. hodinu v úterý: ");
        utery3 = Console.ReadLine();
        Console.Write("Zadejte 4. hodinu v úterý: ");
        utery4 = Console.ReadLine();
        Console.Write("Zadejte 5. hodinu v úterý: ");
        utery5 = Console.ReadLine();
        Console.Write("Zadejte 6. hodinu v úterý: ");
        utery6 = Console.ReadLine();
        Console.Write("Zadejte 7. hodinu v úterý: ");
        utery7 = Console.ReadLine();
        Console.Write("Zadejte 8. hodinu v úterý: ");
        utery8 = Console.ReadLine();

        Console.Write("Zadejte 1. hodinu ve středu: ");
        streda1 = Console.ReadLine();
        Console.Write("Zadejte 2. hodinu ve středu: ");
        streda2 = Console.ReadLine();
        Console.Write("Zadejte 3. hodinu ve středu: ");
        streda3 = Console.ReadLine();
        Console.Write("Zadejte 4. hodinu ve středu: ");
        streda4 = Console.ReadLine();
        Console.Write("Zadejte 5. hodinu ve středu: ");
        streda5 = Console.ReadLine();
        Console.Write("Zadejte 6. hodinu ve středu: ");
        streda6 = Console.ReadLine();
        Console.Write("Zadejte 7. hodinu ve středu: ");
        streda7 = Console.ReadLine();
        Console.Write("Zadejte 8. hodinu ve středu: ");
        streda8 = Console.ReadLine();

        Console.Write("Zadejte 1. hodinu ve čtvrtek: ");
        ctvrtek1 = Console.ReadLine();
        Console.Write("Zadejte 2. hodinu ve čtvrtek: ");
        ctvrtek2 = Console.ReadLine();
        Console.Write("Zadejte 3. hodinu ve čtvrtek: ");
        ctvrtek3 = Console.ReadLine();
        Console.Write("Zadejte 4. hodinu ve čtvrtek: ");
        ctvrtek4 = Console.ReadLine();
        Console.Write("Zadejte 5. hodinu ve čtvrtek: ");
        ctvrtek5 = Console.ReadLine();
        Console.Write("Zadejte 6. hodinu ve čtvrtek: ");
        ctvrtek6 = Console.ReadLine();
        Console.Write("Zadejte 7. hodinu ve čtvrtek: ");
        ctvrtek7 = Console.ReadLine();
        Console.Write("Zadejte 8. hodinu ve čtvrtek: ");
        ctvrtek8 = Console.ReadLine();

        Console.Write("Zadejte 1. hodinu v pátek: ");
        patek1 = Console.ReadLine();
        Console.Write("Zadejte 2. hodinu v pátek: ");
        patek2 = Console.ReadLine();
        Console.Write("Zadejte 3. hodinu v pátek: ");
        patek3 = Console.ReadLine();
        Console.Write("Zadejte 4. hodinu v pátek: ");
        patek4 = Console.ReadLine();
        Console.Write("Zadejte 5. hodinu v pátek: ");
        patek5 = Console.ReadLine();
        Console.Write("Zadejte 6. hodinu v pátek: ");
        patek6 = Console.ReadLine();
        Console.Write("Zadejte 7. hodinu v pátek: ");
        patek7 = Console.ReadLine();
        Console.Write("Zadejte 8. hodinu v pátek: ");
        patek8 = Console.ReadLine();
        prikaz = Console.ReadLine();
    }
    /*zobrazení menu*/
    if (prikaz == "!Menu")
    {
        Console.WriteLine("Menu:");
        Console.WriteLine("!Create - Vytvoří nový rozrh.");
        Console.WriteLine("!Show (název třídy) - ukáže existující rozvrh");
        Console.WriteLine("!Reset - Smaže rozvrh");
        Console.WriteLine("!Fin - Ukončí program");
        Console.WriteLine("!Menu - Zobrazí menu");
        Console.WriteLine("!Submenu - Zobrazí submenu");
        prikaz = Console.ReadLine();
    }
    /*zobrazení submenu*/
    if (prikaz == "!Submenu")
    {
        Console.WriteLine("Submenu:");
        Console.WriteLine("!Show - Zobrazí existující rozvrh");
        Console.WriteLine("!Reset - Smaže rozvrh");
        Console.WriteLine("!EditName - Úprava názvu třídy");
        Console.WriteLine("!Show (den) - Zobrazí rozvrh pro daný den");
        prikaz = Console.ReadLine();
    }
    /*zobrazení extujícího rozvrhu*/
    if (prikaz == "!Show")
    {
        Console.WriteLine("Jméno třídy: " + tridaNazev);
        Console.WriteLine("");
        Console.WriteLine("---PONDĚLÍ---");
        Console.WriteLine("1. " + pondeli1);
        Console.WriteLine("2. " + pondeli2);
        Console.WriteLine("3. " + pondeli3);
        Console.WriteLine("4. " + pondeli4);
        Console.WriteLine("5. " + pondeli5);
        Console.WriteLine("6. " + pondeli6);
        Console.WriteLine("7. " + pondeli7);
        Console.WriteLine("8. " + pondeli8);

        Console.WriteLine("---ÚTERÝ---");
        Console.WriteLine("1. " + utery1);
        Console.WriteLine("2. " + utery2);
        Console.WriteLine("3. " + utery3);
        Console.WriteLine("4. " + utery4);
        Console.WriteLine("5. " + utery5);
        Console.WriteLine("6. " + utery6);
        Console.WriteLine("7. " + utery7);
        Console.WriteLine("8. " + utery8);

        Console.WriteLine("---STŘEDA---");
        Console.WriteLine("1. " + streda1);
        Console.WriteLine("2. " + streda2);
        Console.WriteLine("3. " + streda3);
        Console.WriteLine("4. " + streda4);
        Console.WriteLine("5. " + streda5);
        Console.WriteLine("6. " + streda6);
        Console.WriteLine("7. " + streda7);
        Console.WriteLine("8. " + streda8);

        Console.WriteLine("---ČTVRTEK---");
        Console.WriteLine("1. " + ctvrtek1);
        Console.WriteLine("2. " + ctvrtek2);
        Console.WriteLine("3. " + ctvrtek3);
        Console.WriteLine("4. " + ctvrtek4);
        Console.WriteLine("5. " + ctvrtek5);
        Console.WriteLine("6. " + ctvrtek6);
        Console.WriteLine("7. " + ctvrtek7);
        Console.WriteLine("8. " + ctvrtek8);

        Console.WriteLine("---PÁTEK---");
        Console.WriteLine("1. " + patek1);
        Console.WriteLine("2. " + patek2);
        Console.WriteLine("3. " + patek3);
        Console.WriteLine("4. " + patek4);
        Console.WriteLine("5. " + patek5);
        Console.WriteLine("6. " + patek6);
        Console.WriteLine("7. " + patek7);
        Console.WriteLine("8. " + patek8);
        prikaz = Console.ReadLine();
    }
    /*smazání rozvrhu*/
    if (prikaz == "!Reset")
    {
        Console.WriteLine("Údaje vymazány");
        goto reset;
    }
    /*úprava jména třídy*/
    if (prikaz == "!EditName")
    {
        Console.Write("Zadejte nové jméno třídy:");
        tridaNazev = Console.ReadLine();
        prikaz = Console.ReadLine();
    }
    /*zobrazení jednotlivých dnů*/
    if (prikaz == "!Show pondělí")
    {
        Console.WriteLine("---PONDĚLÍ---");
        Console.WriteLine("1. " + pondeli1);
        Console.WriteLine("2. " + pondeli2);
        Console.WriteLine("3. " + pondeli3);
        Console.WriteLine("4. " + pondeli4);
        Console.WriteLine("5. " + pondeli5);
        Console.WriteLine("6. " + pondeli6);
        Console.WriteLine("7. " + pondeli7);
        Console.WriteLine("8. " + pondeli8);
        prikaz = Console.ReadLine();
    }
    if (prikaz == "!Show úterý")
    {
        Console.WriteLine("---ÚTERÝ---");
        Console.WriteLine("1. " + utery1);
        Console.WriteLine("2. " + utery2);
        Console.WriteLine("3. " + utery3);
        Console.WriteLine("4. " + utery4);
        Console.WriteLine("5. " + utery5);
        Console.WriteLine("6. " + utery6);
        Console.WriteLine("7. " + utery7);
        Console.WriteLine("8. " + utery8);
        prikaz = Console.ReadLine();
    }
    if (prikaz == "!Show středa")
    {
        Console.WriteLine("---STŘEDA---");
        Console.WriteLine("1. " + streda1);
        Console.WriteLine("2. " + streda2);
        Console.WriteLine("3. " + streda3);
        Console.WriteLine("4. " + streda4);
        Console.WriteLine("5. " + streda5);
        Console.WriteLine("6. " + streda6);
        Console.WriteLine("7. " + streda7);
        Console.WriteLine("8. " + streda8);
        prikaz = Console.ReadLine();
    }
    if (prikaz == "!Show čtvrtek")
    {
        Console.WriteLine("---ČTVRTEK---");
        Console.WriteLine("1. " + ctvrtek1);
        Console.WriteLine("2. " + ctvrtek2);
        Console.WriteLine("3. " + ctvrtek3);
        Console.WriteLine("4. " + ctvrtek4);
        Console.WriteLine("5. " + ctvrtek5);
        Console.WriteLine("6. " + ctvrtek6);
        Console.WriteLine("7. " + ctvrtek7);
        Console.WriteLine("8. " + ctvrtek8);
        prikaz = Console.ReadLine();
    }
    if (prikaz == "!Show pátek")
    {
        Console.WriteLine("---PÁTEK---");
        Console.WriteLine("1. " + patek1);
        Console.WriteLine("2. " + patek2);
        Console.WriteLine("3. " + patek3);
        Console.WriteLine("4. " + patek4);
        Console.WriteLine("5. " + patek5);
        Console.WriteLine("6. " + patek6);
        Console.WriteLine("7. " + patek7);
        Console.WriteLine("8. " + patek8);
        prikaz = Console.ReadLine();
    }
} while (prikaz != "!Fin");


/*
 * ------PROTOTYP-----

Console.Write("Zadejte počet hodin (1-8) - PONDĚLÍ: ");
pondeli = int.Parse(Console.ReadLine());
Console.Write("Zadejte počet hodin (1-8) - ÚTERÝ: ");
utery = int.Parse(Console.ReadLine());
Console.Write("Zadejte počet hodin (1-8) - STŘEDA: ");
streda = int.Parse(Console.ReadLine());
Console.Write("Zadejte počet hodin (1-8) - ČTVRTEK: ");
ctvrtek = int.Parse(Console.ReadLine());
Console.Write("Zadejte počet hodin (1-8) - PÁTEK: ");
patek = int.Parse(Console.ReadLine());
if ((pondeli > 8) || (pondeli < 0) || (utery > 8) || (utery < 0) || (streda > 8) || (streda < 0) || (ctvrtek > 8) || (ctvrtek < 0) || (patek > 8) || (patek < 0))
{
    Console.WriteLine("Nesprávný počet hodin u jednoho z dnů");
    break;
}

*/