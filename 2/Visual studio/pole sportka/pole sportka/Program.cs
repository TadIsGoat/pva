int[] pole1 = new int[6];
int[] pole2 = new int[6];
int dodatek1 = 0;
int dodatek2 = 0;
int cislo = 0;

Console.Write("První tah: ");
foreach (int i in pole1)
{
    Random random1 = new Random();
    pole1[i] = random1.Next(1, 100);
    Console.Write(pole1[i] + ", ");
}

Random random2 = new Random();
dodatek1 = random2.Next(1, 100);

Console.Write("Dodatkové číslo: " + dodatek1);

Console.Write("\nDruhý tah: ");
foreach (int p in pole2)
{
    Random random3 = new Random();
    pole1[p] = random3.Next(1, 100);
    Console.Write(pole1[p] + ", ");
}

Random random4 = new Random();
dodatek1 = random4.Next(1, 100);

Console.Write("Dodatkové číslo: " + dodatek1);