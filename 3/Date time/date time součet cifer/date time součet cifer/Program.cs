Console.WriteLine("Součet cifer dat pro následujících 7 dní: ");
DateTime datum = DateTime.Now;
for  (int i = 0; i < 7; i++)
{
    int soucet = datum.Day + datum.Month + datum.Year;
    Console.WriteLine("{0} - {1}", datum.ToShortDateString(), soucet);
    datum = datum.AddDays(1);
}