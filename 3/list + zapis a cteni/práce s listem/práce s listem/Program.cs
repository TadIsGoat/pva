List<string> pismena = new List<string>() { "F", "C", "E", "X", "D", "W" };

Console.WriteLine("\nZnaky v listu");
vypis();

pismena.Sort();

Console.WriteLine("\nSeřazené znaky");
vypis();

pismena.Reverse();

Console.WriteLine("\nSeřazené pozpátku");
vypis();

void vypis ()
{
    foreach (string p in pismena)
    {
        Console.Write(p + " ");
    }
}