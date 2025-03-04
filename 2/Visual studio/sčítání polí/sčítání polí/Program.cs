Console.WriteLine("Sčítání polí");

int[] pole1 = new int[10];
int[] pole2 = new int[10];
int[] pole3 = new int[10];

while (true)
{
    for (int i = 0; i < 10; i++)
    {
        int cislo1;
        Random random1 = new Random();
        cislo1 = random1.Next(0, 100);
        pole1[i] = cislo1;

        int cislo2;
        Random random2 = new Random();
        cislo2 = random2.Next(0, 100);
        pole2[i] = cislo2;
    }
    Console.WriteLine("První pole hodnot:");
    for (int i = 0;i < 10;i++)
    {
        Console.Write("{0} ", pole1[i]);
    }
    Console.WriteLine("\nDruhé pole hodnot:");
    for (int i = 0; i < 10; i++)
    {
        Console.Write("{0} ", pole2[i]);
    }
    Console.WriteLine("\nSečtené pole: ");
    for (int i = 0; i < 10; i++)
    {
        pole3[i] = pole1[i] + pole2[i];
        Console.Write("{0} ", pole3[i]);
    }






    Console.WriteLine();
    Console.ReadLine();
}
