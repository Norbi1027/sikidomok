using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Test> test = new List<Test>();
            test.Add(new Kocka(10));
            test.Add(new Teglatest(20,12,32));
            test.Add(new Henger(12, 43));

            foreach (var item in test) {
                Console.WriteLine($"{item} \t felszine:{item.felszin()} \t térfogata:{item.terfogat()}");
            }
            Console.ReadKey();
        }
    }
}
