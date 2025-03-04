Console.WriteLine("Zadejte zprávu k zakódování:");
string zprava = Console.ReadLine();
zprava = zprava.ToLower();
string abeceda = "abcdefghijklmnopqrstuvwxyz";
string[] morseovyZnaky = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
string preklad = "";

foreach (char znak in zprava)
{
    if (abeceda.Contains(znak))
    {
        int pozice = abeceda.IndexOf(znak);
        Console.WriteLine("Pozice: " + pozice);
        if (pozice >= 0)
        {
            preklad += morseovyZnaky[pozice] + " ";
        }
    }
}
Console.WriteLine($"Zakódovaná zpráva je: {preklad}");
Console.WriteLine();


Console.WriteLine("Zadejte zprávu k dekódování:");
string zprava2 = Console.ReadLine().ToLower();
string preklad2 = "";
string[] znaky = zprava2.Split(' ');

foreach (string znak2 in znaky)
{
    int pozice2 = Array.IndexOf(morseovyZnaky, znak2);
    if (pozice2 >= 0)
    {
        preklad2 += abeceda[pozice2];
    }
}



Console.WriteLine($"Dekódovaná zpráva je: {preklad2}");