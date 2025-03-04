Console.Write("zadejte počet opakování pro generování čísel:");
int opakovani = int.Parse(Console.ReadLine());

for (int i = 1; i <= opakovani; i++)
{
    int cislo;
    Random random = new Random();
    cislo = random.Next(0, 10001);
    Console.WriteLine("{0}. náhodně generované číslo je:" + cislo, i);
}