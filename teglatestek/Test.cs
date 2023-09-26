using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teglatestek
{
    abstract class Test
    {
        public string nev;
        public Test(string nev)
        {
            this.nev = nev;
        }
        public abstract double Felszin();
        public abstract double Terfogat();
        public override string ToString()
        {
            return this.nev;
        }
        

    }
}
