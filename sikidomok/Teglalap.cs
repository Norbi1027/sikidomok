using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sikidomok
{
    internal class Teglalap : Sikidom
    {
        public int a;
        public int b;
        public Teglalap(int a,int b) : base("Téglalap")
        {
            this.a = a;
            this.b = b;
        }

        public override double kerulet()
        {
            return 2*a*b;
        }

        public override double terulet()
        {
            return a*b;
        }
    }
}
