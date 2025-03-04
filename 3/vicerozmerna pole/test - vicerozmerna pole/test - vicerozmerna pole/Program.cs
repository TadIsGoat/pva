string[,] trida = new string[,]
{
    {"|volno |", "|volno |", "|volno |", "|volno |", "|volno |", "|volno |"},
    {"|volno |", "|volno |", "|volno |", "|volno |", "|volno |", "|volno |"},
    {"|volno |", "|volno |", "|volno |", "|volno |", "|volno |", "|volno |"},
    {"|volno |", "|volno |", "|volno |", "|volno |", "|volno |", "|volno |"},
    {"|volno |", "|volno |", "|volno |", "|volno |", "|volno |", "|volno |"},
};

int rada;
int lavice;
string jmeno;

while(true)
{
    Console.Write("Zapiš řadu: ");
    rada = int.Parse(Console.ReadLine());

    Console.Write("Zapiš lavici od leva: ");
    lavice = int.Parse(Console.ReadLine());

    Console.Write("Zapiš jméno: ");
    jmeno = Console.ReadLine();

    switch(jmeno.Length)
    {
        case 0:
            trida[(rada - 1), (lavice - 1)] = "|" + jmeno + "      |";
            break;
        case 1:
            trida[(rada - 1), (lavice - 1)] = "|" + jmeno + "     |";
            break;
        case 2:
            trida[(rada - 1), (lavice - 1)] = "|" + jmeno + "    |";
            break;
        case 3:
            trida[(rada - 1), (lavice - 1)] = "|" + jmeno + "   |";
            break;
        case 4:
            trida[(rada - 1), (lavice - 1)] = "|" + jmeno + "  |";
            break;
        case 5:
            trida[(rada - 1), (lavice - 1)] = "|" + jmeno + " |";
            break;
        default:
            trida[(rada - 1), (lavice - 1)] = "|" + jmeno + "|";
            break;
    }

    /*trida[(rada - 1), (lavice - 1)] = "|" + jmeno + " |";*/
    Console.WriteLine("========== Zasedací pořádek ve třídě ==========");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(" |   ŘADA 1      | |   ŘADA 2      | |   ŘADA 3      |");
    Console.ForegroundColor = ConsoleColor.White;
    for (int i = 0; i < trida.GetLength(0); i++)
    {
        for (int j = 0; j < trida.GetLength(1); j++)
        {
            if (trida[i, j] != "|volno |")
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            Console.Write(" " + trida[i, j]);
            Console.ForegroundColor = ConsoleColor.White;
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}