using System;

namespace OOPPriklad
{
    // založení třídy zvíře
    class Zvire
    {
        // modifikátory přístupu, vlastnosti třídy, gettery a settery
        public string Jmeno { get; set; }
        public int Vek { get; set; }

        // constructor
        public Zvire(string jmeno, int vek)
        {
            Jmeno = jmeno;
            Vek = vek;
        }

        // procedura s polymorfismem
        public virtual void VydatZvuk()
        {
            Console.WriteLine("Zvíře vydává nějaký zvuk.");
        }

        // procedura
        public void ZobrazInfo()
        {
            Console.WriteLine($"Jméno: {Jmeno}, Věk: {Vek}");
        }
    }

    // vytvoření třídy, která dědí od třídy zvíře
    class Pes : Zvire 
    {
        public string Plemeno { get; set; }

        // constructor, který dědí 2 vlastnosti třídy zvíře
        public Pes(string jmeno, int vek, string plemeno) : base(jmeno, vek)
        {
            Plemeno = plemeno;
        }

        // procedura s polymorfismem, přepisuje proceduru z třídy zvíře
        public override void VydatZvuk()
        {
            Console.WriteLine("Pes štěká: Haf haf!");
        }

        // procedura
        public void Aportuj()
        {
            Console.WriteLine($"{Jmeno} aportuje míček!");
        }
    }

    //  vytvoření třídy, která dědí od třídy zvíře
    class Kocka : Zvire
    {
        public string Barva { get; set; }

        // constructor, který dědí 2 vlastnosti třídy zvíře
        public Kocka(string jmeno, int vek, string barva) : base(jmeno, vek)
        {
            Barva = barva;
        }

        // procedura s polymorfismem, přepisuje proceduru z třídy zvíře
        public override void VydatZvuk()
        {
            Console.WriteLine("Kočka mňouká: Mňau mňau!");
        }

        // procedura
        public void Prede()
        {
            Console.WriteLine($"{Jmeno} přede.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // main řídí program

            // vytvoření instance třídy pes
            Pes pes = new Pes("Baryk", 3, "Zlatý retrívr");
            pes.ZobrazInfo();
            pes.VydatZvuk(); // volání procedury s polymorfismem
            pes.Aportuj();

            Console.WriteLine();

            // vytvoření instance třídy kočka
            Kocka kocka = new Kocka("Micka", 2, "Bílá");
            kocka.ZobrazInfo();
            kocka.VydatZvuk(); // volání procedury s polymorfismem
            kocka.Prede();

            Console.WriteLine();

            // vytvoření instance třídy pes pomocí třídy zvíře
            Zvire mojeZvire = new Pes("Azor", 4, "Buldoček");
            mojeZvire.ZobrazInfo();
            mojeZvire.VydatZvuk(); // volání procedury s polymorfismem
        }
    }
}