/*
Console.WriteLine("Šachovnice");

int[,] sachovnice = new int[,]
{
    {1,0,1,0,1,0,1,0},
    {0,1,0,1,0,1,0,1},
    {1,0,1,0,1,0,1,0},
    {0,1,0,1,0,1,0,1},
    {1,0,1,0,1,0,1,0},
    {0,1,0,1,0,1,0,1},
    {1,0,1,0,1,0,1,0},
    {0,1,0,1,0,1,0,1},
};

for (int i = 0; i < sachovnice.GetLength(1); i++)
{
    for (int j = 0; j < sachovnice.GetLength(0); j++)
    {
        Console.Write(" " + sachovnice[i,j]);
    }
    Console.WriteLine();
}
*/
Console.WriteLine("Zadejte počet řad: ");
int rady = int.Parse(Console.ReadLine());

Console.WriteLine("Zadejte počet sedadel v řadě: ");
int sloupce = int.Parse(Console.ReadLine());

int[,] kino = new int [rady, sloupce];

Console.WriteLine("Zadejte číslo řady: ");
int rada = int.Parse(Console.ReadLine());

Console.WriteLine("Zadejte číslo sedadla: ");
int sloupec = int.Parse(Console.ReadLine());

kino[rada - 1, sloupec - 1] = int.Parse(Console.ReadLine());

for (int i = 0; i < kino.GetLength(1); i++)
{
    for (int j = 0; j < kino.GetLength(0); j++)
    {
        Console.Write(" " + kino[i,j]);
    }
    Console.WriteLine("");
}