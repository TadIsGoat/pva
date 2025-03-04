internal class Program
{
    static void Main(string[] args)
    {
        Tvar trojuhelnik = new Trojuhelnik(15, 15, 25, "ruzova");
        Tvar obdelnik = new Obdelnik(3, 26, "hneda");
        Console.WriteLine($"Obsah stromu je {(4 * trojuhelnik.Obsah()) + obdelnik.Obsah()} cm^2");
    }
}

public class Tvar
{
    public string _barvaTvaru;
    public Tvar(string barva)
    {
        _barvaTvaru = barva;
    }

    public virtual double Obsah()
    {
        return 0;
    }
}
public class Trojuhelnik : Tvar
{
    private double _a;
    private double _b;
    private double _c;
    public Trojuhelnik(double a, double b, double c, string barva) : base(barva)
    {
        _a = a;
        _b = b;
        _c = c;
    }

    public override double Obsah()
    {
        double s = (_a + _b + _c) / 2;
        return Math.Sqrt(s * (s - _a) * (s - _b) * (s - _c));
    }
}

public class Obdelnik : Tvar
{
    private double _a;
    private double _b;
    public Obdelnik(double a, double b, string barva) : base(barva)
    {
        _a = a;
        _b = b;
    }

    public override double Obsah()
    {
        return _a * _b;
    }
}
