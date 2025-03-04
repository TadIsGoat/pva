//výpis slov - všechny musí být uppercase, kvůli pozdějšímu zjednodušení
char[] slovo1 = { 'A', 'U', 'T', 'O'};
char[] slovo2 = { 'A', 'U', 'T', 'O', 'O'};
char[] slovo3 = { 'A', 'U', 'T', 'O', 'O', 'O'};
char[] slovo4 = { 'A', 'U', 'T', 'O', 'O', 'O', 'O'};
char[] slovo5 = { 'A', 'U', 'T', 'O', 'O', 'O', 'O', 'O'};

//výběr hádaného slova
Random random = new Random();
int nahodneCislo = random.Next(1, 6);
char[] hadaneSlovo = { };
if (nahodneCislo == 1)
{
    hadaneSlovo = slovo1;
}
if (nahodneCislo == 2)
{
    hadaneSlovo = slovo2;
}
if (nahodneCislo == 3)
{
    hadaneSlovo = slovo3;
}
if (nahodneCislo == 4)
{
    hadaneSlovo = slovo4;
}
if (nahodneCislo == 5)
{
    hadaneSlovo = slovo5;
}

//určení délky pole pro správně uhodnutá písmena a doplnění "prázdnými políčky"
char[] spravneUhodnuto = new char[hadaneSlovo.Length];
for (int i = 0; i < spravneUhodnuto.Length; i++)
{
    spravneUhodnuto[i] = '_';
}

//proměnné
int trueCounter = 0;
int falseCounter = 0;
bool win = false;

//main
Console.WriteLine("Vítejte ve hře šibenice!");
while (true)
{
    //přivolání boolu s vloženými proměnnými
    if (pokus(hadaneSlovo, falseCounter) == false)
    {
        falseCounter++;
    }
    //kontrola výhry
    if (trueCounter == hadaneSlovo.Length)
    {
        Console.Clear();
        Console.WriteLine("\nVYHRÁL JSI!");
        Environment.Exit(0);
    }
    //kontrola prohry
    if (falseCounter >= 7)
    {
        Console.Clear();
        Console.WriteLine("   ╔═════╗");
        Console.WriteLine("   ║     │");
        Console.WriteLine("   ║     @");
        Console.WriteLine("   ║    ┌┼┐");
        Console.WriteLine("   ║    ┌┴┐");
        Console.WriteLine("   ║   ");
        Console.WriteLine(" ╔═╩═╗ ");
        Console.WriteLine("█████████████");
        Console.WriteLine("\nPROHÁL JSI!");
        break;
    }
}


//pokus
bool pokus(char[] hadaneSlovo, int falseCounter)
{
    //výpis šibenice pro jednotlivý počet pokusů (poslední pokus je vypsaný v mainu)
    Console.Clear();
    if (falseCounter == 0)
    {
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("█████████████");
    }
    if (falseCounter == 1)
    {
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine(" ╔═╩═╗ ");
        Console.WriteLine("█████████████");
    }
    if (falseCounter == 2)
    {
        Console.WriteLine();
        Console.WriteLine("   ║   ");
        Console.WriteLine("   ║   ");
        Console.WriteLine("   ║   ");
        Console.WriteLine("   ║   ");
        Console.WriteLine("   ║   ");
        Console.WriteLine(" ╔═╩═╗ ");
        Console.WriteLine("█████████████");
    }
    if (falseCounter == 3)
    {
        Console.WriteLine("   ╔═════╗");
        Console.WriteLine("   ║   ");
        Console.WriteLine("   ║   ");
        Console.WriteLine("   ║   ");
        Console.WriteLine("   ║   ");
        Console.WriteLine("   ║   ");
        Console.WriteLine(" ╔═╩═╗ ");
        Console.WriteLine("█████████████");
    }
    if (falseCounter == 4)
    {
        Console.WriteLine("   ╔═════╗");
        Console.WriteLine("   ║     │");
        Console.WriteLine("   ║     @");
        Console.WriteLine("   ║   ");
        Console.WriteLine("   ║   ");
        Console.WriteLine("   ║   ");
        Console.WriteLine(" ╔═╩═╗ ");
        Console.WriteLine("█████████████");
    }
    if (falseCounter == 5)
    {
        Console.WriteLine("   ╔═════╗");
        Console.WriteLine("   ║     │");
        Console.WriteLine("   ║     @");
        Console.WriteLine("   ║     ┼ ");
        Console.WriteLine("   ║   ");
        Console.WriteLine("   ║   ");
        Console.WriteLine(" ╔═╩═╗ ");
        Console.WriteLine("█████████████");
    }
    if (falseCounter == 6)
    {
        Console.WriteLine("   ╔═════╗");
        Console.WriteLine("   ║     │");
        Console.WriteLine("   ║     @");
        Console.WriteLine("   ║    ┌┼┐");
        Console.WriteLine("   ║   ");
        Console.WriteLine("   ║   ");
        Console.WriteLine(" ╔═╩═╗ ");
        Console.WriteLine("█████████████");
    }
    //výpis neuhádnutých/uhádnutých znaků
    Console.WriteLine();
    Console.Write("Hádané slovo: ");
    for (int i = 0; i < spravneUhodnuto.Length; i++)
    {
        Console.Write($"{spravneUhodnuto[i]} ");
    }
    Console.WriteLine();
    Console.Write("\nHádej písmeno: ");
    char hadani = Char.Parse(Console.ReadLine().ToUpper());

    //kontrola, zda hadaneSlovo obsahuje hádaný znak
    if (hadaneSlovo.Contains(hadani))
    {
        //zjištění indexu správně uhodnutého písmena a doplnění na příslušný index do spravneUhodnuto + přičtení bodů do trueCounteru
        for (int i = 0; i < hadaneSlovo.Length; i++)
        {
            if (hadaneSlovo[i] == hadani)
            {
                spravneUhodnuto[i] = hadani;
                trueCounter++;
            }
        }
        return true;
    }
    else
    {
        return false;
    }
}