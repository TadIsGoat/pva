//DateTime datum = new DateTime(2024,2,29,11,12,32); //statický
/*
while (true)
{
    DateTime datum = DateTime.Now;
    Console.WriteLine(datum);
    Thread.Sleep(998);
    Console.Clear();
}
*/


Console.Write("Start měření času: ");
Console.ReadLine();
DateTime start = DateTime.Now;
Console.Write(start);
Console.Write("\nKonec měření času: ");
Console.ReadLine();
DateTime konec = DateTime.Now;
Console.Write(konec);

TimeSpan mereni = konec - start;
//zaokrouhlený výpis (nejde uložit do listu apod.)
Console.Write("\n\nInterval času: ");
Console.WriteLine($"{mereni.TotalSeconds:N3}");

//zaokrouhlený výpis (jde uložit do listu apod.)
Console.WriteLine($"Interval času: " + Math.Round(mereni.TotalSeconds,3));