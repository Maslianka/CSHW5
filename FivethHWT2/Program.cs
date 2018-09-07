using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FivethHWT2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>(10);
            Console.WriteLine("Capacity: {0}", list.Capacity);
            for (int i = 0; i < list.Capacity; i++)
            {
                Console.Write($"enter num {i+1}: ");
                list.Add(Convert.ToInt32(Console.ReadLine()));
            }
            foreach(int s in list)
            {
                Console.WriteLine($" {s} = {s}");
            }

            Console.WriteLine($"Index of element -10 = { list.IndexOf(-10)}");
            Console.ReadKey();
        }
    }
}
