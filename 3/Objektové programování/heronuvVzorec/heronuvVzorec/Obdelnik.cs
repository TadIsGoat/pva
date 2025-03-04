using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heronuvVzorec
{
    internal class Obdelnik : Tvar
    {
        internal int sirka;
        internal int vyska;

        internal Obdelnik(int Sirka, int Vyska)
        {
            this.sirka = Sirka;
            this.vyska = Vyska;
        }

        internal override string Barva
        {
            get;
            set;
        }

        internal double Obsah()
        {
            double obsah = sirka * vyska;
            return obsah;
        }
    }
}
