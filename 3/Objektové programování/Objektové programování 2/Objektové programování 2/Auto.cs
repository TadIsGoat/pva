using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objektové_programování_2
{
    internal class Auto
    {
        public string barva;
        public int pocetKW;
        public string karoserie;
        public int rychlost;
        public int ujetoKM;

        public Auto(string barva, int pocetKiloWatt, string karoserie, int aktualniRychlost)
        {
            this.barva = barva;
            this.pocetKW = pocetKiloWatt;
            this.karoserie = karoserie;
            this.rychlost = aktualniRychlost;
            this.ujetoKM = 0;
        }

        public void JedHodinu()
        {
            this.ujetoKM += rychlost;
        }

        public void infomarceOAutu(Auto libovolneAuto)
        {
            Console.WriteLine($"Auto {libovolneAuto.barva}, které má {libovolneAuto.pocetKW} kW ujelo {libovolneAuto.ujetoKM} km");
        }
    }
}
