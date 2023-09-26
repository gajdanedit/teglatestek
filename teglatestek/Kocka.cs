using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teglatestek
{
    internal class Kocka : Test
    {
        private double OldalHossz {  get;}
        public Kocka(double oldalHossz) :base("Kocka")
        {
            OldalHossz = oldalHossz;
        }
        public override double Terfogat()
        {
            return Math.Pow(OldalHossz, 3);
        }
        public override double Felszin()
        {
            return 6 * Math.Pow(OldalHossz, 2);
        }
    }

}
