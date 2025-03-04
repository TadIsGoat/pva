// '$', '♥', '#', '♣', '♦', '♠', '▲', '☻'
char[,] pexeso = new char[,]
{
    {'$', '♥', '#', '♣'},
    {'♦', '♠', '▲', '☻'},
    {'$', '♥', '♥', '#'},
    {'♠', '♦', '☻', '▲'}
};

bool[,] hidden = new bool[4, 4];
int n1 = 0;
int n2 = 0;

int n3 = 0;
int n4 = 0;

Console.WriteLine("======================================================");
Console.WriteLine("===================== PEXESO =========================");
Console.WriteLine("======================================================");
Console.WriteLine();

Render();

while (true)
{

    if (!Question(n1, n2))
    {
        Question(n1, n2);
    }

    Render();

    if (!Question(n3, n4))
    {
        Question(n3, n4);
    }

    if (pexeso[n1, n2] == pexeso[n3, n4] && hidden[n1, n2] && hidden[n3, n4])
    {
        Console.WriteLine("Correct!");
    }
    else
    {
        hidden[n1, n2] = false;
        hidden[n3, n4] = false;
        Console.WriteLine("Try again!");
    }

    Render();
}

bool Question(int n1, int n2)
{
    Console.Write("Enter n1: ");
    n1 = int.Parse(Console.ReadLine());
    Console.Write("Enter n2: ");
    n2 = int.Parse(Console.ReadLine());

    if (n1 >= 0 && n1 <= pexeso.GetLength(0) && n2 >= 0 && n2 <= pexeso.GetLength(1))
    {
        hidden[n1, n2] = true;
        return true;
    }
    else { return false; }
}

void Render()
{
    Console.Write("  ");
    for (int i = 0; i < pexeso.GetLength(0); i++)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();
    for (int i = 0; i < pexeso.GetLength(0); i++)
    {
        Console.Write(i + " ");
        for (int j = 0; j < pexeso.GetLength(1); j++)
        {
            if (hidden[i, j] == false)
            {
                Console.Write("* ");
            }
            else
            {
                Console.Write(pexeso[i, j] + " ");
            }
        }
        Console.WriteLine();
    }
}