using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testek
{
    abstract class Test
    {
        public string nev;

        public abstract double felszin();
        public abstract double terfogat();

        public override string ToString()
        {
            return this.nev;

        }
        public Test(string nev)
        {
            this.nev = nev;


        }
    }
}
