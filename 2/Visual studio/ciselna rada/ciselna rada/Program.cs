Console.WriteLine("Program číselná řada");

Console.Write("Zadejte velikost číselné řady: ");
int cislo = int.Parse(Console.ReadLine());

for(int i = cislo ; i <= cislo; i--)
{
    if (i >= 1)
        Console.Write("[{0}]", i);
    else
        break;
}