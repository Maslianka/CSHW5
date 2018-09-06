using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FivethHW
{
    class Plane : IFlyable
    {
        public Plane(string m, string h)
        {
            this.mark = m;
            this.highFly = h;

        }
        string mark;
        string highFly;

        public void Fly()
        {
            Console.WriteLine($"Plane: '{mark}'.\nCan plane {mark} high fly? {highFly}");
        }
    }
}
