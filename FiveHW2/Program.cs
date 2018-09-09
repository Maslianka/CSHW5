using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveHW2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<uint, string> persons = new Dictionary<uint, string>();
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"Enter your ID");
                uint id = Convert.ToUInt32(Console.ReadLine());
                Console.WriteLine($"Enter your name");
                string name = Console.ReadLine();
                persons.Add(id, name);
            }
            uint f = Convert.ToUInt32(Console.ReadLine());
            try
            {
                Console.WriteLine(persons[f]);
            }
            catch
            {

            }
            Console.ReadKey();
            
        }
    }
}
