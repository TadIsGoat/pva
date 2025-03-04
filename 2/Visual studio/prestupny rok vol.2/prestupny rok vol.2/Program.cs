while (true)
{


    Console.WriteLine("Přestupný rok");
    Console.Write("Zadej rok: ");
    int rok = int.Parse(Console.ReadLine());

        if (rok % 4 == 0)
        {
            Console.WriteLine("Tento rok je přestupný");
            break;
        }
        else
        {
            Console.WriteLine("Tento rok není přestupný");
        }
}
