internal class Program
{
    static void Main(string[] args)
    {
        Zamestnanec programator = new Programator("Java", "Tomáš", "Nový", 28);
        Zamestnanec analytik = new Analytik("Finanční analýza", "Lucie", "Rychlá", 30);
        foreach(Zamestnanec zamestnanec in Zamestnanec)
        {

        }
    }
}

public class Zamestnanec
{
    private string _jmeno;
    private string _prijmeni;
    private int _vek;
    public Zamestnanec(string jmeno, string prijmeni, int vek)
    {
        _jmeno = jmeno;
        _prijmeni = prijmeni;
        _vek = vek;
    }

    public virtual void VypisInfo()
    {
        Console.Write($"Jmeno: {_jmeno},");
        Console.Write($"Prijmeni: {_prijmeni},");
        Console.Write($"Vek: {_vek},");
    }
}
public class Programator : Zamestnanec
{
    private string _progJazyk;
    private string _jmeno;
    private string _prijmeni;
    private int _vek;

    public Programator(string progJazyk, string jmeno, string prijmeni, int vek) : base(jmeno, prijmeni, vek)
    {
        _progJazyk = progJazyk;
        _jmeno = jmeno;
        _prijmeni = prijmeni;
        _vek = vek;
    }

    public override void VypisInfo()
    {
        Console.Write($"Jmeno: {_jmeno}, ");
        Console.Write($"Prijmeni: {_jmeno}, ");
        Console.Write($"Vek: {_jmeno}, ");
        Console.Write($"Programovaci jazyk: {_progJazyk}");
    }
}

public class Analytik : Zamestnanec
{
    private string _specializace;
    private string _jmeno;
    private string _prijmeni;
    private int _vek;

    public Analytik(string specializace, string jmeno, string prijmeni, int vek) : base(jmeno, prijmeni, vek)
    {
        _specializace = specializace;
        _jmeno = jmeno;
        _prijmeni = prijmeni;
        _vek = vek;
    }

    public override void VypisInfo()
    {
        Console.Write($"Jmeno: {_jmeno}, ");
        Console.Write($"Prijmeni: {_jmeno}, ");
        Console.Write($"Vek: {_jmeno}, ");
        Console.Write($"Programovaci jazyk: {_specializace}");
    }
}