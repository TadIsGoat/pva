Console.WriteLine("Odvody zaměstnance");
Console.Write("Zadejte hrubou mzdu: ");
double mzda = double.Parse(Console.ReadLine());

Console.WriteLine("Co chcete zjistit? (sociální, zdravotní, daň, čistou mzdu)");
string volba = Console.ReadLine();

volba = volba.ToUpper();

double socialni = mzda * 0.065;
double zdravotni = mzda * 0.045;
double dan = 0.15;
double cistaMzda = mzda - socialni - zdravotni - dan;

switch (volba)
{
    case ("sociální"):
        Console.WriteLine("Zaměstnaned odvede: {0} Kč", socialni);
        break;
    case ("zdravotní"):
        Console.WriteLine("Zaměstnaned odvede: {0} Kč", zdravotni);
        break;
    case ("daň"):
        Console.WriteLine("Zaměstnaned odvede: {0} Kč", dan);
        break;
    case ("čistou mzdu"):
        Console.WriteLine("Zaměstnaned odvede: {0} Kč", cistaMzda);
        break;
    default:
        Console.WriteLine("Nesprávná hodnota");
        break;
}