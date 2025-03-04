Console.WriteLine("Zadej počet minut: ");
int mins = int.Parse(Console.ReadLine());

Console.WriteLine("Zadej počet sekund: ");
int secs = int.Parse(Console.ReadLine());

int time = (mins * 60) + secs;

for (int i = time; i >= 0; i--)
{
    int zbyvajiciSecs = i % 60;
    int zbyvajiciMins = i / 60;

    Console.WriteLine($"\nDo konce světa zbývá {zbyvajiciMins.ToString("00")} : {zbyvajiciSecs.ToString("00")}");
    Thread.Sleep(1000);
    Console.Clear();
}

while(true)
{
    Random random = new Random();
    int cislo = random.Next(1, 4);
    switch(cislo)
    {
        case 1:
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\tKonec!");
            Thread.Sleep(100);
            Console.Clear();
            break;
        case 2:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\tKonec!");
            Thread.Sleep(100);
            Console.Clear();
            break;
        case 3:
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n\tKonec!");
            Thread.Sleep(100);
            Console.Clear();
            break;
    }
}