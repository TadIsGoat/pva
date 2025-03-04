string veta = "Programování a Grafika";
Console.WriteLine(veta);

veta = veta.ToLower();

int pocetSamohlasek = 0;
int pocetSouhlasek = 0;

string samohlasky = "aeiouyáéíoúůyý";
string souhlasky = "bcčdďfghjklmnňpqrřsštťvwyzž";

foreach(char znak in veta)
{
    if(samohlasky.Contains(znak))
        pocetSamohlasek++;
    else if(souhlasky.Contains(znak))
        pocetSouhlasek++;
}

Console.WriteLine("Samohlasek je: " + pocetSamohlasek);
Console.WriteLine("Souhlasek je: " + pocetSouhlasek);
Console.WriteLine("Nepísmennných znaků je: {0}", veta.Length - (pocetSamohlasek + pocetSouhlasek));