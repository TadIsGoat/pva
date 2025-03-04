Console.WriteLine("Kolikrát chcete ťukat?");
int cislo = int.Parse(Console.ReadLine());

for (int i = 0; i < cislo; i++)
{
    Console.WriteLine("ťuk ťuk");
}

Console.WriteLine("Kdo tam?");
string jmeno = Console.ReadLine();

Console.WriteLine("Ahoj " + jmeno);