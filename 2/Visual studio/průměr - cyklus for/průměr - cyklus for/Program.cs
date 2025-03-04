Console.WriteLine("Program na výpočet průměru známek");
Console.WriteLine("Z kolika známek chcete průměr vypočítat?");
int pocet = int.Parse(Console.ReadLine());

int soucet = 0;

for (int i = 0; i < pocet; i++)
{
    Console.Write("Známka: ");
    int znamka = int.Parse(Console.ReadLine());
    soucet = soucet + znamka;
}
double prumer = soucet / pocet;

Console.WriteLine();
Console.WriteLine("Průměr: " + prumer );