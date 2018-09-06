using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FivethHW
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IFlyable> flyables = new List<IFlyable>();
            flyables.Add(new Bird("Holub","Yes"));
            flyables.Add(new Bird("Chicken", "no"));
            flyables.Add(new Plane("cessna", "no"));
            flyables.Add(new Plane("Boeing", "yes"));
            foreach (var s in flyables)
            {
                s.Fly();
            }
            Console.ReadKey();

        }
    }
}
