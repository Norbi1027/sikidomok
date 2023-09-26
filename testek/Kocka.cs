using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testek
{
    internal class Kocka : Test
    {
        public int a;

        public Kocka(int a) : base("Kocka")
        {
            this.a = a;
        }

        public override double felszin()
        {
            return 6 * a * a;
        }

        public override double terfogat()
        {
            return a * a * a;
        }
    }
}
