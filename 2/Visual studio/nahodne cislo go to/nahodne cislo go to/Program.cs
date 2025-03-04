
Console.WriteLine("Hoďte kostkou (ukončíte slovíčkem konec)");
string konec = Console.ReadLine();
start:
if (konec != "konec")
{
    int cislo;

    Random random1 = new Random();
    cislo = random1.Next(1, 7);

    if(cislo % 2)
    Console.WriteLine("Hozené číslo je: " + cislo);
    konec = Console.ReadLine();

    goto start;
}