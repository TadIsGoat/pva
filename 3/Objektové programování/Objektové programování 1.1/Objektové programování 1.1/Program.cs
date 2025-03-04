namespace Objektové_programování_1._1
{
    class Program
    {
        static void Main()
        {
            Pozdrav zdravice = new Pozdrav();
            zdravice.Pozdraveni("Karle");
            zdravice.Pozdraveni("Pavle");

            zdravice.text = "Vítám tě";
            Console.WriteLine(zdravice.Pozdravit("Jano"));

            zdravice.text = "Helo tu Kelo!";
            Console.WriteLine(zdravice.Pozdravit("o/"));
        }
    }
}