Console.WriteLine("Seznam lodí:\nLetadlová loď 5 políček\nBitevní loď 4 políčka\nKřižník 3 políčka\nPonorka 2 políčka\nTorpédoborec 1 políčka\n");

int pocetRadku = int.Parse(Console.ReadLine());
int pocetSloupcu = Convert.ToInt32(Console.ReadLine());

int[,] lode = new int[pocetRadku, pocetSloupcu];
lode[0, 1] = int.Parse(Console.ReadLine());
lode[0, 2] = 7;
lode[0, 3] = 7;
lode[0, 4] = 7;


for (int i = 2; i < 7; i++) 
{
    lode[i, 1] = 7; 
}


for (int j = 4; j < 7; j++) 
{
    lode[1, j] = 7;
}


for (int i = 3; i < 7; i++)
{
    lode[i, 7] = 7;
}

/*
int[,] lode = new int[,]
{
    {0,0,7,0,6,5,6,3,0},
    {0,0,7,0,6,5,6,3,0},
    {0,0,7,0,6,5,6,3,0},
    {0,0,7,0,6,5,6,3,0},
    {0,0,7,0,6,5,6,3,0},
    {0,0,7,0,6,5,6,3,0},
    {0,0,7,0,6,5,6,3,0},
    {0,0,7,0,6,5,6,3,0},
    {0,0,7,0,6,5,6,3,0},
};
*/
//výpis
for (int j = 0; j < lode.GetLength(1); j++)
{
    for (int i = 0; i < lode.GetLength(0); i++)
    {
        Console.Write(" " + lode[i, j]);
    }
    Console.WriteLine();
}