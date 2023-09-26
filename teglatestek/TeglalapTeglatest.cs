using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teglatestek
{
    internal class TeglalapTeglatest : Test
    {
        private double Hossz {  get; }
        private double Szelesseg { get; }
        private double Magassag { get; }

        public TeglalapTeglatest(double hossz, double szelesseg, double magassag) :base("Téglatest")
        {
            Hossz = hossz;
            Szelesseg = szelesseg;
            Magassag = magassag;
        }
        public override double Terfogat() 
        {
            return Hossz * Szelesseg * Magassag;
        }
        public override double Felszin()
        {
            return 2 * (Hossz * Szelesseg + Hossz * Magassag + Szelesseg * Magassag);
        }

    }
}
