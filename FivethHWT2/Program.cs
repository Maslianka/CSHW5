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
            #region /*Declare myColl of 10 integers and fill it from Console.*/

            List<int> list = new List<int>(10);
            Console.WriteLine("Capacity of list : {0}", list.Capacity);
            for (int i = 0; i < list.Capacity; i++)
            {
                Console.Write($"enter num {i + 1}: ");
                list.Add(Convert.ToInt32(Console.ReadLine()));
            }

            ArrayList arrayList = new ArrayList(10);
            Console.WriteLine("Capacity of array list : {0}", arrayList.Capacity);
            for (int k = 0; k < arrayList.Capacity; k++)
            {
                Console.Write($"enter num {k + 1}: ");
                arrayList.Add(Convert.ToInt32(Console.ReadLine()));
            }

            #endregion

            #region /*Find and print all positions of element -10 in the collection*/

            for (int l = 0; l < (list.Count); l++)
            {
                if (list[l] == (-10))
                {
                    Console.WriteLine($"Position of list element -10 is {l + 1}");
                }
            }

            for (int g = 0; g < arrayList.Capacity; g++)
            {
                if ((int)arrayList[g] == (-10))
                {
                    Console.WriteLine($"Position of array list element -10 is {g + 1}");
                }
            }

            #endregion

            #region Remove from collection elements, which are greater then 20. Print collection

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > 20)
                {
                    Console.WriteLine($"Element {i + 1}: ({list[i]}) from list is greater then 20");
                }
            }

            for (int i = 0; i < arrayList.Capacity; i++)
            {
                if ((int)arrayList[i] > 20)
                {
                    Console.WriteLine($"Element {i + 1}: ({list[i]}) from array list is greater then 20");
                }
            }


            #endregion

            #region Insert elements 1,-3,-4 in positions 2, 8, 5. Print collection

            list.Insert(2, 1);
            list.Insert(8, -3);
            list.Insert(5, -4);

            arrayList.Insert(2, 1);
            arrayList.Insert(8, -3);
            arrayList.Insert(5, -4);

            #endregion

            #region Sort and print collection 

            list.Sort();
            arrayList.Sort();
            Console.WriteLine("list");
            foreach(int s in list)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("array list");
            foreach (int s in arrayList)
            {
                Console.WriteLine(s);
            }

            #endregion

            Console.ReadKey();
        }
    }
}
