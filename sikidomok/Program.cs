using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sikidomok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Sikidom> sikidom = new List<Sikidom>();
            sikidom.Add(new Kör(10));
            sikidom.Add(new Négyzet(5));
            sikidom.Add(new Teglalap(12, 4));
            

            foreach (var item in sikidom) 
            {
                Console.WriteLine($"{item} {item.terulet()} {item.kerulet()}");
            }
            Console.ReadKey();
        }
    }
}
