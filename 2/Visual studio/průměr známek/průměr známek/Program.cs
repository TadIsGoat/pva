Console.WriteLine("Výpočet průměru známek");

Console.WriteLine("zadejte známky oddělené čárkou: ");
string vstup = Console.ReadLine();
double soucet = 0;

//rozdělení textu

string[] znamky = vstup.Split(',');

int[] pole = new int[znamky.Length];
for (int i = 0; i < znamky.Length; i++)
{
    pole[i] = Convert.ToInt32(znamky[i]);
}

/*
int pocitadlo = 0;

foreach(string znamka in znamky)
{
    int hodnotaZnamky = int.Parse(znamka);
    soucet += hodnotaZnamky;
    pocitadlo++;
}

//double prumer = soucet / (double)znamky.Length;
//Console.WriteLine("Průměr: " + prumer);
Console.WriteLine("Průměr: " + soucet/pocitadlo);
*/
Console.WriteLine("Průměr: " + pole.Average());