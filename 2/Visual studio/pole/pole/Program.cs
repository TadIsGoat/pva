/*
Console.WriteLine("Zadej velikost pole: ");
int velikostPole = Convert.ToInt32(Console.ReadLine());

int[] pole = new int[velikostPole];

Console.Write("Zadej číslo do pole: ");
pole[10] = 155;

for (int i = 0; i < velikostPole; i++)
{
    //pole[i] = i + 1;
    Console.Write(pole[i]);
}



int[] pole = {10, 3, 52, 55,};
int[] pole2 = {10, 5, 45, 99999 };

foreach (int i in pole)
{
    Console.Write("{0} " , i);
}

Console.WriteLine();
Console.WriteLine("Minimum: " + pole.Min());
Console.WriteLine("Maximum: " + pole.Max());
Console.WriteLine("Avg: " + pole.Average());
Console.WriteLine("Součet: " + pole.Sum());
Console.WriteLine("Délka: " + pole.Length);
Console.WriteLine("První číslo: " + pole.First());
Console.WriteLine("Poslední číslo: " + pole.Last());

int[] pole3 = pole.Concat(pole2).ToArray();

foreach (int i in pole3)
{
    Console.Write("{0} ", i);
}

*/

string[] pratele = { "Kochy", "Bata", "Kutěj", "Winta", "Winta" };
Array.Sort(pratele);
//abecední seřazení
Array.Reverse(pratele);
//reverse abeceda
pratele = pratele.Distinct().ToArray();
//vymazaní opakovaných hodnot
//2 různé zápisy

foreach (string p in pratele)
    Console.Write(" " + p);

Console.WriteLine();
Console.WriteLine("Zadej přítele: ");
string pritel = Console.ReadLine();

int pozice = Array.IndexOf(pratele, pritel);
if (pozice >= 0)
{
    Console.WriteLine("{0} je na {1}", pritel, pozice);
}
else
{
    Console.WriteLine("Kamarád gone");
}