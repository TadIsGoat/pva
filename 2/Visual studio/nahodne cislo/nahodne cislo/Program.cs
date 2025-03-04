Console.WriteLine("Hoďte kostkou (ukončíte slovíčkem konec)");
string konec = Console.ReadLine();

while (konec != "konec")
{


int cislo;

Random random1 = new Random();
cislo = random1.Next(1,7);

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Hozené číslo je: " + cislo);
konec = Console.ReadLine();
}