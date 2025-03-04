Console.WriteLine("Následující program vypíše součet čísel");
int cislo1 = 0;
int soucet1 = 0;

do
{
    Console.Write("Zadej číslo: ");
    cislo1 = int.Parse(Console.ReadLine());
    soucet1 += cislo1;
    //soucet1 = soucet1 + cislo1;
} while (cislo1 != 0);

Console.WriteLine("Součet je: " + soucet1);
Console.ReadLine();

Console.WriteLine("Následující program vypíše průměr čísel");
double cislo2 = 0;
double soucet2 = 0;
double pocet = 0;

do
{
    Console.Write("Zadej číslo: ");
    cislo2 = double.Parse(Console.ReadLine());
    soucet2 += cislo2;
    pocet ++;
} while (cislo2 != 0);

double prumer = soucet2 / (pocet - 1);
Console.WriteLine("Průměr je: " + prumer);
Console.ReadLine();

Console.WriteLine("Následující program vypíše počet kladných a záporných čísel");
int cislo3 = 0;
int zaporne = 0;
int kladne = 0;

do
{
    Console.Write("Zadej číslo: ");
    cislo3 = int.Parse(Console.ReadLine());

    if (cislo3 < 0)
    {
        zaporne += 1;
    }
    if (cislo3 > 0)
    {
        kladne += 1;
    }

} while (cislo3 != 0);

Console.WriteLine("Počet kladných: " + kladne);
Console.WriteLine("Počet záporných: " + zaporne);
Console.ReadLine();

Console.WriteLine("Následující program vypíše počet známek (1, 2, 3, 4, 5)");
string cislo4;
int znamka1 = 0;
int znamka2 = 0;
int znamka3 = 0;
int znamka4 = 0;
int znamka5 = 0;

do
{
    Console.Write("Zadej známku: ");
    cislo4 = (Console.ReadLine());

    switch (cislo4)
    {
        case "1":
            znamka1 += 1;
            break;

        case "2":
            znamka2 += 1;
            break;

        case "3":
            znamka3 += 1;
            break;

        case "4":
            znamka4 += 1;
            break;

        case "5":
            znamka5 += 1;
            break;
    }
} while (cislo4 != "0");

Console.WriteLine();
Console.WriteLine("Počet 1: " + znamka1);
Console.WriteLine("Počet 2: " + znamka2);
Console.WriteLine("Počet 3: " + znamka3);
Console.WriteLine("Počet 4: " + znamka4);
Console.WriteLine("Počet 5: " + znamka5);
Console.WriteLine();

Console.Write("1: ");
for (int i = 0; i < znamka1; i++)
{
    Console.Write("*");
}