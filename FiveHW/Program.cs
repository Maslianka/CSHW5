using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveHW
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create List of IDeveloper and add some Programmers and Builders to it.Call Create() and Destroy() methods, property Tool for all of it
            List<IDeveloper> developers = new List<IDeveloper>();
            developers.Add(new Programmer("C#"));
            developers.Add(new Programmer("C"));
            developers.Add(new Programmer("Javascript"));

            developers.Add(new Builder("hummer"));
            developers.Add(new Builder("roulette"));
            developers.Add(new Builder("screwdriver"));

            foreach (var s in developers)
            {
                s.Create();
                s.Destroy();
            }
            Console.ReadLine();

        }
}
}
