Console.WriteLine("seznam smajlíků");
Console.WriteLine(":)\n:(\n:*\n:P\n;)\n:D");

Console.WriteLine("Zadejte smajlíka: ");
string smajlik = Console.ReadLine();

smajlik = smajlik.ToUpper();
smajlik = smajlik.Replace("-", "");

switch(smajlik)
{
    case ":)":
        Console.WriteLine("Tvůj smajlík je veselý");
        break;

    case ":(":
        Console.WriteLine("Tvůj smajlík je smutný");
        break ;

    case ":*":
        Console.WriteLine("Tvůj smajlík je milující");
        break;

    case ":P":
        Console.WriteLine("Tvůj smajlík je vyplazený");
        break;

    case ";)":
        Console.WriteLine("Tvůj smajlík je mrkací");
        break;

    case ":D":
        Console.WriteLine("Tvůj smajlík je vysmátý");
        break;

    default:
        Console.WriteLine("Tvůj smajlík je neznámý");
        break; 
}