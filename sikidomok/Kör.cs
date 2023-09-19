using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace sikidomok
{
    class Kör : Sikidom
    {
        public double r;
        public Kör(int r) : base("Kör")
        {
            this.r = r;
        }

        public override double kerulet()
        {
            return 2*r*Math.PI;
        }

        public override double terulet()
        {
            return r*r*Math.PI;
        }
    }
}
