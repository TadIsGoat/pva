using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankovniUcet
{
    internal class BankovniUcet
    {
        private string _jmeno;
        private string _prijmeni;
        private double _zustatek;
        public string Jmeno //vlastnosti
        // { get; set; }
        {
            get { return _jmeno; }
            set { _jmeno = value; }
        }
        public string Prijmeni
        {
            get { return _prijmeni; }
            set { _prijmeni = value;}
        }
        public double Zustatek
        {
            get => _zustatek;
            set
            {
                if (value >= 0)
                {
                    _zustatek = value;
                } else
                    Console.WriteLine("Zůstatek nemůže být záporný!");
            }
        }
        //ctor
        public BankovniUcet(string jmeno, string prijmeni, int zustatek)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Zustatek = zustatek;
        }

        public void ZobrazitZustatek()
        {
            Console.WriteLine($"Vlastník účtu: {Jmeno}, {Prijmeni}");
            Console.WriteLine($"Aktuální zůstatek: {Zustatek}");
        }

        public void Vlozit (double vlozenaCastka)
        {
            if (vlozenaCastka > 0)
            {
                Zustatek += vlozenaCastka;
                Console.WriteLine($"Úspěšně vloženo {vlozenaCastka} Kč");
            }
            else
            {
                Console.WriteLine("Vložená částka musí být větší než 0!");
            }
        }

        public void Vybrat (double vybranaCastka)
        {
            if(vybranaCastka > 0 && vybranaCastka <= Zustatek)
            {
                Zustatek -= vybranaCastka;
                Console.WriteLine($"Úspěšně vybráno {vybranaCastka} Kč");
            }
            else
            {
                Console.WriteLine("Částka výběru nesplňuje požadavky");
            }
        }

        public void Prevest (double prevadenaCastka)
        {
            if (prevadenaCastka > 0 && prevadenaCastka <= Zustatek)
            {
                Zustatek -= prevadenaCastka;
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("Částka výběru nesplňuje požadavky");
            }
        }

        public void ZobrazitTransakce()
        {

        }

        public void Ulozit()
        {

        }
    }
}
