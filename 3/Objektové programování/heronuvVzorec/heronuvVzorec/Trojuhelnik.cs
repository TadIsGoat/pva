using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heronuvVzorec
{
    internal class Trojuhelnik : Tvar
    {
        internal int a;
        internal int b;
        internal int c;

        internal Trojuhelnik(int A, int B, int C)
        {
            this.a = A;
            this.b = B;
            this.c = C;
        }

        internal override string Barva
        {
            get;
            set;
        }

        internal double Obsah()
        {
            double s = (a + b + c) / 2;
            double obsah = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            //double obsahX = obsahT * 4;
            return obsah;
        }
    }
}
