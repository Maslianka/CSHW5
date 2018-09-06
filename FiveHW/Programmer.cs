using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveHW
{
    class Programmer : IDeveloper
    {
        //Create two classes Programmer(with field language) and Builder(with field tool), which implement this interface.
        public Programmer(string l)
        {
            language = l;
        }

        string language;
        public string Tool { get { return language; } set {Tool =language ; } }

        public void Create()
        {
            Console.WriteLine($"This programmer use {Tool} language");
        }

        public void Destroy()
        {
            Console.WriteLine($"This programmer use {Tool} language to crash sustem\n");
        }
    }
}
