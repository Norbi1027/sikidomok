using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testek
{
    internal class Teglatest : Test
    {
        public int a;
        public int b;
        public int c;

        public Teglatest(int a, int b, int c) : base("Téglatest")
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double felszin()
        {
            return 2*(a*b+a*c+b*c);
        }

        public override double terfogat()
        {
            return a * b * c;
        }
    }
}
