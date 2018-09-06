using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveHW
{
    class Builder : IDeveloper
    {
        //Create two classes Programmer(with field language) and Builder(with field tool), which implement this interface.

        public Builder(string t)
        {
            this.tool = t;
        }

        string tool;

        public string Tool { get { return tool; } set { Tool = tool; } }

        public void Create()
        {
            Console.WriteLine($"Builder use {Tool} to bild hous");
        }

        public void Destroy()
        {
            Console.WriteLine($"Builder use {Tool} to destroy hous\n");
        }
    }
}
