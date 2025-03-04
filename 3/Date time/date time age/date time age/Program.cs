Console.WriteLine("Zadejte datum narození: ");
DateTime denNarozeni = DateTime.Parse(Console.ReadLine());

TimeSpan vek = DateTime.Today - denNarozeni;
int odpocet = denNarozeni.DayOfYear - DateTime.Now.DayOfYear;
if (odpocet < 0)
{
    odpocet += 365;
}

Console.WriteLine($"\nVěk: {vek.Days/365}");
Console.WriteLine($"Narozeniny máš za: {odpocet} dní");