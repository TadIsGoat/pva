using System.Text;
Console.OutputEncoding = Encoding.UTF8;
// '$', '♥', '#', '♣', '♦', '♠', '▲', '☻'

char[,] pexeso = new char[,]
{
    {'$', '♥', '#', '♣'},
    {'♦', '♠', '▲', '☻'},
    {'$', '♥', '♥', '#'},
    {'♠', '♦', '☻', '▲'}
};

bool[,] hidden = new bool[4, 4];
int[] pair1 = { 0, 0 };
int[] pair2 = { 0, 0 };
int counter = 0;

Console.WriteLine("======================================================");
Console.WriteLine("===================== PEXESO =========================");
Console.WriteLine("======================================================");
Console.WriteLine();

while (true)
{
    counter++;
    Render();

    pair1 = Question();

    Render();

    pair2 = Question();

    Render();

    if (pexeso[pair1[0], pair1[1]] == pexeso[pair2[0], pair2[1]])
    {
        Console.WriteLine("\nCorrect!\n");
    }
    else
    {
        hidden[pair1[0], pair1[1]] = false;
        hidden[pair2[0], pair2[1]] = false;
        Console.WriteLine("\nTry again!");
    }

    Console.ReadKey();
    Console.Clear();
}

int[] Question()
{
    int col;
    int row;

    while (true)
    {
        Console.Write("Enter row: ");
        col = int.Parse(Console.ReadLine());
        Console.Write("Enter column: ");
        row = int.Parse(Console.ReadLine());

        if (col >= 0 && col <= pexeso.GetLength(0) && row >= 0 && row <= pexeso.GetLength(1))
        {
            hidden[col, row] = true;
            break;
        }
        else
        {
            Console.WriteLine("You are out of the array!");
        }
    }

    return [col, row];
}

void Render()
{
    Console.WriteLine("\nRound number: " + counter);
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