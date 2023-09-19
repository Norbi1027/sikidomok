using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace sikidomok
{
    class Négyzet : Sikidom
    {
        public int a;
        public Négyzet(int a) : base("Négyzet")
        {
        this.a = a;
        }

        public override double kerulet()
        {
            return 4 * a;
        }

        public override double terulet()
        {
            return a * a;
        }
    }
}
