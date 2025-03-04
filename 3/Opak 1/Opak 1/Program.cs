Console.WriteLine("Zadej řetězce a stiskni ENTER");

//proměnné

int pocetRetezcu = 0;
double avg = 0;
string retezec = "";
string nejdelsiRetezec = "";
string nejkratsiRetezec = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";

while(true)
{
    retezec = Console.ReadLine();
    pocetRetezcu++;
    avg += retezec.Length;
    if (retezec == "")
    {
        break;
    }
    if (retezec.Length > nejdelsiRetezec.Length)
    {
        nejdelsiRetezec = retezec;
    }
    if (retezec.Length < nejkratsiRetezec.Length)
    {
        nejkratsiRetezec = retezec;
    }
}

avg = avg / (pocetRetezcu - 1);
Console.WriteLine("Celkem řetězců: " + (pocetRetezcu - 1));
Console.WriteLine($"Průměrná délka: {avg}");
Console.WriteLine("Nejdelší řetězec: " + nejdelsiRetezec);
Console.WriteLine("Nejkratší řetězec: " + nejkratsiRetezec);