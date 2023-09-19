using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sikidomok
{
    abstract class Sikidom
    {
        public string nev;

        public abstract double terulet();
        public abstract double kerulet();

        public override string ToString()
        {
            return this.nev;

        }

        public Sikidom(string nev)
        {
            this.nev = nev;


        }
    }
}
