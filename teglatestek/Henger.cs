using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teglatestek
{
    internal class Henger : Test
    {
        private double Sugar { get; }
        private double Magassag { get;}

        public Henger(double sugar, double magassag) : base("Henger")
        {
            Sugar = sugar;
            Magassag = magassag;
        }
        public override double Terfogat()
        {
            return Math.PI * Math.Pow(Sugar, 2) * Magassag;
        }

        public override double Felszin()
        {
            return 2 * Math.PI * Sugar * Magassag + 2 * Math.PI * Math.Pow(Sugar, 2);
        }
           
    }
}
