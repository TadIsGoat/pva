Console.WriteLine("---1. program---");

string[] pole1 = new string[5];

for (int i = 0; i < 5; i++)
{
    Console.Write("Zadejte název předmětu: ");
    pole1[i] = Console.ReadLine();
}

Array.Sort(pole1);
Array.Reverse(pole1);
Console.WriteLine();
Console.Write("Od Z do A: ");

foreach (string i in pole1)
{
    Console.Write(" " + i);
}

Console.WriteLine("\n---2. program---");

int[] pole2 = new int[5];

for (int i = 0; i < 5; i++)
{
    Console.Write("Zadejte {0} číslo : ", i + 1);
    pole2[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Maximum je: {0}", pole2.Max());
Console.WriteLine("Minimum je: {0}", pole2.Min());


Console.WriteLine("\n---3. program---");

string[] pole3 = { "okurek", "mrkev", "salát", "zelí", "rajče"};
string item;

while (true)
{
    Console.Write("Zadejte zeleninu: ");
    item = Console.ReadLine();

    if (pole3.Contains(item))
    {
        Console.WriteLine("Ano, daná zelenina je v poli!");
    }
    else
    {
        Console.WriteLine("Ne, tato zelenina není v poli");
    }
}