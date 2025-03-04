File.Create(@"data.txt"); //vytvoření souboru

string vstupTextu = Console.ReadLine();
File.WriteAllText("data2.txt", vstupTextu); //vytvoření souboru s textem

string vstupTextu2 = Console.ReadLine();
File.AppendAllText("data2.txt", Environment.NewLine + vstupTextu2); //přidání textu na nové lajně

string nactenyText = File.ReadAllText("data2.txt"); //načtení textu ze souboru do proměnné
Console.WriteLine("\n" + nactenyText); //vypis proměnné