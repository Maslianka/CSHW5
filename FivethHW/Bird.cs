using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FivethHW
{
    class Bird : IFlyable
    {
        public Bird(string n, string c)
        {
            this.name = n;
            this.camFly = c;
        }
        string name;
        string camFly;

        public void Fly()
        {
            Console.WriteLine($"Birds name is '{name}'. \nCan {name} fly? {camFly}");
        }
    }
}
