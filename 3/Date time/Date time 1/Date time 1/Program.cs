//DateTime datum = new DateTime(2024, 2, 16, 11, 30, 45); //rok, mesic, den, hodina, minuta, sekunda (do cw vypisuje den mesic rok hodina minuta sekunda)
/*
while (true)
{
    DateTime datum = DateTime.Now; //vypíše čas spuštění příkazu
    Console.WriteLine(datum.ToLongTimeString());
    Thread.Sleep(857); //potřeba upravit k reálnému času, kvůli zpoždění programu
    Console.Clear();
}
*/
Console.WriteLine();

DateTime datum2 = DateTime.Now;
Console.WriteLine($"Dnes je {datum2.DayOfWeek} {datum2.Day}. {datum2.Month}. {datum2.Year}");