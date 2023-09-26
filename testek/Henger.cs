using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testek
{
    internal class Henger : Test
    {
        public int m;
        public int r;

        public Henger(int m, int r) : base("Henger")
        {
            this.m= m;
            this.r = r;
        }

        public override double felszin()
        {
            return 2 * Math.PI * r *(r + m);
        }

        public override double terfogat()
        {
            return Math.PI*r*r*m;
        }
    }
}
