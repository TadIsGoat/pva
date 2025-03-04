Console.WriteLine("dělitelnost let");
Console.Write("Zadej rok: ");
int rok = int.Parse(Console.ReadLine());

for (; ; )
{
    if ((rok % 4 == 0 && rok % 100 != 0) || rok % 400 == 0)
    {
        Console.WriteLine("Tento rok je přestupný.");
        Console.Write("Zadej rok: ");
        rok = int.Parse(Console.ReadLine());
    }
    else
    {
        Console.WriteLine("Tento rok není přestupný.");
        break;
    }
}