using heronuvVzorec;
Trojuhelnik trojuhelnik = new(15, 15, 25);
Obdelnik obdelnik = new(3, 26);

double obsah = (4 * trojuhelnik.Obsah()) + obdelnik.Obsah();
Console.WriteLine(obsah);